namespace Backup.Formulaire
{
    partial class FrmAjout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkrayon = new System.Windows.Forms.RadioButton();
            this.checkdomaine = new System.Windows.Forms.RadioButton();
            this.checketala = new System.Windows.Forms.RadioButton();
            this.rech = new System.Windows.Forms.TextBox();
            this.Table1 = new System.Windows.Forms.DataGridView();
            this.domaine = new System.Windows.Forms.GroupBox();
            this.txtdomaine = new System.Windows.Forms.TextBox();
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ray = new System.Windows.Forms.GroupBox();
            this.txtRayon = new System.Windows.Forms.TextBox();
            this.iTalk_Button_22 = new iTalk.iTalk_Button_2();
            this.label7 = new System.Windows.Forms.Label();
            this.eta = new System.Windows.Forms.GroupBox();
            this.txtRayonEt = new System.Windows.Forms.ComboBox();
            this.txtetalage = new System.Windows.Forms.TextBox();
            this.iTalk_Button_12 = new iTalk.iTalk_Button_2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).BeginInit();
            this.domaine.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ray.SuspendLayout();
            this.eta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkrayon);
            this.panel1.Controls.Add(this.checkdomaine);
            this.panel1.Controls.Add(this.checketala);
            this.panel1.Controls.Add(this.rech);
            this.panel1.Controls.Add(this.Table1);
            this.panel1.Controls.Add(this.domaine);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 719);
            this.panel1.TabIndex = 0;
            // 
            // checkrayon
            // 
            this.checkrayon.AutoSize = true;
            this.checkrayon.Location = new System.Drawing.Point(282, 71);
            this.checkrayon.Name = "checkrayon";
            this.checkrayon.Size = new System.Drawing.Size(92, 17);
            this.checkrayon.TabIndex = 693;
            this.checkrayon.TabStop = true;
            this.checkrayon.Text = "Ajouter Rayon";
            this.checkrayon.UseVisualStyleBackColor = true;
            this.checkrayon.CheckedChanged += new System.EventHandler(this.checkrayon_CheckedChanged);
            // 
            // checkdomaine
            // 
            this.checkdomaine.AutoSize = true;
            this.checkdomaine.Location = new System.Drawing.Point(138, 71);
            this.checkdomaine.Name = "checkdomaine";
            this.checkdomaine.Size = new System.Drawing.Size(103, 17);
            this.checkdomaine.TabIndex = 692;
            this.checkdomaine.TabStop = true;
            this.checkdomaine.Text = "Ajouter Domaine";
            this.checkdomaine.UseVisualStyleBackColor = true;
            this.checkdomaine.CheckedChanged += new System.EventHandler(this.checkdomaine_CheckedChanged);
            // 
            // checketala
            // 
            this.checketala.AutoSize = true;
            this.checketala.Location = new System.Drawing.Point(4, 70);
            this.checketala.Name = "checketala";
            this.checketala.Size = new System.Drawing.Size(97, 17);
            this.checketala.TabIndex = 691;
            this.checketala.TabStop = true;
            this.checketala.Text = "Ajouter Etalage";
            this.checketala.UseVisualStyleBackColor = true;
            this.checketala.CheckedChanged += new System.EventHandler(this.etala_CheckedChanged);
            // 
            // rech
            // 
            this.rech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rech.Location = new System.Drawing.Point(753, 67);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(205, 21);
            this.rech.TabIndex = 689;
            this.rech.Text = "Rechercher dans :  Tableau";
            this.rech.TextChanged += new System.EventHandler(this.rech_TextChanged);
            this.rech.Enter += new System.EventHandler(this.rech_Enter);
            this.rech.Leave += new System.EventHandler(this.rech_Leave);
            // 
            // Table1
            // 
            this.Table1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table1.BackgroundColor = System.Drawing.Color.White;
            this.Table1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.Table1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table1.GridColor = System.Drawing.Color.White;
            this.Table1.Location = new System.Drawing.Point(371, 93);
            this.Table1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Table1.Name = "Table1";
            this.Table1.ReadOnly = true;
            this.Table1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Table1.RowHeadersVisible = false;
            this.Table1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Table1.RowTemplate.Height = 20;
            this.Table1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Table1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table1.Size = new System.Drawing.Size(587, 624);
            this.Table1.TabIndex = 688;
            this.Table1.Click += new System.EventHandler(this.Table1_Click);
            // 
            // domaine
            // 
            this.domaine.Controls.Add(this.txtdomaine);
            this.domaine.Controls.Add(this.iTalk_Button_21);
            this.domaine.Controls.Add(this.label5);
            this.domaine.Location = new System.Drawing.Point(9, 335);
            this.domaine.Name = "domaine";
            this.domaine.Size = new System.Drawing.Size(354, 163);
            this.domaine.TabIndex = 687;
            this.domaine.TabStop = false;
            this.domaine.Text = "Ajouter Domaine";
            // 
            // txtdomaine
            // 
            this.txtdomaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdomaine.Location = new System.Drawing.Point(59, 57);
            this.txtdomaine.Name = "txtdomaine";
            this.txtdomaine.Size = new System.Drawing.Size(208, 21);
            this.txtdomaine.TabIndex = 683;
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(110, 100);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(68, 23);
            this.iTalk_Button_21.TabIndex = 677;
            this.iTalk_Button_21.Text = "Enregistrer";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(53, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 681;
            this.label5.Text = "Designation";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ray);
            this.panel2.Controls.Add(this.eta);
            this.panel2.Location = new System.Drawing.Point(4, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 623);
            this.panel2.TabIndex = 686;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(113, 424);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 708;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(113, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 707;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 706;
            this.pictureBox1.TabStop = false;
            // 
            // ray
            // 
            this.ray.Controls.Add(this.txtRayon);
            this.ray.Controls.Add(this.iTalk_Button_22);
            this.ray.Controls.Add(this.label7);
            this.ray.Location = new System.Drawing.Point(3, 477);
            this.ray.Name = "ray";
            this.ray.Size = new System.Drawing.Size(355, 162);
            this.ray.TabIndex = 686;
            this.ray.TabStop = false;
            this.ray.Text = "Ajouter Rayon";
            this.ray.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtRayon
            // 
            this.txtRayon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRayon.Location = new System.Drawing.Point(60, 53);
            this.txtRayon.Name = "txtRayon";
            this.txtRayon.Size = new System.Drawing.Size(208, 21);
            this.txtRayon.TabIndex = 683;
            // 
            // iTalk_Button_22
            // 
            this.iTalk_Button_22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iTalk_Button_22.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_22.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_22.Image = null;
            this.iTalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_22.Location = new System.Drawing.Point(110, 82);
            this.iTalk_Button_22.Name = "iTalk_Button_22";
            this.iTalk_Button_22.Size = new System.Drawing.Size(68, 23);
            this.iTalk_Button_22.TabIndex = 677;
            this.iTalk_Button_22.Text = "Enregistrer";
            this.iTalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_22.Click += new System.EventHandler(this.iTalk_Button_22_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(57, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 681;
            this.label7.Text = "Designation";
            // 
            // eta
            // 
            this.eta.Controls.Add(this.txtRayonEt);
            this.eta.Controls.Add(this.txtetalage);
            this.eta.Controls.Add(this.iTalk_Button_12);
            this.eta.Controls.Add(this.label3);
            this.eta.Controls.Add(this.label2);
            this.eta.Location = new System.Drawing.Point(3, 43);
            this.eta.Name = "eta";
            this.eta.Size = new System.Drawing.Size(355, 167);
            this.eta.TabIndex = 682;
            this.eta.TabStop = false;
            this.eta.Text = "Ajouter Etalage";
            // 
            // txtRayonEt
            // 
            this.txtRayonEt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRayonEt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtRayonEt.BackColor = System.Drawing.Color.White;
            this.txtRayonEt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtRayonEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRayonEt.FormattingEnabled = true;
            this.txtRayonEt.Location = new System.Drawing.Point(57, 96);
            this.txtRayonEt.Margin = new System.Windows.Forms.Padding(2);
            this.txtRayonEt.Name = "txtRayonEt";
            this.txtRayonEt.Size = new System.Drawing.Size(208, 21);
            this.txtRayonEt.TabIndex = 684;
            this.txtRayonEt.SelectedIndexChanged += new System.EventHandler(this.txtRayonEt_SelectedIndexChanged);
            // 
            // txtetalage
            // 
            this.txtetalage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtetalage.Location = new System.Drawing.Point(57, 48);
            this.txtetalage.Name = "txtetalage";
            this.txtetalage.Size = new System.Drawing.Size(208, 21);
            this.txtetalage.TabIndex = 683;
            // 
            // iTalk_Button_12
            // 
            this.iTalk_Button_12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iTalk_Button_12.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_12.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_12.Image = null;
            this.iTalk_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_12.Location = new System.Drawing.Point(110, 130);
            this.iTalk_Button_12.Name = "iTalk_Button_12";
            this.iTalk_Button_12.Size = new System.Drawing.Size(68, 24);
            this.iTalk_Button_12.TabIndex = 677;
            this.iTalk_Button_12.Text = "Enregistrer";
            this.iTalk_Button_12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_12.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(54, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 682;
            this.label3.Text = "Rayon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(54, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 681;
            this.label2.Text = "Etalage";
            // 
            // FrmAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 743);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAjout";
            this.Text = "FrmAjout";
            this.Load += new System.EventHandler(this.FrmAjout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).EndInit();
            this.domaine.ResumeLayout(false);
            this.domaine.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ray.ResumeLayout(false);
            this.ray.PerformLayout();
            this.eta.ResumeLayout(false);
            this.eta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox domaine;
        private System.Windows.Forms.TextBox txtdomaine;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox ray;
        private System.Windows.Forms.TextBox txtRayon;
        private iTalk.iTalk_Button_2 iTalk_Button_22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox eta;
        private System.Windows.Forms.ComboBox txtRayonEt;
        private System.Windows.Forms.TextBox txtetalage;
        private iTalk.iTalk_Button_2 iTalk_Button_12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rech;
        private System.Windows.Forms.DataGridView Table1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton checkrayon;
        private System.Windows.Forms.RadioButton checkdomaine;
        private System.Windows.Forms.RadioButton checketala;
    }
}