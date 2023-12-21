using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArticTimer
{
    internal class DisplayLib
    {
        private static bool isAlreadyShowed = false;

        public static void showOnMonitor(int showOnMonitor, Form form)
        {
            Screen[] sc = Screen.AllScreens;

            if (showOnMonitor >= sc.Length)
            {
                showOnMonitor = 0;
            }

            // Create a list to store forms that need to be closed
            List<Form> formsToClose = new List<Form>();

            // Identify forms associated with TimerForm
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == typeof(TimerForm))
                {
                    formsToClose.Add(openForm);
                }
            }

            // Close the identified forms
            foreach (Form formToClose in formsToClose)
            {
                formToClose.Close();
            }

            // Reset the flag if trying to show on a different monitor
            if (isAlreadyShowed)
            {
                isAlreadyShowed = false;
            }

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(sc[showOnMonitor].Bounds.Left, sc[showOnMonitor].Bounds.Top);
            form.WindowState = FormWindowState.Normal;
            form.WindowState = FormWindowState.Maximized;

            // Show the form
            form.Show();

            // Set the flag to true
            isAlreadyShowed = true;
        }

        public static void showAvailableDisplays(ComboBox combo)
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                combo.Items.Add(screen.DeviceName.Replace(@"\\.\", ""));
            }
        }
        public static Bitmap CaptureScreen(int screenIndex)
        {
            Screen[] screens = Screen.AllScreens;

            if (screenIndex >= screens.Length)
            {
                screenIndex = 0;
            }

            Rectangle bounds = screens[screenIndex].Bounds;
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }

            return bitmap;
        }
    }
}
