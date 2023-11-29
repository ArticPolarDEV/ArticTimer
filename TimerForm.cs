using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace ArticTimer
{
    public partial class TimerForm : Form
    {
        private int horas, minutos, segundos;
        private Timer timer = new Timer();
        public TimerForm(int hour, int minutes, int seconds, string bgImage = null)
        {
            InitializeComponent();
            ConfigLabelFont(hour, minutes, seconds);
            startTemporizer();
            setBackgroundImage(bgImage);
        }
        public void ConfigLabelFont(int hour, int minutes, int seconds)
        {
            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.DS_DIGIB.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.DS_DIGIB;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            //After that we can create font and assign font to label
            TimerLbl.Font = new Font(pfc.Families[0], TimerLbl.Font.Size);
            string TimerText = hour.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
            TimerLbl.Text = TimerText;
        }

        private void startTemporizer()
        {
            // Obter a string do tempo da label (assumindo que é "1:50:30")
            string tempoLabel = TimerLbl.Text;

            // Dividir a string em horas, minutos e segundos
            string[] partesTempo = tempoLabel.Split(':');
            if (partesTempo.Length == 3 &&
                int.TryParse(partesTempo[0], out horas) &&
                int.TryParse(partesTempo[1], out minutos) &&
                int.TryParse(partesTempo[2], out segundos))
            {
                // Iniciar o Timer
                timer.Interval = 1000; // 1 segundo
                timer.Tick += TimerTick;
                timer.Start();
            }
            else
            {
                MessageBox.Show("Formato de tempo inválido na label.");
            }
        }
        private void TimerTick(object sender, EventArgs e)
        {
            try
            {
                // Decrementar os segundos
                segundos--;

                // Verificar se precisamos ajustar minutos/horas
                if (segundos < 0)
                {
                    minutos--;
                    segundos = 59;

                    if (minutos < 0)
                    {
                        horas--;
                        minutos = 59;

                        if (horas < 0)
                        {
                            // Tempo esgotado, parar o Timer
                            timer.Stop();
                            MessageBox.Show("Tempo esgotado!");
                            TimerLbl.Text = "00:00:00";
                            return;
                        }
                    }
                }

                // Atualizar a label
                TimerLbl.Text = $"{Math.Max(horas, 0):D2}:{Math.Max(minutos, 0):D2}:{Math.Max(segundos, 0):D2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Internal Error: " + ex.Message);
                Close();
            }

        }
        public void setBackgroundImage(string FilePath)
        {
            if (FilePath != null)
            {
                try
                {
                    BackgroundImage = Image.FromFile(FilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while setting Background Image: " + ex.Message);
                    BackgroundImage = null;
                    BackColor = Color.Black;
                }
            }
        }
    }
}