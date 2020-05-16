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
    public partial class FrmRetour : Form
    {
        public FrmRetour()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        ClsDAO dao = new ClsDAO();
        ClsRetour emp = new ClsRetour();
        ClsTRetour empr = new ClsTRetour();
        string codeExemplaire = "";
        private void FrmRetour_Load(object sender, EventArgs e)
        {
            dao.Autocomplete("select Empunteur as noms from Rapport_Emprunt where ETAT=1", "noms", txtemprunteur);
            dao.chargementGridOptimise("select Ouvrage, barcode,Empunteur as Emprunteur from[Rapport_Emprunt] where ETAT = 1", Table);
            emp.CodeEntete = dao.IdEnteteRetour();
            identete.Text = emp.CodeEntete;
            panel3.Visible = false;
        }
        private void iTalk_Button_14_Click(object sender, EventArgs e)
        {
           
        }
        string id = "";
        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {
                    fx.Supprimer(tableAdd);
                    panel3.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            try
            {
                if (Quantite.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {
                    int QteRetout = dao.QteRetour(txtemprunteur.Text, txtexmplaire.Text);
                    if (QteRetout == int.Parse(Quantite.Text) && int.Parse(Quantite.Text) > 0)
                    {
                        tableAdd.SelectedRows[0].Cells[2].Value = qte;
                        panel3.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Vous devez retourne la totalité de cet exemplaire qui est: " + QteRetout + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string code_Retour="";
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableAdd.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (iTalk_Button_11.Text)
                    {
                        case "Enregistré":                           
                                emp.Code = code_Retour;
                                emp.CodeEntete = dao.IdEnteteRetour();
                                emp.CodeEmprunteur = eta.Text;
                                emp.Motif = txtmotif.Text;
                                empr.InsertionUpdateRetour(emp, tableAdd, 1);
                                fx.Messages(1);
                                tableAdd.Rows.Clear();
                                initialiser();
                                dao.chargementGridOptimise("select Ouvrage, barcode,Empunteur from[Rapport_Emprunt] where ETAT = 1", Table);
                            emp.CodeEntete = dao.IdEnteteRetour();
                            identete.Text = emp.CodeEntete;
                            break;
                        case "Modifier":

                            if (fx.Question(2) == true)
                            {
                                emp.CodeEntete = dao.IdEnteteRetour();
                                emp.CodeEmprunteur = codeEmprunteur;
                                emp.Motif = txtmotif.Text;
                                empr.InsertionUpdateRetour(emp, tableAdd, 1);
                                fx.Messages(1);
                                tableAdd.Rows.Clear();
                                initialiser();
                            }
                            else
                            {
                                initialiser();
                            }
                            break;
                    }
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void initialiser()
        {
            txtemprunteur.Text = "";
            txtQte.Text = "0";
            txtexmplaire.Text = "";
        }
        private void barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (barcode.Text.Length == 8)
                {
                    txtexmplaire.Text = dao.Barcode(barcode.Text);
                    CodeodeExemplaire = dao.Code_Barcode(barcode.Text);
                }
                else
                {
                    txtexmplaire.Text = "";
                    CodeodeExemplaire = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        string CodeodeExemplaire;
        private void Table_Click(object sender, EventArgs e)
        {
           
        }
        string codeEmprunteur;
        private void txtemprunteur_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void rech_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("SELECT Ouvrage, Barcode FROM ListeAppro where Code_Exemplaire in(select Code_Exemplaire from Rapport_Emprunt where ETAT=1 and ouvrage like '%" + rech.Text + "%'", Table);
        }
        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text == "")
            {
                rech.Text = "Rechercher dans :  Tableau";
            }
        }

        private void rech_Enter(object sender, EventArgs e)
        {
            if (rech.Text == "Rechercher dans :  Tableau")
            {
                rech.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtexmplaire_TextChanged(object sender, EventArgs e)
        {
            codeExemplaire = dao.IdCombo("[Rapport_Emprunt]", "Code_Exemplaire", txtemprunteur.Text, "DESIGNATION");
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                barcode.Text = Table.SelectedRows[0].Cells[1].Value.ToString();
                txtemprunteur.Text = Table.SelectedRows[0].Cells[2].Value.ToString();
                
            }
            catch (Exception ex) { MessageBox.Show("Faite une reherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtexmplaire.Text.Equals("") || txtQte.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {
                    int QteRetout = dao.QteRetour(txtemprunteur.Text, txtexmplaire.Text);
                    if (QteRetout == int.Parse(txtQte.Text))
                    {
                        if (fx.occurrence(tableAdd, CodeodeExemplaire) == 0)
                        {
                            fx.ajouter(tableAdd, CodeodeExemplaire, txtexmplaire.Text, int.Parse(txtQte.Text));
                            txtQte.Text = "";
                            txtexmplaire.Text = "";
                            barcode.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Cet produit existe déjà ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous devez retourner la totalité de cet exemplaire qui est: " + QteRetout + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iTalk_RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            eta.Text = dao.IdCombo("[Rapport_Emprunt]", "Code_Emp", txtemprunteur.Text, "Empunteur");
        }
    }
}
