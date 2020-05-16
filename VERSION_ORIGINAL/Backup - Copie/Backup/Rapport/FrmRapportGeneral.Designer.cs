namespace Backup.Rapport
{
    partial class FrmRapportGeneral
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.RpEmprunt1 = new Backup.Rapport.RpEmprunt();
            this.ViewRepport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RapportEmprunt2 = new Backup.Rapport.RapportEmprunt();
            this.RapportEmprunt1 = new Backup.Rapport.RapportEmprunt();
            this.RpEmprunt2 = new Backup.Rapport.RpEmprunt();
            this.RapportEmprunt3 = new Backup.Rapport.RapportEmprunt();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.date2);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 499);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(228)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Imprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(5, 29);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(143, 21);
            this.date2.TabIndex = 1;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(5, 3);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(143, 21);
            this.date1.TabIndex = 0;
            // 
            // ViewRepport
            // 
            this.ViewRepport.ActiveViewIndex = -1;
            this.ViewRepport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewRepport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewRepport.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewRepport.Location = new System.Drawing.Point(162, 3);
            this.ViewRepport.Name = "ViewRepport";
            this.ViewRepport.Size = new System.Drawing.Size(739, 551);
            this.ViewRepport.TabIndex = 1;
            // 
            // FrmRapportGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewRepport);
            this.Name = "FrmRapportGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRapportGeneral";
            this.Load += new System.EventHandler(this.FrmRapportGeneral_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RpEmprunt RpEmprunt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ViewRepport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private RapportEmprunt RapportEmprunt2;
        private RapportEmprunt RapportEmprunt1;
        private RpEmprunt RpEmprunt2;
        private RapportEmprunt RapportEmprunt3;
    }
}