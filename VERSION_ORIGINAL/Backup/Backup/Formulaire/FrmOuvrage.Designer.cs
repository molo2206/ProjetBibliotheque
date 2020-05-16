namespace Backup.Formulaire
{
    partial class FrmOuvrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOuvrage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRayon = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQte = new iTalk.iTalk_TextBox_Small();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEtalage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iTalk_Button_12 = new System.Windows.Forms.Button();
            this.auteur = new System.Windows.Forms.TextBox();
            this.txtouvrage = new iTalk.iTalk_TextBox_Small();
            this.txtville = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdomaine = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TableOuvrage = new System.Windows.Forms.DataGridView();
            this.recher = new iTalk.iTalk_TextBox_Small();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOuvrage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.iTalk_Button_12);
            this.panel1.Controls.Add(this.auteur);
            this.panel1.Controls.Add(this.txtouvrage);
            this.panel1.Controls.Add(this.txtville);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtdomaine);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TableOuvrage);
            this.panel1.Controls.Add(this.recher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 719);
            this.panel1.TabIndex = 624;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRayon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEtalage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(11, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 107);
            this.groupBox1.TabIndex = 752;
            this.groupBox1.TabStop = false;
            // 
            // txtRayon
            // 
            this.txtRayon.BackColor = System.Drawing.SystemColors.Control;
            this.txtRayon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtRayon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRayon.FormattingEnabled = true;
            this.txtRayon.Location = new System.Drawing.Point(143, 31);
            this.txtRayon.Margin = new System.Windows.Forms.Padding(2);
            this.txtRayon.Name = "txtRayon";
            this.txtRayon.Size = new System.Drawing.Size(69, 24);
            this.txtRayon.TabIndex = 673;
            this.txtRayon.SelectedIndexChanged += new System.EventHandler(this.txtRayon_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(4, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 659;
            this.label9.Text = "Date d\'édition";
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(7, 31);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(119, 21);
            this.txtdate.TabIndex = 667;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(140, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 672;
            this.label6.Text = "Rayon";
            // 
            // txtQte
            // 
            this.txtQte.BackColor = System.Drawing.Color.Transparent;
            this.txtQte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.ForeColor = System.Drawing.Color.DimGray;
            this.txtQte.Location = new System.Drawing.Point(143, 75);
            this.txtQte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQte.MaxLength = 32767;
            this.txtQte.Multiline = false;
            this.txtQte.Name = "txtQte";
            this.txtQte.ReadOnly = false;
            this.txtQte.Size = new System.Drawing.Size(69, 26);
            this.txtQte.TabIndex = 671;
            this.txtQte.Text = "0";
            this.txtQte.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.UseSystemPasswordChar = false;
            this.txtQte.TextChanged += new System.EventHandler(this.txtQte_TextChanged);
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 668;
            this.label4.Text = "Etalage";
            // 
            // txtEtalage
            // 
            this.txtEtalage.BackColor = System.Drawing.SystemColors.Control;
            this.txtEtalage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEtalage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtalage.FormattingEnabled = true;
            this.txtEtalage.Location = new System.Drawing.Point(7, 75);
            this.txtEtalage.Margin = new System.Windows.Forms.Padding(2);
            this.txtEtalage.Name = "txtEtalage";
            this.txtEtalage.Size = new System.Drawing.Size(119, 24);
            this.txtEtalage.TabIndex = 669;
            this.txtEtalage.SelectedIndexChanged += new System.EventHandler(this.txtEtalage_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(146, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 670;
            this.label5.Text = "Quantite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(188, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 751;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 750;
            this.label7.Text = "label7";
            // 
            // iTalk_Button_12
            // 
            this.iTalk_Button_12.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iTalk_Button_12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iTalk_Button_12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.iTalk_Button_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iTalk_Button_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.iTalk_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_12.Location = new System.Drawing.Point(73, 475);
            this.iTalk_Button_12.Name = "iTalk_Button_12";
            this.iTalk_Button_12.Size = new System.Drawing.Size(101, 23);
            this.iTalk_Button_12.TabIndex = 749;
            this.iTalk_Button_12.Text = "Enregistrer";
            this.iTalk_Button_12.UseVisualStyleBackColor = true;
            this.iTalk_Button_12.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // auteur
            // 
            this.auteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.auteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteur.Location = new System.Drawing.Point(11, 234);
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(246, 21);
            this.auteur.TabIndex = 747;
            this.auteur.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtouvrage
            // 
            this.txtouvrage.BackColor = System.Drawing.Color.Transparent;
            this.txtouvrage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtouvrage.ForeColor = System.Drawing.Color.DimGray;
            this.txtouvrage.Location = new System.Drawing.Point(11, 187);
            this.txtouvrage.MaxLength = 32767;
            this.txtouvrage.Multiline = false;
            this.txtouvrage.Name = "txtouvrage";
            this.txtouvrage.ReadOnly = false;
            this.txtouvrage.Size = new System.Drawing.Size(246, 25);
            this.txtouvrage.TabIndex = 746;
            this.txtouvrage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtouvrage.UseSystemPasswordChar = false;
            // 
            // txtville
            // 
            this.txtville.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtville.Location = new System.Drawing.Point(11, 318);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(246, 21);
            this.txtville.TabIndex = 675;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(8, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 663;
            this.label2.Text = "Nom du domaine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(8, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 662;
            this.label3.Text = "Titre de l\'ouvrage";
            // 
            // txtdomaine
            // 
            this.txtdomaine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtdomaine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtdomaine.BackColor = System.Drawing.Color.White;
            this.txtdomaine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtdomaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtdomaine.FormattingEnabled = true;
            this.txtdomaine.Location = new System.Drawing.Point(11, 277);
            this.txtdomaine.Name = "txtdomaine";
            this.txtdomaine.Size = new System.Drawing.Size(246, 23);
            this.txtdomaine.TabIndex = 660;
            this.txtdomaine.SelectedIndexChanged += new System.EventHandler(this.txtdomaine_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(8, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 654;
            this.label10.Text = "Nom de l\'auteur";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(8, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 656;
            this.label11.Text = "Ville d\'édition";
            // 
            // TableOuvrage
            // 
            this.TableOuvrage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableOuvrage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableOuvrage.BackgroundColor = System.Drawing.Color.White;
            this.TableOuvrage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableOuvrage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.TableOuvrage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableOuvrage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableOuvrage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableOuvrage.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableOuvrage.GridColor = System.Drawing.Color.White;
            this.TableOuvrage.Location = new System.Drawing.Point(263, 96);
            this.TableOuvrage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableOuvrage.Name = "TableOuvrage";
            this.TableOuvrage.ReadOnly = true;
            this.TableOuvrage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableOuvrage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableOuvrage.RowHeadersVisible = false;
            this.TableOuvrage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TableOuvrage.RowTemplate.Height = 20;
            this.TableOuvrage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TableOuvrage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableOuvrage.Size = new System.Drawing.Size(688, 615);
            this.TableOuvrage.TabIndex = 653;
            this.TableOuvrage.Click += new System.EventHandler(this.TableOuvrage_Click);
            // 
            // recher
            // 
            this.recher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recher.BackColor = System.Drawing.Color.White;
            this.recher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recher.ForeColor = System.Drawing.Color.DimGray;
            this.recher.Location = new System.Drawing.Point(762, 69);
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
            this.label1.Location = new System.Drawing.Point(39, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 638;
            this.label1.Text = "Enregistrement Ouvrage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 637;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOuvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 743);
            this.Controls.Add(this.panel1);
            this.Name = "FrmOuvrage";
            this.Text = "FrmOuvrage";
            this.Load += new System.EventHandler(this.FrmOuvrage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOuvrage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtRayon;
        private System.Windows.Forms.Label label6;
        private iTalk.iTalk_TextBox_Small txtQte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtEtalage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView TableOuvrage;
        private iTalk.iTalk_TextBox_Small recher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtville;
        private iTalk.iTalk_TextBox_Small txtouvrage;
        private System.Windows.Forms.TextBox auteur;
        private System.Windows.Forms.ComboBox txtdomaine;
        private System.Windows.Forms.Button iTalk_Button_12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}