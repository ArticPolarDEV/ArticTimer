using System;
using System.Windows.Forms;

namespace ArticTimer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            OnLoad();
        }
        public void OnLoad()
        {
            DisplayLib.showAvailableDisplays(DisplayCombo);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);

        }

        private void StartTimer(object sender, EventArgs e)
        {
            // Get the selected item from the ComboBox
            string selectedItem = DisplayCombo.SelectedItem as string;

            // Extract the numeric part from the selected item
            if (selectedItem != null && selectedItem.StartsWith("DISPLAY"))
            {
                string numericPart = selectedItem.Replace("DISPLAY", "");

                // Convert the numeric part to an integer
                if (int.TryParse(numericPart, out int monitorNumber))
                {
                    // Call the method in DisplayLib
                    string backgroundImagePath = bunifuTextBox1.Text;

                    int[] timerValues = GetTimerValues();

                    // Add debugging messages
                    Console.WriteLine($"Timer Values: {timerValues[0]} hours, {timerValues[1]} minutes, {timerValues[2]} seconds");

                    if (string.IsNullOrEmpty(backgroundImagePath))
                    {
                        DisplayLib.showOnMonitor(monitorNumber, new TimerForm(timerValues[0], timerValues[1], timerValues[2], bgImage: null));
                    }
                    else
                    {
                        DisplayLib.showOnMonitor(monitorNumber, new TimerForm(timerValues[0], timerValues[1], timerValues[2], bgImage: backgroundImagePath));
                    }
                }
                else
                {
                    // Handle the case where conversion fails
                    MessageBox.Show("Failed to convert numeric part to an integer.");
                }
            }
            else
            {
                // Handle the case where the selected item doesn't start with "DISPLAY"
                MessageBox.Show("Invalid selection.");
            }
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
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
        }

        private void bgImgCheckbox_func(object sender, EventArgs e)
        {
            if (bgImgCheckbox.Checked)
            {
                bunifuPanel4.Visible = true;
            }
            else
            {
                bunifuPanel4.Visible = false;
            }
        }

        private void OpenBgImage_func(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name and display it
                    string fileName = ofd.FileName;

                    // Now you can do something with the selected file, like setting it as a background image
                    // For example, if you have a PictureBox named pictureBox1:
                    bunifuTextBox1.Text = fileName;
                }
            }
        }
    }
}
