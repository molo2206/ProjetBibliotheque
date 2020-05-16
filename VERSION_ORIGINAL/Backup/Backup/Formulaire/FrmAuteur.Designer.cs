namespace Backup.Formulaire
{
    partial class FrmAuteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuteur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iTalk_Button_11 = new System.Windows.Forms.Button();
            this.nationalite = new iTalk.iTalk_TextBox_Small();
            this.prenom = new iTalk.iTalk_TextBox_Small();
            this.postnom = new iTalk.iTalk_TextBox_Small();
            this.nom = new iTalk.iTalk_TextBox_Small();
            this.sexe = new System.Windows.Forms.ComboBox();
            this.datenaiss = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.recher = new iTalk.iTalk_TextBox_Small();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notification1 = new iTalk.iTalk_ChatBubble_L();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iTalk_Button_11);
            this.panel1.Controls.Add(this.nationalite);
            this.panel1.Controls.Add(this.prenom);
            this.panel1.Controls.Add(this.postnom);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Controls.Add(this.sexe);
            this.panel1.Controls.Add(this.datenaiss);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Table);
            this.panel1.Controls.Add(this.recher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.notification1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 719);
            this.panel1.TabIndex = 624;
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iTalk_Button_11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iTalk_Button_11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.iTalk_Button_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(150, 400);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(101, 23);
            this.iTalk_Button_11.TabIndex = 749;
            this.iTalk_Button_11.Text = "Enregistrer";
            this.iTalk_Button_11.UseVisualStyleBackColor = true;
            this.iTalk_Button_11.Click += new System.EventHandler(this.button1_Click);
            // 
            // nationalite
            // 
            this.nationalite.BackColor = System.Drawing.Color.Transparent;
            this.nationalite.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalite.ForeColor = System.Drawing.Color.DimGray;
            this.nationalite.Location = new System.Drawing.Point(12, 352);
            this.nationalite.MaxLength = 32767;
            this.nationalite.Multiline = false;
            this.nationalite.Name = "nationalite";
            this.nationalite.ReadOnly = false;
            this.nationalite.Size = new System.Drawing.Size(246, 26);
            this.nationalite.TabIndex = 748;
            this.nationalite.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.nationalite.UseSystemPasswordChar = false;
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.Color.Transparent;
            this.prenom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.ForeColor = System.Drawing.Color.DimGray;
            this.prenom.Location = new System.Drawing.Point(11, 265);
            this.prenom.MaxLength = 32767;
            this.prenom.Multiline = false;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = false;
            this.prenom.Size = new System.Drawing.Size(246, 26);
            this.prenom.TabIndex = 747;
            this.prenom.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.prenom.UseSystemPasswordChar = false;
            // 
            // postnom
            // 
            this.postnom.BackColor = System.Drawing.Color.Transparent;
            this.postnom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postnom.ForeColor = System.Drawing.Color.DimGray;
            this.postnom.Location = new System.Drawing.Point(12, 220);
            this.postnom.MaxLength = 32767;
            this.postnom.Multiline = false;
            this.postnom.Name = "postnom";
            this.postnom.ReadOnly = false;
            this.postnom.Size = new System.Drawing.Size(246, 26);
            this.postnom.TabIndex = 746;
            this.postnom.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.postnom.UseSystemPasswordChar = false;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.Transparent;
            this.nom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.ForeColor = System.Drawing.Color.DimGray;
            this.nom.Location = new System.Drawing.Point(11, 175);
            this.nom.MaxLength = 32767;
            this.nom.Multiline = false;
            this.nom.Name = "nom";
            this.nom.ReadOnly = false;
            this.nom.Size = new System.Drawing.Size(246, 26);
            this.nom.TabIndex = 745;
            this.nom.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.nom.UseSystemPasswordChar = false;
            // 
            // sexe
            // 
            this.sexe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sexe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sexe.BackColor = System.Drawing.SystemColors.Control;
            this.sexe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexe.FormattingEnabled = true;
            this.sexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.sexe.Location = new System.Drawing.Point(12, 310);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(114, 23);
            this.sexe.TabIndex = 666;
            // 
            // datenaiss
            // 
            this.datenaiss.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenaiss.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datenaiss.Location = new System.Drawing.Point(11, 400);
            this.datenaiss.Name = "datenaiss";
            this.datenaiss.Size = new System.Drawing.Size(125, 23);
            this.datenaiss.TabIndex = 665;
            this.datenaiss.ValueChanged += new System.EventHandler(this.datenaiss_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(8, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 663;
            this.label8.Text = "Nom ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(9, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 661;
            this.label2.Text = "Postnom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(9, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 655;
            this.label4.Text = "Sexe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(9, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 656;
            this.label5.Text = "Nationalite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(8, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 660;
            this.label3.Text = "Date de naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(9, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 654;
            this.label6.Text = "Prenom";
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table.GridColor = System.Drawing.Color.White;
            this.Table.Location = new System.Drawing.Point(263, 105);
            this.Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Table.RowHeadersVisible = false;
            this.Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Table.RowTemplate.Height = 20;
            this.Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(684, 612);
            this.Table.TabIndex = 653;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // recher
            // 
            this.recher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recher.BackColor = System.Drawing.Color.White;
            this.recher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recher.ForeColor = System.Drawing.Color.DimGray;
            this.recher.Location = new System.Drawing.Point(758, 78);
            this.recher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recher.MaxLength = 32767;
            this.recher.Multiline = false;
            this.recher.Name = "recher";
            this.recher.ReadOnly = false;
            this.recher.Size = new System.Drawing.Size(189, 23);
            this.recher.TabIndex = 644;
            this.recher.Text = "Rechercher dans :  Tableau";
            this.recher.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.recher.UseSystemPasswordChar = false;
            this.recher.TextChanged += new System.EventHandler(this.recher_TextChanged);
            this.recher.Enter += new System.EventHandler(this.recher_Enter);
            this.recher.Leave += new System.EventHandler(this.recher_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(49, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 638;
            this.label1.Text = "Enregistrement Auteur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 637;
            this.pictureBox1.TabStop = false;
            // 
            // notification1
            // 
            this.notification1.BackColor = System.Drawing.Color.Transparent;
            this.notification1.BubbleColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.notification1.DrawBubbleArrow = true;
            this.notification1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification1.Location = new System.Drawing.Point(53, 479);
            this.notification1.Name = "notification1";
            this.notification1.Size = new System.Drawing.Size(152, 42);
            this.notification1.TabIndex = 632;
            this.notification1.Text = "Vous avez enregistré avec succès !";
            // 
            // FrmAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 743);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAuteur";
            this.Text = "FrmAuteur";
            this.Load += new System.EventHandler(this.FrmAuteur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Table;
        private iTalk.iTalk_TextBox_Small recher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_ChatBubble_L notification1;
        private System.Windows.Forms.DateTimePicker datenaiss;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sexe;
        private iTalk.iTalk_TextBox_Small nationalite;
        private iTalk.iTalk_TextBox_Small prenom;
        private iTalk.iTalk_TextBox_Small postnom;
        private iTalk.iTalk_TextBox_Small nom;
        private System.Windows.Forms.Button iTalk_Button_11;
    }
}