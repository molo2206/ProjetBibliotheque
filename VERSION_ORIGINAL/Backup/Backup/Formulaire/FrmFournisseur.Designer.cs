namespace Backup.Formulaire
{
    partial class FrmFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFournisseur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iTalk_Button_11 = new System.Windows.Forms.Button();
            this.txtnom = new iTalk.iTalk_TextBox_Small();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.TableFournisseur = new System.Windows.Forms.DataGridView();
            this.txtmail = new iTalk.iTalk_TextBox_Small();
            this.recher = new iTalk.iTalk_TextBox_Small();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsexe = new System.Windows.Forms.ComboBox();
            this.notification1 = new iTalk.iTalk_ChatBubble_L();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableFournisseur)).BeginInit();
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
            this.panel1.Controls.Add(this.txtnom);
            this.panel1.Controls.Add(this.txtphone);
            this.panel1.Controls.Add(this.TableFournisseur);
            this.panel1.Controls.Add(this.txtmail);
            this.panel1.Controls.Add(this.recher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtsexe);
            this.panel1.Controls.Add(this.notification1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
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
            this.iTalk_Button_11.Location = new System.Drawing.Point(77, 377);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(101, 23);
            this.iTalk_Button_11.TabIndex = 749;
            this.iTalk_Button_11.Text = "Enregistrer";
            this.iTalk_Button_11.UseVisualStyleBackColor = true;
            this.iTalk_Button_11.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.Color.Transparent;
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.ForeColor = System.Drawing.Color.DimGray;
            this.txtnom.Location = new System.Drawing.Point(11, 198);
            this.txtnom.MaxLength = 32767;
            this.txtnom.Multiline = false;
            this.txtnom.Name = "txtnom";
            this.txtnom.ReadOnly = false;
            this.txtnom.Size = new System.Drawing.Size(246, 25);
            this.txtnom.TabIndex = 745;
            this.txtnom.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnom.UseSystemPasswordChar = false;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(11, 287);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(246, 25);
            this.txtphone.TabIndex = 654;
            this.txtphone.Text = "+243";
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // TableFournisseur
            // 
            this.TableFournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableFournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableFournisseur.BackgroundColor = System.Drawing.Color.White;
            this.TableFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableFournisseur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.TableFournisseur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableFournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableFournisseur.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableFournisseur.GridColor = System.Drawing.Color.White;
            this.TableFournisseur.Location = new System.Drawing.Point(263, 103);
            this.TableFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableFournisseur.Name = "TableFournisseur";
            this.TableFournisseur.ReadOnly = true;
            this.TableFournisseur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableFournisseur.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableFournisseur.RowHeadersVisible = false;
            this.TableFournisseur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TableFournisseur.RowTemplate.Height = 20;
            this.TableFournisseur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TableFournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableFournisseur.Size = new System.Drawing.Size(684, 614);
            this.TableFournisseur.TabIndex = 653;
            this.TableFournisseur.Click += new System.EventHandler(this.TableFournisseur_Click);
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.White;
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtmail.Location = new System.Drawing.Point(11, 331);
            this.txtmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmail.MaxLength = 32767;
            this.txtmail.Multiline = false;
            this.txtmail.Name = "txtmail";
            this.txtmail.ReadOnly = false;
            this.txtmail.Size = new System.Drawing.Size(246, 25);
            this.txtmail.TabIndex = 648;
            this.txtmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmail.UseSystemPasswordChar = false;
            // 
            // recher
            // 
            this.recher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recher.BackColor = System.Drawing.Color.White;
            this.recher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recher.ForeColor = System.Drawing.Color.DimGray;
            this.recher.Location = new System.Drawing.Point(743, 76);
            this.recher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recher.MaxLength = 32767;
            this.recher.Multiline = false;
            this.recher.Name = "recher";
            this.recher.ReadOnly = false;
            this.recher.Size = new System.Drawing.Size(204, 23);
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
            this.label1.Location = new System.Drawing.Point(36, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 638;
            this.label1.Text = "Enregistrement Emprunteur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 637;
            this.pictureBox1.TabStop = false;
            // 
            // txtsexe
            // 
            this.txtsexe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsexe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtsexe.BackColor = System.Drawing.SystemColors.Control;
            this.txtsexe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtsexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsexe.FormattingEnabled = true;
            this.txtsexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.txtsexe.Location = new System.Drawing.Point(11, 245);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.Size = new System.Drawing.Size(114, 24);
            this.txtsexe.TabIndex = 636;
            // 
            // notification1
            // 
            this.notification1.BackColor = System.Drawing.Color.Transparent;
            this.notification1.BubbleColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.notification1.DrawBubbleArrow = true;
            this.notification1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification1.Location = new System.Drawing.Point(54, 486);
            this.notification1.Name = "notification1";
            this.notification1.Size = new System.Drawing.Size(152, 42);
            this.notification1.TabIndex = 632;
            this.notification1.Text = "Vous avez enregistré avec succès !";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(8, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 624;
            this.label4.Text = "Sexe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 625;
            this.label5.Text = "Numero phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(8, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 623;
            this.label2.Text = "Nom complet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(8, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 628;
            this.label7.Text = "Adresse mail";
            // 
            // FrmFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 743);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFournisseur";
            this.Text = "FrmFournisseur";
            this.Load += new System.EventHandler(this.FrmFournisseur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.DataGridView TableFournisseur;
        private iTalk.iTalk_TextBox_Small txtmail;
        private iTalk.iTalk_TextBox_Small recher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtsexe;
        private iTalk.iTalk_ChatBubble_L notification1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private iTalk.iTalk_TextBox_Small txtnom;
        private System.Windows.Forms.Button iTalk_Button_11;
    }
}