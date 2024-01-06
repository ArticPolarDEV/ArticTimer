using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ArticTimer.TaskCreator
{
    public partial class Main : Form
    {
        private TimeZoneInfo selectedTimezone;
        private Timer timer1;
        private Timer timer2; // Adicionado timer2 para o alarme
        private readonly string ArticTimerEXE = $@"{Application.StartupPath}\ArticTimer.exe";
        public Main()
        {
            InitializeComponent();
            CarregarTimezones();
            InicializarTimers();
            ArticTimerVerify();
        }
        private void RunArticTimer(string configFile)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.Arguments = '"' + configFile + '"' + " /auto";
                processStartInfo.FileName = ArticTimerEXE;
                processStartInfo.UseShellExecute = true;

                // Start App
                Process.Start(processStartInfo);

                // Close TaskCreator
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ArticTimerVerify()
        {
            if (!File.Exists(ArticTimerEXE))
            {
                MessageBox.Show("ArticTimer.exe not found in the app folder! Reinstall ArticTimer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Defina um código de saída personalizado
                Environment.ExitCode = 1;

                // Lança uma exceção de FileNotFoundException para sinalizar o erro
                throw new FileNotFoundException("Module not found");
            }
        }

        private void InicializarTimers()
        {
            // Inicializar timer2
            timer2 = new Timer
            {
                Enabled = false,
                Interval = 1000
            };
            timer2.Tick += (s, ev) => Timer2Tick(s, ev);
        }

        private void CarregarTimezones()
        {
            // Obter todas as timezones disponíveis
            ReadOnlyCollection<TimeZoneInfo> timezones = TimeZoneInfo.GetSystemTimeZones();

            // Adicionar as timezones ao ComboBox
            foreach (TimeZoneInfo timezone in timezones)
            {
                comboBox1.Items.Add(timezone.Id);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Quando uma timezone é selecionada, exibir o horário atual dela na label
            string selectedTimezoneId = comboBox1.SelectedItem.ToString();
            selectedTimezone = TimeZoneInfo.FindSystemTimeZoneById(selectedTimezoneId);

            // Verificar se o Timer já está em execução e, se estiver, pará-lo antes de iniciar um novo
            if (timer1 != null && timer1.Enabled)
            {
                timer1.Stop();
                timer1.Dispose(); // Liberar recursos do Timer anterior
            }

            // Criar um novo Timer
            timer1 = new Timer
            {
                Enabled = true,
                Interval = 1000
            };

            // Assinar o evento Tick
            timer1.Tick += (s, ev) => TimerTick(s, ev, selectedTimezone);
        }


        private void TimerTick(object sender, EventArgs e, TimeZoneInfo timeZoneInfo)
        {
            DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            LblTZone.Text = $"{currentTime}";
        }

        private void Timer2Tick(object sender, EventArgs e)
        {
            string SelectedAlarmTimer = $"{textBox1.Text} {textBox2.Text}";
            if (LblTZone.Text == SelectedAlarmTimer)
            {
                RunArticTimer(textBox3.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Certifique-se de parar e liberar recursos dos Timers ao fechar o formulário
                timer1.Stop();
                timer2.Stop();
                timer1.Dispose();
                timer2.Dispose();
            }
            catch {}
            
        }

        private void CreateTask_Click(object sender, EventArgs e)
        {
            // Definir o intervalo desejado para o Timer2 (alarme)
            timer2.Interval = 1000;
            timer2.Tick += Timer2Tick;

            // Iniciar o Timer2
            timer2.Start();
            MessageBox.Show("Running task");
            label4.Text = $"Selected: {textBox1.Text} {textBox2.Text}";
            CreateTask.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Config File|*.json;*.aptimer";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = ofd.FileName;
                }
            }
        }
    }
}
