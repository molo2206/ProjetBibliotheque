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
    public partial class FrmFournisseur : Form
    {
        public FrmFournisseur()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        ClsFournisseur f = new ClsFournisseur();
        Clsfonctions fx = new Clsfonctions();
        ClsTFournisseur fss = new ClsTFournisseur();
        string code_four;
        private void FrmFournisseur_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from Fournisseur", TableFournisseur);
            dao.chargementGridOptimise("Select * from Fournisseur", TableFournisseur);
            iTalk_Button_11.Text = "Enregistrer";

            notification1.Visible = false;
        }
        public void initialiser()
        {
            txtnom.Text = "";
            txtsexe.Text = "";
            txtphone.Text = "";
            txtmail.Text = "";
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
        }
        string code_f;
        private void TableFournisseur_Click(object sender, EventArgs e)
        {
            try
            {
                code_f = (TableFournisseur.SelectedRows[0].Cells[0].Value.ToString());
                txtnom.Text = TableFournisseur.SelectedRows[0].Cells[1].Value.ToString();
                txtsexe.Text = TableFournisseur.SelectedRows[0].Cells[2].Value.ToString();
                txtmail.Text = TableFournisseur.SelectedRows[0].Cells[3].Value.ToString();
                txtphone.Text = TableFournisseur.SelectedRows[0].Cells[4].Value.ToString();
                iTalk_Button_11.Text = "Modifier";
            }

            catch (Exception ex) { MessageBox.Show("Faite une reherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void recher_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from Fournisseur where nom_complet like '%" + recher.Text + "%'", TableFournisseur);
        }

        private void recher_Leave(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnom.Text.Equals("") || txtsexe.Text.Equals("") || txtphone.Text.Equals("") || txtmail.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {
                    switch (iTalk_Button_11.Text)
                    {
                        case "Enregistrer":
                           
                                f.Code = code_four;
                                f.NomComplet = (txtnom.Text).ToUpper();
                                f.Sexe = (txtsexe.Text).ToUpper();
                                f.Tele = (txtphone.Text).ToUpper();
                                f.Mail = (txtmail.Text).ToUpper();
                                fss.InsertionUpdateDeleteFournisseur(f, 1);
                                initialiser();
                                dao.chargementGridOptimise("Select * from Fournisseur", TableFournisseur);
                                iTalk_Button_11.Text = "Enregistrer";
                                initialiser();
                                iTalk_Button_11.Text = "Enregistrer"; dao.chargementGridOptimise("Select * from Fournisseur", TableFournisseur); 

                            break;
                        case "Modifier":
                          
                                f.Code = code_f;
                                f.NomComplet = (txtnom.Text).ToUpper();
                                f.Sexe = (txtsexe.Text).ToUpper();
                                f.Tele = (txtphone.Text).ToUpper();
                                f.Mail = (txtmail.Text).ToUpper();
                                fss.InsertionUpdateDeleteFournisseur(f, 2);
                                initialiser();
                                dao.chargementGridOptimise("Select * from Fournisseur", TableFournisseur);
                                initialiser(); dao.chargementGridOptimise("Select * from Fournisseur", TableFournisseur); 
                            break;

                    }


                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        
    }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }
    }
}
