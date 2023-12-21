namespace ArticTimer
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.StartTimerBtn = new System.Windows.Forms.Button();
            this.LabelSeconds = new System.Windows.Forms.Label();
            this.LabelHour = new System.Windows.Forms.Label();
            this.LabelMinutes = new System.Windows.Forms.Label();
            this.secondsNmb = new System.Windows.Forms.NumericUpDown();
            this.minutesNmb = new System.Windows.Forms.NumericUpDown();
            this.hourNmb = new System.Windows.Forms.NumericUpDown();
            this.YAxis = new System.Windows.Forms.NumericUpDown();
            this.XAxis = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BgPathTxt = new System.Windows.Forms.TextBox();
            this.HexColorTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FontSizeNbr = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CloseTimer = new System.Windows.Forms.Button();
            this.ReloadOutputs = new System.Windows.Forms.PictureBox();
            this.LiveOnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XAxis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeNbr)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadOutputs)).BeginInit();
            this.SuspendLayout();
            // 
            // StartTimerBtn
            // 
            this.StartTimerBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartTimerBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTimerBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.StartTimerBtn.ForeColor = System.Drawing.Color.White;
            this.StartTimerBtn.Location = new System.Drawing.Point(9, 17);
            this.StartTimerBtn.Name = "StartTimerBtn";
            this.StartTimerBtn.Size = new System.Drawing.Size(61, 28);
            this.StartTimerBtn.TabIndex = 6;
            this.StartTimerBtn.Text = "Start";
            this.StartTimerBtn.UseVisualStyleBackColor = false;
            this.StartTimerBtn.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // LabelSeconds
            // 
            this.LabelSeconds.AutoEllipsis = true;
            this.LabelSeconds.AutoSize = true;
            this.LabelSeconds.BackColor = System.Drawing.Color.Transparent;
            this.LabelSeconds.Font = new System.Drawing.Font("Arial", 10F);
            this.LabelSeconds.ForeColor = System.Drawing.Color.White;
            this.LabelSeconds.Location = new System.Drawing.Point(10, 64);
            this.LabelSeconds.Name = "LabelSeconds";
            this.LabelSeconds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelSeconds.Size = new System.Drawing.Size(70, 16);
            this.LabelSeconds.TabIndex = 6;
            this.LabelSeconds.Text = "Seconds: ";
            // 
            // LabelHour
            // 
            this.LabelHour.AutoEllipsis = true;
            this.LabelHour.AutoSize = true;
            this.LabelHour.BackColor = System.Drawing.Color.Transparent;
            this.LabelHour.Font = new System.Drawing.Font("Arial", 10F);
            this.LabelHour.ForeColor = System.Drawing.Color.White;
            this.LabelHour.Location = new System.Drawing.Point(27, 12);
            this.LabelHour.Name = "LabelHour";
            this.LabelHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelHour.Size = new System.Drawing.Size(52, 16);
            this.LabelHour.TabIndex = 7;
            this.LabelHour.Text = "Hours: ";
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.AutoEllipsis = true;
            this.LabelMinutes.AutoSize = true;
            this.LabelMinutes.BackColor = System.Drawing.Color.Transparent;
            this.LabelMinutes.Font = new System.Drawing.Font("Arial", 10F);
            this.LabelMinutes.ForeColor = System.Drawing.Color.White;
            this.LabelMinutes.Location = new System.Drawing.Point(16, 38);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMinutes.Size = new System.Drawing.Size(64, 16);
            this.LabelMinutes.TabIndex = 6;
            this.LabelMinutes.Text = "Minutes: ";
            // 
            // secondsNmb
            // 
            this.secondsNmb.Location = new System.Drawing.Point(80, 64);
            this.secondsNmb.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsNmb.Name = "secondsNmb";
            this.secondsNmb.Size = new System.Drawing.Size(60, 20);
            this.secondsNmb.TabIndex = 2;
            // 
            // minutesNmb
            // 
            this.minutesNmb.Location = new System.Drawing.Point(80, 38);
            this.minutesNmb.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNmb.Name = "minutesNmb";
            this.minutesNmb.Size = new System.Drawing.Size(60, 20);
            this.minutesNmb.TabIndex = 1;
            // 
            // hourNmb
            // 
            this.hourNmb.Location = new System.Drawing.Point(80, 12);
            this.hourNmb.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourNmb.Name = "hourNmb";
            this.hourNmb.Size = new System.Drawing.Size(60, 20);
            this.hourNmb.TabIndex = 0;
            // 
            // YAxis
            // 
            this.YAxis.Location = new System.Drawing.Point(20, 40);
            this.YAxis.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.YAxis.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.YAxis.Name = "YAxis";
            this.YAxis.Size = new System.Drawing.Size(120, 20);
            this.YAxis.TabIndex = 1;
            // 
            // XAxis
            // 
            this.XAxis.Location = new System.Drawing.Point(20, 14);
            this.XAxis.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.XAxis.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.XAxis.Name = "XAxis";
            this.XAxis.Size = new System.Drawing.Size(120, 20);
            this.XAxis.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "X: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(2, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Y: ";
            // 
            // BgPathTxt
            // 
            this.BgPathTxt.Location = new System.Drawing.Point(66, 20);
            this.BgPathTxt.Name = "BgPathTxt";
            this.BgPathTxt.Size = new System.Drawing.Size(119, 20);
            this.BgPathTxt.TabIndex = 14;
            // 
            // HexColorTxt
            // 
            this.HexColorTxt.Location = new System.Drawing.Point(66, 46);
            this.HexColorTxt.Name = "HexColorTxt";
            this.HexColorTxt.Size = new System.Drawing.Size(119, 20);
            this.HexColorTxt.TabIndex = 15;
            this.HexColorTxt.Text = "#ffffff";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(187, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OpenBgImage_func);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bg Image: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Timer Color: ";
            // 
            // DisplayCombo
            // 
            this.DisplayCombo.FormattingEnabled = true;
            this.DisplayCombo.Location = new System.Drawing.Point(12, 63);
            this.DisplayCombo.Name = "DisplayCombo";
            this.DisplayCombo.Size = new System.Drawing.Size(130, 21);
            this.DisplayCombo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Display Output: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "ArticPolar Timer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.XAxis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.YAxis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 76);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axis";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FontSizeNbr);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.HexColorTxt);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BgPathTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(184, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 106);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // FontSizeNbr
            // 
            this.FontSizeNbr.Location = new System.Drawing.Point(66, 72);
            this.FontSizeNbr.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FontSizeNbr.Name = "FontSizeNbr";
            this.FontSizeNbr.Size = new System.Drawing.Size(119, 20);
            this.FontSizeNbr.TabIndex = 8;
            this.FontSizeNbr.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Timer Size: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LabelHour);
            this.groupBox3.Controls.Add(this.LabelSeconds);
            this.groupBox3.Controls.Add(this.hourNmb);
            this.groupBox3.Controls.Add(this.minutesNmb);
            this.groupBox3.Controls.Add(this.LabelMinutes);
            this.groupBox3.Controls.Add(this.secondsNmb);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 94);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LiveOnBtn);
            this.groupBox4.Controls.Add(this.AboutBtn);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.CloseTimer);
            this.groupBox4.Controls.Add(this.StartTimerBtn);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(184, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 117);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // AboutBtn
            // 
            this.AboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.AboutBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.AboutBtn.ForeColor = System.Drawing.Color.White;
            this.AboutBtn.Location = new System.Drawing.Point(76, 17);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(69, 60);
            this.AboutBtn.TabIndex = 22;
            this.AboutBtn.Text = "About";
            this.AboutBtn.UseVisualStyleBackColor = false;
            this.AboutBtn.Click += new System.EventHandler(this.About_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(147, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 60);
            this.button2.TabIndex = 20;
            this.button2.Text = "Load Config";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ReadConfigFile_Click);
            // 
            // CloseTimer
            // 
            this.CloseTimer.BackColor = System.Drawing.Color.Transparent;
            this.CloseTimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseTimer.Enabled = false;
            this.CloseTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseTimer.Font = new System.Drawing.Font("Arial", 12F);
            this.CloseTimer.ForeColor = System.Drawing.Color.White;
            this.CloseTimer.Location = new System.Drawing.Point(9, 49);
            this.CloseTimer.Name = "CloseTimer";
            this.CloseTimer.Size = new System.Drawing.Size(61, 28);
            this.CloseTimer.TabIndex = 7;
            this.CloseTimer.Text = "Close";
            this.CloseTimer.UseVisualStyleBackColor = false;
            this.CloseTimer.Click += new System.EventHandler(this.Button3_Click);
            // 
            // ReloadOutputs
            // 
            this.ReloadOutputs.Image = ((System.Drawing.Image)(resources.GetObject("ReloadOutputs.Image")));
            this.ReloadOutputs.Location = new System.Drawing.Point(148, 64);
            this.ReloadOutputs.Name = "ReloadOutputs";
            this.ReloadOutputs.Size = new System.Drawing.Size(20, 20);
            this.ReloadOutputs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReloadOutputs.TabIndex = 23;
            this.ReloadOutputs.TabStop = false;
            this.ReloadOutputs.Click += new System.EventHandler(this.ReloadOutputs_Click);
            // 
            // LiveOnBtn
            // 
            this.LiveOnBtn.BackColor = System.Drawing.Color.Transparent;
            this.LiveOnBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.LiveOnBtn.Enabled = false;
            this.LiveOnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LiveOnBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.LiveOnBtn.ForeColor = System.Drawing.Color.White;
            this.LiveOnBtn.Location = new System.Drawing.Point(9, 83);
            this.LiveOnBtn.Name = "LiveOnBtn";
            this.LiveOnBtn.Size = new System.Drawing.Size(61, 28);
            this.LiveOnBtn.TabIndex = 24;
            this.LiveOnBtn.Text = "LiveON";
            this.LiveOnBtn.UseVisualStyleBackColor = false;
            this.LiveOnBtn.Click += new System.EventHandler(this.LiveONBtn_Event);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(414, 271);
            this.Controls.Add(this.ReloadOutputs);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DisplayCombo);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(430, 310);
            this.MinimumSize = new System.Drawing.Size(430, 310);
            this.Name = "Main";
            this.Text = "ArticTimer";
            ((System.ComponentModel.ISupportInitialize)(this.secondsNmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XAxis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeNbr)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReloadOutputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelSeconds;
        private System.Windows.Forms.Label LabelHour;
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.NumericUpDown secondsNmb;
        private System.Windows.Forms.NumericUpDown minutesNmb;
        private System.Windows.Forms.NumericUpDown hourNmb;
        private System.Windows.Forms.Button StartTimerBtn;
        private System.Windows.Forms.NumericUpDown YAxis;
        private System.Windows.Forms.NumericUpDown XAxis;
        private System.Windows.Forms.TextBox HexColorTxt;
        private System.Windows.Forms.TextBox BgPathTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DisplayCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CloseTimer;
        private System.Windows.Forms.PictureBox ReloadOutputs;
        private System.Windows.Forms.NumericUpDown FontSizeNbr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button LiveOnBtn;
    }
}

