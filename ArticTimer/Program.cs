using System;
using System.Diagnostics;
using System.IO;
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
                if (ConfigPath != null)
                {
                    if (IsValidPath(ConfigPath))
                    {
                        Application.Run(new Main(ConfigPath));
                    }
                    else
                    {
                        Application.Run(new Main(null));
                    }
                }
                else
                {
                    Application.Run(new Main(null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"In Program.cs - Exception: {ex.Message}");
            }
        }
        static bool IsValidPath(string path)
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
        }
    }
}
