namespace Backup.Formulaire
{
    partial class FrmApprovision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApprovision));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rech = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtouvrage = new System.Windows.Forms.TextBox();
            this.iTalk_Separator2 = new iTalk.iTalk_Separator();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_2();
            this.txtfournisseur = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iTalk_Button_23 = new iTalk.iTalk_Button_2();
            this.iTalk_Button_22 = new iTalk.iTalk_Button_2();
            this.txtQuantite = new iTalk.iTalk_TextBox_Small();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQte = new iTalk.iTalk_TextBox_Small();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdd = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmotif = new System.Windows.Forms.TextBox();
            this.iTalk_Button_12 = new iTalk.iTalk_Button_2();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rech);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Table);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 719);
            this.panel1.TabIndex = 624;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rech
            // 
            this.rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rech.Location = new System.Drawing.Point(3, 72);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(205, 21);
            this.rech.TabIndex = 655;
            this.rech.Text = "Rechercher dans :  Tableau";
            this.rech.TextChanged += new System.EventHandler(this.rech_TextChanged);
            this.rech.Enter += new System.EventHandler(this.rech_Enter);
            this.rech.Leave += new System.EventHandler(this.rech_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtouvrage);
            this.panel2.Controls.Add(this.iTalk_Separator2);
            this.panel2.Controls.Add(this.iTalk_Button_11);
            this.panel2.Controls.Add(this.txtfournisseur);
            this.panel2.Controls.Add(this.id);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtQte);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tableAdd);
            this.panel2.Controls.Add(this.txtmotif);
            this.panel2.Controls.Add(this.iTalk_Button_12);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(423, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 568);
            this.panel2.TabIndex = 654;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtouvrage
            // 
            this.txtouvrage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtouvrage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtouvrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtouvrage.Location = new System.Drawing.Point(237, 106);
            this.txtouvrage.Name = "txtouvrage";
            this.txtouvrage.Size = new System.Drawing.Size(182, 20);
            this.txtouvrage.TabIndex = 682;
            this.txtouvrage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iTalk_Separator2
            // 
            this.iTalk_Separator2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iTalk_Separator2.BackColor = System.Drawing.Color.White;
            this.iTalk_Separator2.Location = new System.Drawing.Point(176, 62);
            this.iTalk_Separator2.Name = "iTalk_Separator2";
            this.iTalk_Separator2.Size = new System.Drawing.Size(171, 10);
            this.iTalk_Separator2.TabIndex = 681;
            this.iTalk_Separator2.Text = "iTalk_Separator2";
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_11.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(179, 485);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(155, 26);
            this.iTalk_Button_11.TabIndex = 677;
            this.iTalk_Button_11.Text = "Enregistrer";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // txtfournisseur
            // 
            this.txtfournisseur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtfournisseur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtfournisseur.BackColor = System.Drawing.Color.White;
            this.txtfournisseur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtfournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtfournisseur.FormattingEnabled = true;
            this.txtfournisseur.Location = new System.Drawing.Point(4, 106);
            this.txtfournisseur.Margin = new System.Windows.Forms.Padding(2);
            this.txtfournisseur.Name = "txtfournisseur";
            this.txtfournisseur.Size = new System.Drawing.Size(208, 23);
            this.txtfournisseur.TabIndex = 679;
            this.txtfournisseur.SelectedIndexChanged += new System.EventHandler(this.txtfournisseur_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.White;
            this.id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id.Location = new System.Drawing.Point(64, 201);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(49, 21);
            this.id.TabIndex = 678;
            this.id.Text = "EN00";
            this.id.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.iTalk_Button_23);
            this.panel3.Controls.Add(this.iTalk_Button_22);
            this.panel3.Controls.Add(this.txtQuantite);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(168, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 84);
            this.panel3.TabIndex = 677;
            // 
            // iTalk_Button_23
            // 
            this.iTalk_Button_23.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_23.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_23.Image = null;
            this.iTalk_Button_23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_23.Location = new System.Drawing.Point(78, 49);
            this.iTalk_Button_23.Name = "iTalk_Button_23";
            this.iTalk_Button_23.Size = new System.Drawing.Size(72, 26);
            this.iTalk_Button_23.TabIndex = 679;
            this.iTalk_Button_23.Text = "Supprimer";
            this.iTalk_Button_23.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_23.Click += new System.EventHandler(this.iTalk_Button_23_Click);
            // 
            // iTalk_Button_22
            // 
            this.iTalk_Button_22.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_22.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_22.Image = null;
            this.iTalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_22.Location = new System.Drawing.Point(3, 49);
            this.iTalk_Button_22.Name = "iTalk_Button_22";
            this.iTalk_Button_22.Size = new System.Drawing.Size(72, 26);
            this.iTalk_Button_22.TabIndex = 678;
            this.iTalk_Button_22.Text = "Modifier";
            this.iTalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_22.Click += new System.EventHandler(this.iTalk_Button_22_Click);
            // 
            // txtQuantite
            // 
            this.txtQuantite.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantite.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtQuantite.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantite.Location = new System.Drawing.Point(52, 16);
            this.txtQuantite.MaxLength = 32767;
            this.txtQuantite.Multiline = false;
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.ReadOnly = false;
            this.txtQuantite.Size = new System.Drawing.Size(54, 28);
            this.txtQuantite.TabIndex = 599;
            this.txtQuantite.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantite.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(49, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 591;
            this.label6.Text = "Quantite";
            // 
            // txtQte
            // 
            this.txtQte.BackColor = System.Drawing.Color.Transparent;
            this.txtQte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.ForeColor = System.Drawing.Color.DimGray;
            this.txtQte.Location = new System.Drawing.Point(237, 145);
            this.txtQte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQte.MaxLength = 32767;
            this.txtQte.Multiline = false;
            this.txtQte.Name = "txtQte";
            this.txtQte.ReadOnly = false;
            this.txtQte.Size = new System.Drawing.Size(69, 26);
            this.txtQte.TabIndex = 676;
            this.txtQte.Text = "0";
            this.txtQte.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(240, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 675;
            this.label4.Text = "Quantite";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 174);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 669;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(149, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 638;
            this.label1.Text = "Demande approvisionnement";
            // 
            // tableAdd
            // 
            this.tableAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableAdd.BackgroundColor = System.Drawing.Color.White;
            this.tableAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableAdd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Articl,
            this.qte});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableAdd.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableAdd.GridColor = System.Drawing.Color.White;
            this.tableAdd.Location = new System.Drawing.Point(3, 224);
            this.tableAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableAdd.Name = "tableAdd";
            this.tableAdd.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableAdd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableAdd.RowHeadersVisible = false;
            this.tableAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableAdd.Size = new System.Drawing.Size(516, 247);
            this.tableAdd.TabIndex = 668;
            this.tableAdd.Click += new System.EventHandler(this.tableAdd_Click);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Articl
            // 
            this.Articl.HeaderText = "Ouvrage";
            this.Articl.Name = "Articl";
            this.Articl.ReadOnly = true;
            // 
            // qte
            // 
            this.qte.HeaderText = "Quantite";
            this.qte.Name = "qte";
            this.qte.ReadOnly = true;
            // 
            // txtmotif
            // 
            this.txtmotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmotif.Location = new System.Drawing.Point(4, 150);
            this.txtmotif.Name = "txtmotif";
            this.txtmotif.Size = new System.Drawing.Size(208, 21);
            this.txtmotif.TabIndex = 665;
            this.txtmotif.Text = "Approvisionnement Ouvrage";
            this.txtmotif.TextChanged += new System.EventHandler(this.txtmotif_TextChanged);
            // 
            // iTalk_Button_12
            // 
            this.iTalk_Button_12.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_12.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_12.Image = null;
            this.iTalk_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_12.Location = new System.Drawing.Point(327, 145);
            this.iTalk_Button_12.Name = "iTalk_Button_12";
            this.iTalk_Button_12.Size = new System.Drawing.Size(72, 26);
            this.iTalk_Button_12.TabIndex = 662;
            this.iTalk_Button_12.Text = "Ajouter";
            this.iTalk_Button_12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_12.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(1, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 659;
            this.label5.Text = "Motif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(234, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 661;
            this.label3.Text = "Nom de l\'exemplaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 657;
            this.label2.Text = "Nom fournisseur";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle5;
            this.Table.GridColor = System.Drawing.Color.White;
            this.Table.Location = new System.Drawing.Point(3, 98);
            this.Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Table.RowHeadersVisible = false;
            this.Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Table.RowTemplate.Height = 20;
            this.Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(414, 568);
            this.Table.TabIndex = 653;
            // 
            // FrmApprovision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 743);
            this.Controls.Add(this.panel1);
            this.Name = "FrmApprovision";
            this.Text = "FrmApprovision";
            this.Load += new System.EventHandler(this.FrmApprovision_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtmotif;
        private iTalk.iTalk_Button_2 iTalk_Button_12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView tableAdd;
        private iTalk.iTalk_TextBox_Small txtQte;
        private System.Windows.Forms.Label label4;
        private iTalk.iTalk_Button_2 iTalk_Button_11;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Panel panel3;
        private iTalk.iTalk_Button_2 iTalk_Button_23;
        private iTalk.iTalk_Button_2 iTalk_Button_22;
        private iTalk.iTalk_TextBox_Small txtQuantite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtfournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articl;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte;
        private System.Windows.Forms.TextBox rech;
        private iTalk.iTalk_Separator iTalk_Separator2;
        private System.Windows.Forms.TextBox txtouvrage;
    }
}