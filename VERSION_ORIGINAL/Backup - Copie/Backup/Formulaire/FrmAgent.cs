using Backup.Controlers;
using Backup.Models;
using Backup.Models.Traitements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Formulaire
{
    public partial class FrmAgent : Form
    {
        public FrmAgent()
        {
            InitializeComponent();
        }
        ClsAgents ag = new ClsAgents();
        ClsTAgent TAg = new ClsTAgent();
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        private void FrmAgent_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from Agent order by nomcomplet", TableAgent);
            fx.Picture_Rond(profil);
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            
        }
        public void initialiser()
        {
            txtnom.Text = "";
            txtmail.Text = "";
            txtsexe.Text = "";
            txtphone.Text = "";
        
    }
        private void TableAgent_Click(object sender, EventArgs e)
        {
            
        }

        private void profil_Click(object sender, EventArgs e)
        {

        }

        private void v(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void TableAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iTalk_Button_11.Text = "Modifier";
            try
            {
                ag.Code = (TableAgent.SelectedRows[0].Cells[0].Value.ToString());
                txtnom.Text = TableAgent.SelectedRows[0].Cells[1].Value.ToString();
                txtsexe.Text = TableAgent.SelectedRows[0].Cells[2].Value.ToString();
                txtphone.Text = TableAgent.SelectedRows[0].Cells[4].Value.ToString();
                txtmail.Text = TableAgent.SelectedRows[0].Cells[3].Value.ToString();
                ag.Photo = (byte[])TableAgent.SelectedRows[0].Cells[5].Value;
                MemoryStream ms = new MemoryStream(ag.Photo);
                profil.Image = Image.FromStream(ms);

            }
            catch (Exception ex) { MessageBox.Show("Faite une reherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fx.Photos(profil);
        }

        private void recher_Enter(object sender, EventArgs e)
        {
            if (recher.Text == "Rechercher dans :  Tableau")
            {
                recher.Text = "";
            }
        }

        private void recher_Leave(object sender, EventArgs e)
        {
            if (recher.Text == "")
            {
                recher.Text = "Rechercher dans :  Tableau";
            }
        }

        private void recher_TextChanged(object sender, EventArgs e)
        {
           dao.chargementGridOptimise("Select * from Agent where nomcomplet like '%" + recher.Text + "%'", TableAgent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnom.Text.Equals("") || txtsexe.Text.Equals("") || txtphone.Text.Equals("") || txtmail.Text.Equals("") || profil.Image.Equals(null))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (iTalk_Button_11.Text)
                    {
                        case "Enregistrer":

                                ag.NomComplet = txtnom.Text;
                                ag.Sexe = txtsexe.Text;
                                ag.Mail = txtmail.Text;
                                ag.Tele1 = txtphone.Text;
                                ag.Photo = fx.GetBytePhoto(profil.Image);
                                TAg.InsertionUpdateDeleteAgent(ag, 1);
                                initialiser();
                                fx.Messages(1);
                                dao.chargementGridOptimise("Select * from Agent order by nomcomplet", TableAgent);
                            break;
                        case "Modifier":                            
                                ag.NomComplet = txtnom.Text;
                                ag.Sexe = txtsexe.Text;
                                ag.Tele1 = txtphone.Text;
                                ag.Mail = txtmail.Text;
                                ag.Photo = fx.GetBytePhoto(profil.Image);
                                dao.InsertionUpdateDeleteAgent_avec_photo(ag, 2);
                                fx.Messages(4);
                                dao.chargementGridOptimise("Select * from Agent order by nomcomplet", TableAgent);                      
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
