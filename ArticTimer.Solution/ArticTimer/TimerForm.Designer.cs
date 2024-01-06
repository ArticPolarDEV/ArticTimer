namespace ArticTimer
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.TimerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerLbl
            // 
            this.TimerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerLbl.BackColor = System.Drawing.Color.Transparent;
            this.TimerLbl.Font = new System.Drawing.Font("Arial", 135F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLbl.Location = new System.Drawing.Point(12, 41);
            this.TimerLbl.Name = "TimerLbl";
            this.TimerLbl.Size = new System.Drawing.Size(788, 358);
            this.TimerLbl.TabIndex = 0;
            this.TimerLbl.Text = "00:00:00";
            this.TimerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimerLbl.UseCompatibleTextRendering = true;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 498);
            this.Controls.Add(this.TimerLbl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimerForm";
            this.Text = "Timer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedForm);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TimerLbl;
    }
}