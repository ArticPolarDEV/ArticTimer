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
using System.IO;

namespace ArticTimer
{
    public partial class TimerForm : Form
    {
        private int horas, minutos, segundos;
        private Timer timer = new Timer();
        public TimerForm(int hour, int minutes, int seconds, int[] Axis, string bgImage = null, string HexColor = "#ffffff", string FontPATH = null)
        {
            InitializeComponent();
            ConfigLabelFont(hour, minutes, seconds, HexColor, FontPATH);
            startTemporizer();
            setBackgroundImage(bgImage);
            setTimerAxis(Axis);
            TopMostConfig();
        }
        public void ConfigLabelFont(int hour, int minutes, int seconds, string HexColor, string FontPath)
        {
            try
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                FontFamily fontFamily;

                if (!string.IsNullOrEmpty(FontPath))
                {
                    pfc.AddFontFile(FontPath);
                    fontFamily = pfc.Families[0];
                }
                else
                {
                    pfc.AddFontFile(Path.Combine(Application.StartupPath, "DEFAULT.TTF"));
                    fontFamily = pfc.Families[0];
                }

                Font DefaultFont = new Font(fontFamily, TimerLbl.Font.Size, FontStyle.Regular);
                TimerLbl.Font = DefaultFont;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            string TimerText = $"{hour:D2}:{minutes:D2}:{seconds:D2}";
            TimerLbl.Text = TimerText;
            Color color = HexToColor(HexColor);
            TimerLbl.ForeColor = color;
        }

        private Color HexToColor(string hex)
        {
            // Remova o caractere '#' se estiver presente
            if (hex.StartsWith("#"))
                hex = hex.Substring(1);

            // Converte a string hex em um objeto Color
            return ColorTranslator.FromHtml("#" + hex);
        }
        private void startTemporizer()
        {
            try
            {
                string tempoLabel = TimerLbl.Text;
                string[] partesTempo = tempoLabel.Split(':');

                if (partesTempo.Length == 3 &&
                    int.TryParse(partesTempo[0], out horas) &&
                    int.TryParse(partesTempo[1], out minutos) &&
                    int.TryParse(partesTempo[2], out segundos))
                {
                    timer.Interval = 1000;
                    timer.Tick += TimerTick;
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Formato de tempo inválido na label.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o temporizador: " + ex.Message);
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            try
            {
                segundos--;

                if (segundos < 0)
                {
                    segundos = 59;

                    if (--minutos < 0)
                    {
                        minutos = 59;

                        if (--horas < 0)
                        {
                            timer.Stop();
                            MessageBox.Show("Tempo esgotado!");
                            UpdateTimerLabel("00:00:00");
                            return;
                        }
                    }
                }

                UpdateTimerLabel($"{horas:D2}:{minutos:D2}:{segundos:D2}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro interno: " + ex.Message);
            }
        }

        private void UpdateTimerLabel(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateTimerLabel), text);
            }
            else
            {
                TimerLbl.Text = text;
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
        public void setTimerAxis(int[] axis)
        {
            TimerLbl.Location = new Point(axis[0], axis[1]);
        }
        private void TopMostConfig()
        {
            // Defina a propriedade TopMost para true
            TopMost = true;

            // Adicione o evento Activated para garantir que a form sempre está no topo quando ativada
            Activated += (sender, e) => TopMost = true;
        }
        public void StopAll()
        {
            timer.Stop();
            Close();
            Dispose();
        }
        public void Pause()
        {
            timer.Stop();
        }
        public void Resume()
        {
            timer.Start();
        }
    }
}