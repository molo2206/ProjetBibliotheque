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
    public partial class FrmEmprunt : Form
    {
        public FrmEmprunt()
        {
            InitializeComponent();
        }

            ClsDAO dao = new ClsDAO();
            Clsfonctions fx = new Clsfonctions();
            ClsEmprunt emp = new ClsEmprunt();
            ClsTEmprunt empr = new ClsTEmprunt();
            int etat;
            int test;
            string CodeodeExemplaire;

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select Ouvrage, Barcode from ListeAppro WHERE ouvrage like '%"+rech.Text+"%'", Table);
        }

        private void iTalk_Button_14_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtexmplaire.Text.Equals("") || txtQte.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {
                    int qte;
                    qte = int.Parse(txtQte.Text);
                    if (qte <= 0)
                    {
                        MessageBox.Show("Quantite Invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (qte > 1)
                    {
                        MessageBox.Show("Quantite par défaut:2", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        etat = int.Parse(label3.Text);
                        if (etat.Equals(0))
                        {
                            int QteDispo = dao.RetournerInt("Select dbo.[QteExemplaireDispo]('" + txtexmplaire.Text + "') as val ", "val");
                            if (qte <= QteDispo)
                            {
                                if (fx.occurrence(tableAdd, CodeodeExemplaire) == 0)
                                {
                                    fx.ajouter(tableAdd, CodeodeExemplaire, txtexmplaire.Text, int.Parse(txtQte.Text));
                                    barcode.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("C'est produit existe déjà ", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("La quantite disponible est  :" + QteDispo + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vous avez encore un ouvrage","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            txtemprunteur.Text = "";
                            txtexmplaire.Text = "";
                            eta.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ok");
            }
        }
        private void txtemprunteur_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (barcode.TextLength == 8)
                {
                    txtexmplaire.Text = dao.Barcode(barcode.Text);                    
                }
                else
                {
                    txtexmplaire.Text = "";
                    CodeodeExemplaire = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seulement des chiffres svp!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int qtes;
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
                    qtes = int.Parse(Quantite.Text);

                    if (qtes <= 0)
                    {
                        MessageBox.Show("Quantite Invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (qtes > 2)
                        {
                            MessageBox.Show("Quantite par défaut:2", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tableAdd.SelectedRows[0].Cells[2].Value = qte;
                            panel3.Visible = false;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {

            try
            {
                if (tableAdd.Rows.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (iTalk_Button_11.Text)
                    {
                        case "Enregistré":
                                emp.CodeEmprunteur = eta.Text;
                                emp.Motif = txtmotif.Text;
                                empr.InsertionUpdateEmprunt(emp, tableAdd, 1);
                                fx.Messages(1);
                                tableAdd.Rows.Clear();
                                initialiser();
                            dao.chargementGridOptimise("select Ouvrage, Barcode from ListeAppro", Table);
                                identete.Text = dao.IdEnteteEmprunt();
                                emp.CodeEntete = identete.Text;
                            break;
                        case "Modifier":

                            if (fx.Question(2) == true)
                            {
                                emp.CodeEmprunteur = eta.Text;
                                emp.Motif = txtmotif.Text;
                                empr.InsertionUpdateEmprunt(emp, tableAdd, 1);
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
            CodeodeExemplaire = "";
            tableAdd.Rows.Clear();
        }
        private void txtexmplaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEmprunt_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select Ouvrage, Barcode from ListeAppro",Table);
            identete.Text = dao.IdEnteteEmprunt();
            emp.CodeEntete = identete.Text;
            dao.Autocomplete("select Nom_complet as noms from Emprunteur ", "noms", txtemprunteur);
            panel3.Visible = false;
        }

        private void Table_Click(object sender, EventArgs e)
        {
            try
            {
                barcode.Text = Table.SelectedRows[0].Cells[1].Value.ToString();
                CodeodeExemplaire= dao.Code_Barcode(barcode.Text);
            }

            catch (Exception ex) { MessageBox.Show("Faite une reherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
            try
            {
                if (Quantite.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {
                    qtes = int.Parse(Quantite.Text);

                    if (qtes <= 0)
                    {
                        MessageBox.Show("Quantite Invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (qtes > 2)
                        {
                            MessageBox.Show("Quantite par défaut:2", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            fx.Supprimer(tableAdd);
                            panel3.Visible = false;
                            Quantite.Text = "";
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        string id = "";
        private void tableAdd_Click(object sender, EventArgs e)
        {
            try
            {
                id = tableAdd.SelectedRows[0].Cells[0].Value.ToString();
                Quantite.Text = tableAdd.SelectedRows[0].Cells[2].Value.ToString();
                panel3.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show("Charger d'abord le panier ","",MessageBoxButtons.OK,MessageBoxIcon.Error); }

        }

        private void barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
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

        private void txtemprunteur_TextChanged(object sender, EventArgs e)
        {
            label3.Text = dao.Etat(txtemprunteur.Text);
            eta.Text = dao.IdCombo("Emprunteur", "CODE", txtemprunteur.Text, "Nom_Complet");
        }

        private void txtexmplaire_TextChanged_1(object sender, EventArgs e)
        {
            CodeodeExemplaire = dao.IdCombo("Exemplaire", "CODE", txtexmplaire.Text, "designation");
        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }

        private void txtemprunteur_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Character(e);
        }

        private void txtexmplaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Character(e);
        }

        private void txtmotif_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Character(e);
        }

        private void Quantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }

        private void Quantite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
