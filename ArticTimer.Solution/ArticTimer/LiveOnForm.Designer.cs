namespace ArticTimer
{
    partial class LiveOnForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiveOnForm));
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReloadOutputs = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadOutputs)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DisplayPanel.Location = new System.Drawing.Point(13, 80);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(258, 123);
            this.DisplayPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "LiveON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(202, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESC to Close";
            // 
            // ReloadOutputs
            // 
            this.ReloadOutputs.Image = ((System.Drawing.Image)(resources.GetObject("ReloadOutputs.Image")));
            this.ReloadOutputs.Location = new System.Drawing.Point(251, 54);
            this.ReloadOutputs.Name = "ReloadOutputs";
            this.ReloadOutputs.Size = new System.Drawing.Size(20, 20);
            this.ReloadOutputs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReloadOutputs.TabIndex = 26;
            this.ReloadOutputs.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Display Output: ";
            // 
            // DisplayCombo
            // 
            this.DisplayCombo.FormattingEnabled = true;
            this.DisplayCombo.Location = new System.Drawing.Point(15, 50);
            this.DisplayCombo.Name = "DisplayCombo";
            this.DisplayCombo.Size = new System.Drawing.Size(230, 24);
            this.DisplayCombo.TabIndex = 24;
            this.DisplayCombo.SelectedIndexChanged += new System.EventHandler(this.DisplayCombo_SelectedIndexChanged);
            // 
            // LiveOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(283, 229);
            this.Controls.Add(this.ReloadOutputs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DisplayCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayPanel);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LiveOnForm";
            this.Text = "LiveON";
            ((System.ComponentModel.ISupportInitialize)(this.ReloadOutputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ReloadOutputs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DisplayCombo;
    }
}