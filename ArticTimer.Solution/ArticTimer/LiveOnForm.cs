using ArticTimer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticTimer
{
    public partial class LiveOnForm : Form
    {
        int index;

        public LiveOnForm(int displayIndex)
        {
            this.index = displayIndex;
            InitializeComponent();
            InitializeTimer();
            KeyDown += KeyDownHandler;
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Fecha a form
                this.Close();
            }
        }

        private void InitializeTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1; // Atualizar a cada segundo
            timer.Tick += (sender, e) => DisplayCapture(index - 1);
            timer.Start();
        }

        private void DisplayCapture(int displayIndex)
        {
            DisplayPanel.BackgroundImage = DisplayLib.CaptureScreen(displayIndex);
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            DisplayCapture(index - 1);
            topMost();
        }

        public void topMost()
        {
            TopMost = true;
            Activated += (sender, e) => TopMost = true;
        }
    }
}
