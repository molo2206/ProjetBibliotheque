using Backup.Controlers;
using Backup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Formulaire
{
    public partial class FrmAutres : Form
    {
        public FrmAutres()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        ClsLogin lg = new ClsLogin();
        Clsfonctions fx = new Clsfonctions();
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void FrmAutres_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select Code, NomUtilisateur, Mot_de_passe from Liste_Agents", Table);
            //dao.chargementGridOptimise("select phone1 as Téléphone,Date_ as Date from Rapport_Emprunt where ETAT = 1", number);
            num.Text = dao.chargerNombre("Rapport_Emprunt where ETAT = 1", "count(phone1)");
            dao.chargerlist("select phone1 as Téléphone from Rapport_Emprunt where ETAT = 1", "Téléphone", txtlist);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (recher.Text == "")
            {
                recher.Text = "Rechercher dans :  Tableau";
            }
        }
        private void recher_Enter(object sender, EventArgs e)
        {
            if (recher.Text == "Rechercher dans :  Tableau")
            {
                recher.Text = "";
            }
        }

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
        }
        public void initialiser()
        {
        //    txtnom.Text = "";
        //    txtfonction.Text = "";
        //    txtpwd.Text = "";
        //    txtniveau.Text = "";
        //    agent.Text = ""; iTalk_Button_23.Text = "Enregistrer";
        }

        private void agent_TextChanged(object sender, EventArgs e)
        {
            //lg.CodeAgent = dao.IdCombo("Agent", "code", agent.Text, "NomComplet");
        }

        private void Table_Click(object sender, EventArgs e)
        {
        }

        private void recher_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select Code, NomUtilisateur, Mot_de_passe from Liste_Agents where nomutilisateur like '%" + recher.Text+"'", Table);
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_TextBox_Small1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_ChatBubble_L1_Click(object sender, EventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfonction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtentreprise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Table_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                //    Qtes = datarticle.SelectedRows[0].Cells[3].Value.ToString();
                //    code = datarticle.SelectedRows[0].Cells[2].Value.ToString();
                //    Barcode = datarticle.SelectedRows[0].Cells[4].Value.ToString();
                //    code_facture = datarticle.SelectedRows[0].Cells[1].Value.ToString();
                }
                else
                {
                    ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();
                    int position_row = Table.HitTest(e.X, e.Y).RowIndex;
                    if (position_row >= 0)
                    {
                        my_menu.Items.Add("Modifier votre compte").Name = "Modifier votre compte";
                       
                    }
                    my_menu.Show(Table, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menuItemclicked);
                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menuItemclickeds);
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }

        }

        FrmLoginUtilisateur fr = new FrmLoginUtilisateur();
        public void my_menuItemclicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                fr.id.Text = Table.SelectedRows[0].Cells[0].Value.ToString();
                fr.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Erreur"); }

        }
        public void my_menuItemclickeds(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
        }
        string numero;
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort sp = new SerialPort();
                sp.PortName = txtPort.Text;
                sp.Open();
                sp.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                Thread.Sleep(100);
                for (int x = 0; x < txtlist.Items.Count -1; x++)
                { 
                  sp.WriteLine("AT+CMGS=\"" + (txtlist.Items[x].ToString()) + "\"" + Environment.NewLine);
                  Thread.Sleep(100);
                }
                sp.WriteLine(txtMessage.Text + Environment.NewLine);
                Thread.Sleep(100);
                sp.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);
                var response = sp.ReadExisting();
                if (response.Contains("ERROR"))
                    MessageBox.Show("Votre SMS n'est pas envoyé !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Votre SMS est envoyé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sp.Close();

                sp.Close();
            }
            catch (Exception EX) { MessageBox.Show(EX.Message); }
        }


        private void txtMessage_Leave(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
            {
                txtMessage.Text = "Saisissez votre message";
            }
        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            if (txtMessage.Text== "Saisissez votre message")
            {
                txtMessage.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

