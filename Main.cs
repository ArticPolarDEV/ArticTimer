using System;
using System.Windows.Forms;

namespace ArticTimer
{
    public partial class Main : Form
    {
        private TimerForm timerForm;
        public Main()
        {
            InitializeComponent();
            OnLoad();
        }
        public void OnLoad()
        {
            DisplayLib.showAvailableDisplays(DisplayCombo);
        }
        private void StartTimer(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = DisplayCombo.SelectedItem as string;

                if (selectedItem != null && selectedItem.StartsWith("DISPLAY"))
                {
                    string numericPart = selectedItem.Replace("DISPLAY", "");

                    if (int.TryParse(numericPart, out int monitorNumber))
                    {
                        string backgroundImagePath = BgPathTxt.Text;
                        int[] timerValues = GetTimerValues();

                        Console.WriteLine($"Timer Values: {timerValues[0]} hours, {timerValues[1]} minutes, {timerValues[2]} seconds");
                        StartTimerBtn.Enabled = false;
                        CloseTimer.Enabled = true;
                        ResumeBtn.Enabled = true;
                        PauseBtn.Enabled = true;
                        if (string.IsNullOrEmpty(backgroundImagePath))
                        {
                            timerForm = CreateTimerForm(timerValues, null);
                            DisplayLib.showOnMonitor(monitorNumber, timerForm);
                        }
                        else
                        {
                            timerForm = CreateTimerForm(timerValues, backgroundImagePath);
                            DisplayLib.showOnMonitor(monitorNumber, timerForm);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao converter a parte numérica para um inteiro.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleção inválida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        private TimerForm CreateTimerForm(int[] timerValues, string backgroundImagePath)
        {
            string hexColor = HexColorTxt.Text;
            string TimerFontPath = TimerFontTxt.Text;
            int[] axis = GetAxis();
            return new TimerForm(timerValues[0], timerValues[1], timerValues[2], axis, backgroundImagePath, hexColor, TimerFontPath);
        }

        private int[] GetTimerValues()
        {
            return new int[]
            {
                int.Parse(hourNmb.Value.ToString()),
                int.Parse(minutesNmb.Value.ToString()),
                int.Parse(secondsNmb.Value.ToString())
            };
        }
        private int[] GetAxis()
        {
            return new int[]
            {
                int.Parse(XAxis.Value.ToString()),
                int.Parse(YAxis.Value.ToString())
            };
        }
        private void OpenBgImage_func(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name and display it
                    string fileName = ofd.FileName;

                    // Now you can do something with the selected file, like setting it as a background image
                    // For example, if you have a PictureBox named pictureBox1:
                    BgPathTxt.Text = fileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Font Files|*.ttf;*.otf";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name and display it
                    string fileName = ofd.FileName;

                    // Now you can do something with the selected file, like setting it as a background image
                    // For example, if you have a PictureBox named pictureBox1:
                    TimerFontTxt.Text = fileName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartTimerBtn.Enabled = true;
            CloseTimer.Enabled = false;
            ResumeBtn.Enabled = false;
            PauseBtn.Enabled = false;
            // Verifique se a instância da TimerForm foi criada e não foi descartada
            if (timerForm != null && !timerForm.IsDisposed)
            {
                // Chame o método StopAll na TimerForm
                timerForm.StopAll();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayCombo.Items.Clear();
            OnLoad();
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            StartTimerBtn.Enabled = false;
            CloseTimer.Enabled = true;
            ResumeBtn.Enabled = false;
            PauseBtn.Enabled = true;
            // Verifique se a instância da TimerForm foi criada e não foi descartada
            if (timerForm != null && !timerForm.IsDisposed)
            {
                // Chame o método StopAll na TimerForm
                timerForm.Resume();
            }
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            StartTimerBtn.Enabled = false;
            CloseTimer.Enabled = true;
            ResumeBtn.Enabled = true;
            PauseBtn.Enabled = false;
            // Verifique se a instância da TimerForm foi criada e não foi descartada
            if (timerForm != null && !timerForm.IsDisposed)
            {
                // Chame o método StopAll na TimerForm
                timerForm.Pause();
            }
        }
    }
}
