using ArticTimer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticTimer
{
    public partial class LiveOnForm : Form
    {
        public LiveOnForm()
        {
            InitializeComponent();
            InitializeTimer();
            OnLoad();
            KeyDown += KeyDownHandler;
            DisplayCombo.KeyDown += KeyDownHandler;
        }

        public void OnLoad()
        {
            DisplayLib.showAvailableDisplays(DisplayCombo);
            ReloadOutputs.Cursor = Cursors.Hand;
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Fecha a form
                Close();
            }
        }

        private void InitializeTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // Atualizar a cada segundo
            timer.Tick += (sender, e) =>
            {
                if (DisplayCombo.SelectedItem is string selectedItem && selectedItem.StartsWith("DISPLAY"))
                {
                    string numericPart = selectedItem.Replace("DISPLAY", "");
                    if (int.TryParse(numericPart, out int monitorNumber))
                    {
                        DisplayCapture(monitorNumber);
                    }
                }
            };
            timer.Start();
        }


        private void DisplayCapture(int displayIndex)
        {
            DisplayPanel.BackgroundImage = DisplayLib.CaptureScreen(displayIndex);
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            topMost();
        }

        public void topMost()
        {
            TopMost = true;
            Activated += (sender, e) => TopMost = true;
        }

        private void ReloadOutputs_Click(object sender, EventArgs e)
        {
            DisplayCombo.Items.Clear();
            OnLoad();
        }

        private void DisplayCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DisplayCombo.SelectedItem is string selectedItem && selectedItem.StartsWith("DISPLAY"))
                {
                    string numericPart = selectedItem.Replace("DISPLAY", "");
                    if (int.TryParse(numericPart, out int monitorNumber))
                    {
                        DisplayCapture(monitorNumber);
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
    }
}
