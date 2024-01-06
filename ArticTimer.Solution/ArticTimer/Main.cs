using Newtonsoft.Json.Linq;
using SharpCompress.Archives;
using SharpCompress.Archives.SevenZip;
using System;
using System.IO;
using System.Windows.Forms;

namespace ArticTimer
{
    public partial class Main : Form
    {
        public Main(string filename = null, bool autoMode = false)
        {
            
            InitializeComponent();
            if (filename != null)
            {
                OnLoad();
                ReadConfig(filename, Path.GetFileName(filename), autoMode);
            }
            else
            {
                OnLoad();
            }
        }
        public void OnLoad()
        {
            DisplayLib.showAvailableDisplays(DisplayCombo);
            ReloadOutputs.Cursor = Cursors.Hand;
            // Replace "APTimer" with the specific name you want to match
            string folderNameToMatch = "APTimer";

            // Get the path to the TEMP directory
            string tempPath = Path.GetTempPath();

            // Get all subdirectories that contain the specified name
            string[] matchingFolders = Directory.GetDirectories(tempPath, "*" + folderNameToMatch + "*");

            // Delete each matching folder
            foreach (string folder in matchingFolders)
            {
                try
                {
                    Directory.Delete(folder, true);
                    Console.WriteLine($"Deleted folder: {folder}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting folder {folder}: {ex.Message}");
                }
            }
        }
        private void StartTimer_Click(object sender, EventArgs e)
        {
            StartTimer();
        }
        private void StartTimer()
        {
            try
            {
                if (DisplayCombo.SelectedItem is string selectedItem && selectedItem.StartsWith("DISPLAY"))
                {
                    string numericPart = selectedItem.Replace("DISPLAY", "");
                    if (int.TryParse(numericPart, out int monitorNumber))
                    {
                        int[] timerValues = GetTimerValues();
                        string backgroundImagePath = BgPathTxt.Text;
                        Console.WriteLine($"Timer Values: {timerValues[0]} hours, {timerValues[1]} minutes, {timerValues[2]} seconds");
                        StartTimerBtn.Enabled = false;
                        CloseTimer.Enabled = true;
                        LiveOnBtn.Enabled = true;
                        if (!string.IsNullOrEmpty(backgroundImagePath))
                        {
                            DisplayLib.showOnMonitor(monitorNumber, CreateTimerForm(backgroundImagePath));
                        }
                        else
                        {
                            DisplayLib.showOnMonitor(monitorNumber, CreateTimerForm(null));
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
        private TimerForm CreateTimerForm(string bg)
        {
            string hexColor = HexColorTxt.Text;
            int[] axis = GetAxis();
            int[] TimerValues = GetTimerValues();
            int[] values = {
                TimerValues[0],
                TimerValues[1],
                TimerValues[2],
                TimerValues[3],
                axis[0],
                axis[1]
            };
            string[] datas = {
                hexColor,
                bg
            };
            return new TimerForm(values, datas);
        }
        private int[] GetTimerValues()
        {
            return new int[] {
                int.Parse(hourNmb.Value.ToString()),
                int.Parse(minutesNmb.Value.ToString()),
                int.Parse(secondsNmb.Value.ToString()),
                int.Parse(FontSizeNbr.Value.ToString())
            };
        }
        private int[] GetAxis()
        {
            return new int[] {
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
                    string fileName = ofd.FileName;
                    BgPathTxt.Text = fileName;
                }
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TimerForm"] != null)
            {
                StartTimerBtn.Enabled = true;
                CloseTimer.Enabled = false;
                LiveOnBtn.Enabled = false;
                Application.OpenForms["TimerForm"].Close();
                if (Application.OpenForms["LiveOnForm"] != null)
                {
                    Application.OpenForms["LiveOnForm"].Close();
                }
            }
            else
            {
                MessageBox.Show("The timer hasn't been opened yet!");
            }
        }
        private void ReloadOutputs_Click(object sender, EventArgs e)
        {
            DisplayCombo.Items.Clear();
            OnLoad();
        }
        public void ReadConfigFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Config File|*.json;*.aptimer";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ReadConfig(ofd.FileName, ofd.SafeFileName, false);
                }
            }
        }
        public void ReadConfig(string filename, string safeFilename, bool autoMode)
        {
            if (Path.GetExtension(safeFilename) == ".json")
            {
                string jsonText = @File.ReadAllText(filename);
                JObject jsonObject = JObject.Parse(jsonText);
                string jsonFolder = filename.Replace($@"\{safeFilename}", "");

                int display = (int)jsonObject["display"] - 1;
                int axisX = (int)jsonObject["axis"]["x"];
                int axisY = (int)jsonObject["axis"]["y"];
                int timerHours = (int)jsonObject["timer"]["hours"];
                int timerMinutes = (int)jsonObject["timer"]["minutes"];
                int timerSeconds = (int)jsonObject["timer"]["seconds"];
                string backgroundImage = (string)jsonObject["extra"]["bg"];
                string bgFullPath = backgroundImage.Replace("$ThisPath", jsonFolder);
                string textColor = (string)jsonObject["extra"]["color"];
                int fontSize = (int)jsonObject["extra"]["size"];
                bool autoStart = (bool)jsonObject["extra"]["autostart"];

                DisplayCombo.SelectedIndex = display;
                XAxis.Value = axisX;
                YAxis.Value = axisY;
                hourNmb.Value = timerHours;
                minutesNmb.Value = timerMinutes;
                secondsNmb.Value = timerSeconds;
                BgPathTxt.Text = bgFullPath;
                HexColorTxt.Text = textColor;
                FontSizeNbr.Value = fontSize;
                if (autoStart || autoMode)
                {
                    StartTimer();
                }

            }
            else if (Path.GetExtension(safeFilename) == ".aptimer")
            {
                Random rdm = new Random();
                int rdmNumber = rdm.Next(100);
                string extractDirectory = $@"{Path.GetTempPath()}\APTimer{rdmNumber.ToString()}";
                if (!Directory.Exists(extractDirectory))
                {
                    Directory.CreateDirectory(extractDirectory);
                }
                using (var archive = SevenZipArchive.Open(filename))
                {
                    foreach (var entry in archive.Entries)
                    {
                        if (!entry.IsDirectory)
                        {
                            entry.WriteToDirectory(extractDirectory, new SharpCompress.Common.ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                }
                string jsonText = @File.ReadAllText($@"{extractDirectory}\aptimerConfig.json");
                JObject jsonObject = JObject.Parse(jsonText);

                int display = (int)jsonObject["display"] - 1;
                int axisX = (int)jsonObject["axis"]["x"];
                int axisY = (int)jsonObject["axis"]["y"];
                int timerHours = (int)jsonObject["timer"]["hours"];
                int timerMinutes = (int)jsonObject["timer"]["minutes"];
                int timerSeconds = (int)jsonObject["timer"]["seconds"];
                string backgroundImage = (string)jsonObject["extra"]["bg"];
                string bgFullPath = backgroundImage.Replace("$ThisPath", extractDirectory);
                string textColor = (string)jsonObject["extra"]["color"];
                int fontSize = (int)jsonObject["extra"]["size"];
                bool autoStart = (bool)jsonObject["extra"]["autostart"];

                DisplayCombo.SelectedIndex = display;
                XAxis.Value = axisX;
                YAxis.Value = axisY;
                hourNmb.Value = timerHours;
                minutesNmb.Value = timerMinutes;
                secondsNmb.Value = timerSeconds;
                BgPathTxt.Text = bgFullPath;
                HexColorTxt.Text = textColor;
                FontSizeNbr.Value = fontSize;
                if (autoStart || autoMode)
                {
                    StartTimer();
                }
            }
        }

        private void About_click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }

        public bool IsFormOpened(string FormName)
        {
            if (Application.OpenForms[FormName] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LiveONBtn_Event(object sender, EventArgs e)
        {
            if (!IsFormOpened("LiveOnForm"))
            {
                try
                {
                    if (DisplayCombo.SelectedItem is string selectedItem && selectedItem.StartsWith("DISPLAY"))
                    {
                        string numericPart = selectedItem.Replace("DISPLAY", "");
                        if (int.TryParse(numericPart, out int monitorNumber))
                        {
                            LiveOnForm prevForm = new LiveOnForm();
                            prevForm.Show();
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
            else if (IsFormOpened("LiveOnForm"))
            {
                Application.OpenForms["LiveOnForm"].Close();
            }
        }
    }
}