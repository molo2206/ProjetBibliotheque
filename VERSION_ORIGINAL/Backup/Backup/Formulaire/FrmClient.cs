using Backup.Controlers;
using Backup.Models;
using Backup.Models.Traitements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Formulaire
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        ClsEmprunteurs emp = new ClsEmprunteurs();
        ClsTEmprunteurs empr = new ClsTEmprunteurs();
        Clsfonctions fx = new Clsfonctions();
        private void FrmClient_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from EMPRUNTEUR", TableEmprunteur);
        }      
        private void TableEmprunteur_Click(object sender, EventArgs e)
        {

            try
            {
                emp.Code = (TableEmprunteur.SelectedRows[0].Cells[0].Value.ToString());
                txtnom.Text = TableEmprunteur.SelectedRows[0].Cells[1].Value.ToString();
                txtsexe.Text = TableEmprunteur.SelectedRows[0].Cells[2].Value.ToString();
                txtphone1.Text = TableEmprunteur.SelectedRows[0].Cells[5].Value.ToString();
                txtphone2.Text = TableEmprunteur.SelectedRows[0].Cells[4].Value.ToString();
                txtmail.Text = TableEmprunteur.SelectedRows[0].Cells[3].Value.ToString();
                iTalk_Button_11.Text = "Modifier";
            }
            catch (Exception ex) { MessageBox.Show("Faite une recherhe d'abord","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }
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

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {

        }
        public void initialiser()
        {
            txtnom.Text = "";
            txtsexe.Text = "";
            txtphone1.Text = "";
            txtphone2.Text = "";
            txtmail.Text = "";
        }
    private void txtphone1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Character(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //fx.verifier_Numerique(e);
        }

        private void txtphone2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //fx.verifier_Numerique(e);
        }
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
        //    verifier_Character(e);
        }

        private void recher_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from EMPRUNTEUR where nom_complet like '%" + recher.Text + "%'", TableEmprunteur);

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void recher_Click(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from EMPRUNTEUR where nom_complet like '%" + recher.Text + "%'", TableEmprunteur);

        }

        private void TableEmprunteur_Leave(object sender, EventArgs e)
        {
            if (recher.Text == "")
            {
                recher.Text = "Rechercher dans :  Tableau";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtnom.Text.Equals("") || txtsexe.Text.Equals("") || txtphone1.Text.Equals("") || txtphone2.Text.Equals("") || txtmail.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {
                    switch (iTalk_Button_11.Text)
                    {
                        case "Enregistrer":

                            emp.NomComplet = (txtnom.Text).ToUpper();
                            emp.Sexe = (txtsexe.Text).ToUpper();
                            emp.Tele1 = (txtphone1.Text).ToUpper();
                            emp.Tele2 = (txtphone2.Text).ToUpper();
                            emp.Mail = (txtmail.Text).ToUpper();
                            empr.InsertionUpdateDeleteEmpunteurs(emp, 1);

                            initialiser();
                            dao.chargementGridOptimise("Select * from Emprunteur", TableEmprunteur);
                            initialiser(); dao.chargementGridOptimise("Select * from Emprunteur", TableEmprunteur);
                            break;
                        case "Modifier":
                            emp.NomComplet = (txtnom.Text).ToUpper();
                            emp.Sexe = (txtsexe.Text).ToUpper();
                            emp.Tele1 = (txtphone1.Text).ToUpper();
                            emp.Tele2 = (txtphone2.Text).ToUpper();
                            emp.Mail = (txtmail.Text).ToUpper();
                            empr.InsertionUpdateDeleteEmpunteurs(emp, 2);

                            initialiser();
                            dao.chargementGridOptimise("Select * from Emprunteur", TableEmprunteur);                            
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void txtphone2_Leave(object sender, EventArgs e)
        {

        }

        private void txtphone2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtphone1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtphone1_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            fx.verifier_Numerique(e);
        }

        private void txtphone2_KeyPress_2(object sender, KeyPressEventArgs e)
        {

            //fx.verifier_Numerique(e);
        }
    }
}
