using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ArticTimer
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                string ConfigPath = (args.Length > 0) ? args[0] : null;
                bool autoMode = args.Contains("/auto");

                if (ConfigPath != null)
                {
                    Application.Run(new Main(ConfigPath, autoMode));
                }
                else
                {
                    Application.Run(new Main(null, autoMode));
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show($"In Program.cs - Exception: {ex.Message}");
            }
        }

        /*static bool IsValidPath(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }*/
    }
}
