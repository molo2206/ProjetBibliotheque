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
    public partial class FrmOuvrage : Form
    {
        public FrmOuvrage()
        {
            InitializeComponent();
        }
        ClsOuvrages ou = new ClsOuvrages();
        ClsTOuvrage ouv = new ClsTOuvrage();
        ClsExemplaire ex = new ClsExemplaire();
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        string id = "";
        string code_exem;
        string code_ouvrage;
        private void FrmOuvrage_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select Code,Exemplaire,Ouvrage,Auteur, Domaine, Ville_Edition as VilleEdition, ANNEE_EDIT as AnnéeEdition, Rayon, Etalage, Quantite from Liste_Exemplaire", TableOuvrage);
            dao.Autocomplete("select nom from Auteur ", "nom", auteur);
            dao.chargerCombo("select designation as designa from Domaine ", "designa", txtdomaine);
            dao.chargerCombo("select Designation  from Etalage ", "Designation", txtEtalage);
            dao.chargerCombo("select designation as designa from Rayon ", "designa", txtRayon);
            
        }
        string code_auteur;
        private void auteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            code_auteur = dao.IdCombo("Liste_Exemplaire", "code_auteur", auteur.Text, "auteur");
        }
        string domaine;
        private void txtdomaine_SelectedIndexChanged(object sender, EventArgs e)
        {
            domaine = dao.IdCombo("domaine", "code", txtdomaine.Text, "Designation");
        }
        string rayon;
        private void txtRayon_SelectedIndexChanged(object sender, EventArgs e)
        {
            rayon = dao.IdCombo("Rayon", "code", txtRayon.Text, "Designation");
        }
        string code_Etalage;
        private void txtEtalage_SelectedIndexChanged(object sender, EventArgs e)
        {

            code_Etalage = dao.IdCombo("Etalage", "code", txtEtalage.Text, "Designation");

        }
        string code_Exemplaire;
        private void TableOuvrage_Click(object sender, EventArgs e)
        {
            try
            {
                label7.Text = (TableOuvrage.SelectedRows[0].Cells[0].Value.ToString());
                label8.Text = (TableOuvrage.SelectedRows[0].Cells[1].Value.ToString());
                txtouvrage.Text = TableOuvrage.SelectedRows[0].Cells[2].Value.ToString();
                auteur.Text = TableOuvrage.SelectedRows[0].Cells[3].Value.ToString();
                txtdomaine.Text = TableOuvrage.SelectedRows[0].Cells[4].Value.ToString();
                txtville.Text = TableOuvrage.SelectedRows[0].Cells[5].Value.ToString();
                txtdate.Text = TableOuvrage.SelectedRows[0].Cells[6].Value.ToString();
                txtRayon.Text = TableOuvrage.SelectedRows[0].Cells[7].Value.ToString();
                txtEtalage.Text = TableOuvrage.SelectedRows[0].Cells[8].Value.ToString();
                txtQte.Text = TableOuvrage.SelectedRows[0].Cells[9].Value.ToString();
                iTalk_Button_12.Text = "Modifier";
            }
            catch (Exception ex) { MessageBox.Show("Faite une reherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
           
        }
        public void initialiser()
        {
            txtouvrage.Text = "";
            txtdate.Text = "";
            txtdomaine.Text = "";
            txtville.Text = "";
            auteur.Text = "";
            txtRayon.Text = "";
            txtEtalage.Text = "";
            txtQte.Text = "";
            ou.Code = "";
            ou.Code_Exemplaire = "";
            iTalk_Button_12.Text = "Enregistrer";
        }

        private void iTalk_Button_12_Click_1(object sender, EventArgs e)
        {
          

        }

        private void recher_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select Code,Exemplaire,Ouvrage,Auteur, Domaine, Ville_Edition as VilleEdition, ANNEE_EDIT as AnnéeEdition, Rayon, Etalage, Quantite from Liste_Exemplaire where Ouvrage like '%" + recher.Text + "%'", TableOuvrage);
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

        private void txtouvrage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            code_auteur = dao.IdCombo("auteur", "code", auteur.Text, "nom");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            domaine = dao.IdCombo("Domaine", "code", txtdomaine.Text, "Designation");
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtouvrage.Text.Equals("") || txtdomaine.Text.Equals("") || txtville.Text.Equals("") || auteur.Text.Equals("") || txtdate.Value.Equals(null))
                {
                    fx.Messages(3);
                }
                else
                {
                    switch (iTalk_Button_12.Text)
                    {
                        case "Enregistrer":

                                int qte;
                                qte = int.Parse(txtQte.Text);

                                if (qte <= 0)
                                {
                                    MessageBox.Show("Quantite Invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    ou.Etalage = code_Etalage;
                                    ou.Qte = qte;
                                    ou.Rayon = rayon;
                                    string date = txtdate.Value.ToString("yyyy/MM/dd");
                                    ou.Code_Exemplaire = label8.Text;
                                    ou.CodeAuteur = code_auteur;
                                    ou.Domaine = domaine;
                                    ou.Titre = txtouvrage.Text;
                                    ou.Ville = txtville.Text;
                                    ou.AnneeEdition = date;
                                    ou.Etalage = code_Etalage;
                                    ouv.InsertionUpdateDeleteOuvrage(ou, 1);                             
                                    dao.chargementGridOptimise("select Code,Exemplaire,Ouvrage, Auteur, Domaine, Ville_Edition as VilleEdition, ANNEE_EDIT as AnnéeEdition, Rayon, Etalage, Quantite from Liste_Exemplaire", TableOuvrage);
                            }
                            initialiser();
                            break;
                        case "Modifier":
                                int qtes;
                                qtes = int.Parse(txtQte.Text);

                                if (qtes <= 0)
                                {
                                    MessageBox.Show("Quantite Invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string date = txtdate.Value.ToString("yyyy/MM/dd");
                                    ou.Code = label7.Text;
                                    ou.CodeAuteur = code_auteur;
                                    ou.Code_Exemplaire = label8.Text;
                                    ou.Domaine = domaine;
                                    ou.Titre = txtouvrage.Text;
                                    ou.Ville = txtville.Text;
                                    ou.Etalage = code_Etalage;
                                    ou.Rayon = rayon;
                                    ou.Qte = qtes;
                                    ou.AnneeEdition = date;
                                    ouv.InsertionUpdateDeleteOuvrage(ou, 1);
                                    initialiser();
                                dao.chargementGridOptimise("select Code,Exemplaire,Ouvrage, Auteur, Domaine, Ville_Edition as VilleEdition, ANNEE_EDIT as AnnéeEdition, Rayon, Etalage, Quantite from Liste_Exemplaire", TableOuvrage);
                                 initialiser();
                                dao.chargementGridOptimise("select Code,Exemplaire,Ouvrage, Auteur, Domaine, Ville_Edition as VilleEdition, ANNEE_EDIT as AnnéeEdition, Rayon, Etalage, Quantite from Liste_Exemplaire", TableOuvrage);
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtQte_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {

            fx.verifier_Numerique(e);
        }
    }
}
