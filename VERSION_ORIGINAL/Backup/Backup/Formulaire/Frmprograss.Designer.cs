namespace Backup
{
    partial class Frmprograss
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprograss));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar1__ = new iTalk.iTalk_ProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressBar1__
            // 
            this.ProgressBar1__.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ProgressBar1__.Location = new System.Drawing.Point(1, 1);
            this.ProgressBar1__.Maximum = ((long)(100));
            this.ProgressBar1__.MinimumSize = new System.Drawing.Size(100, 100);
            this.ProgressBar1__.Name = "ProgressBar1__";
            this.ProgressBar1__.Padding = new System.Windows.Forms.Padding(2);
            this.ProgressBar1__.ProgressColor1 = System.Drawing.Color.White;
            this.ProgressBar1__.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.ProgressBar1__.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
            this.ProgressBar1__.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProgressBar1__.Size = new System.Drawing.Size(130, 130);
            this.ProgressBar1__.TabIndex = 711;
            this.ProgressBar1__.Text = "iTalk_ProgressBar1";
            this.ProgressBar1__.Value = ((long)(0));
            // 
            // Frmprograss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(130, 130);
            this.Controls.Add(this.ProgressBar1__);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmprograss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmprograss";
            this.Load += new System.EventHandler(this.Frmprograss_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private iTalk.iTalk_ProgressBar ProgressBar1__;
    }
}