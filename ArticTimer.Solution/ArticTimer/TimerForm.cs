using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace ArticTimer
{
    public partial class TimerForm : Form
    {
        private int horas, minutos, segundos;
        private Timer timer = new Timer();

        public TimerForm(int[] values, string[] datas)
        {
            InitializeComponent();
            ConfigLabelFont(values, datas);
            StartTemporizer();
            SetBackgroundImage(datas);
            SetTimerAxis(values);
            TopMostConfig();
        }
        public void ConfigLabelFont(int[] values, string[] datas)
        {
            int hour = values.Length > 0 ? values[0] : 0;
            int minutes = values.Length > 1 ? values[1] : 10;
            int seconds = values.Length > 2 ? values[2] : 0;
            int FontSize = values.Length > 3 ? values[3] : 135;
            string HexColor = datas.Length > 0 ? datas[0] : "#ffffff";

            string TimerText = $"{hour:D2}:{minutes:D2}:{seconds:D2}";
            TimerLbl.Text = TimerText;
            TimerLbl.Font = new Font("Arial", FontSize, FontStyle.Regular);
            Color color = HexToColor(HexColor);
            TimerLbl.ForeColor = color;
        }

        private Color HexToColor(string hex)
        {
            hex = hex.Replace(" ", "");
            // Remova o caractere '#' se estiver presente
            if (hex.StartsWith("#"))
                hex = hex.Substring(1);

            // Converte a string hex em um objeto Color
            return ColorTranslator.FromHtml("#" + hex);
        }
        private void StartTemporizer()
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
                            // MessageBox.Show("Time is over!");
                            if (InvokeRequired)
                            {
                                Invoke(new Action(() => { UpdateTimerLabel(@"00:00:00"); }));
                            }
                            else
                            {
                                UpdateTimerLabel(@"00:00:00");
                            }
                            return;
                        }
                    }
                }

                if (InvokeRequired)
                {
                    Invoke(new Action(() => { UpdateTimerLabel($"{horas:D2}:{minutos:D2}:{segundos:D2}"); }));
                }
                else
                {
                    UpdateTimerLabel($"{horas:D2}:{minutos:D2}:{segundos:D2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in TimerTick: " + ex.Message);
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

        public void SetBackgroundImage(string[] datas)
        {
            if (!string.IsNullOrEmpty(datas[1]))
            {
                try
                {
                    BackgroundImage = Image.FromFile(datas[1]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while setting Background Image: " + ex.Message);
                    BackgroundImage = null;
                    BackColor = Color.Black;
                }
            }
        }
        public void SetTimerAxis(int[] axis)
        {
            TimerLbl.Location = new Point(axis[4], axis[5]);
        }
        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }
        private void TopMostConfig()
        {
            TopMost = true;
            Activated += (sender, e) => TopMost = true;
        }
    }
}