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
    public partial class FrmApprovision : Form
    {
        public FrmApprovision()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        ClsTApprov appro = new ClsTApprov();
        ClsApprov app = new ClsApprov();
        Clsfonctions fx = new Clsfonctions();
        ClsOuvrages ou = new ClsOuvrages();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmApprovision_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select  Fournisseur, Ouvrage, Quantite, Auteur, Date_Appro from[Rapport_Appro_Date]", Table);
            dao.chargerCombo("select Nom_complet as noms from Fournisseur ", "noms", txtfournisseur);
            dao.Autocomplete("select Designation as Design from Exemplaire", "Design", txtouvrage);
            id.Text = dao.IdEntete();
            panel3.Visible = false;
            
        }
        int Quantite;
        string code_ouvra;
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtouvrage.Text.Equals("") || txtQte.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {
                    Quantite = int.Parse(txtQte.Text);
                    if (Quantite <= 0 || Quantite.Equals(""))
                    {
                        MessageBox.Show("Quantite invalide!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (fx.occurrence(tableAdd, code_ouvra) == 0)
                        {
                            fx.ajouter(tableAdd, code_ouvra, txtouvrage.Text, int.Parse(txtQte.Text));
                            txtouvrage.Text = "";
                            //txtfournisseur.Text = "";

                        }
                        else
                        {
                            int val = int.Parse(tableAdd.SelectedRows[0].Cells[2].Value.ToString());
                            tableAdd.SelectedRows[0].Cells[2].Value = val + Quantite;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtmotif_TextChanged(object sender, EventArgs e)
        {

        }
        string IdFss="";
        private void txtfournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFss = dao.IdCombo("Fournisseur", "code_fourn", txtfournisseur.Text, "Nom_complet");
        }

        private void txtouvrage_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        string Code_det;
        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtfournisseur.Text.Equals("") || id.Text.Equals("") || tableAdd.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (iTalk_Button_11.Text)
                    {
                        case "Enregistrer":

                            if (fx.Question(1) == true)
                            {
                                app.CodeDet = Code_det;
                                app.CodeEntete = id.Text;
                                app.CodeFournisseur = IdFss;
                                app.Motif = txtmotif.Text;
                                appro.InsertionUpdateAppro(app, tableAdd, 1);
                                tableAdd.Rows.Clear();
                                fx.Messages(1);
                                initialiser(); dao.chargementGridOptimise("select  Fournisseur, Ouvrage, Quantite, Auteur, Date_Appro from[Rapport_Appro_Date]", Table);

                            }
                            else { initialiser(); dao.chargementGridOptimise("select  Fournisseur, Ouvrage, Quantite, Auteur, Date_Appro from[Rapport_Appro_Date]", Table);
                            }
                            break;
                        case "Modifier":

                            if (fx.Question(2) == true)
                            {
                                app.Qte = int.Parse(txtQte.Text);
                                appro.InsertionUpdateAppro(app, tableAdd, 2);
                                initialiser(); dao.chargementGridOptimise("select  Fournisseur, Ouvrage, Quantite, Auteur, Date_Appro from[Rapport_Appro_Date]", Table);

                            }
                            else { initialiser(); dao.chargementGridOptimise("select  Fournisseur, Ouvrage, Quantite, Auteur, Date_Appro from[Rapport_Appro_Date]", Table);
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
            txtfournisseur.Text = "";
            tableAdd.Rows.Clear();
            id.Text = dao.IdEntete();
            fx.initialiserTable(tableAdd);

        }
        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtouvrage.Text.Equals("") || txtQte.Text.Equals(""))
                {
                    MessageBox.Show("Veuillez completer les champs svp!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Quantite = int.Parse(txtQte.Text);
                    if (Quantite <= 0 || Quantite.Equals(""))
                    {
                        MessageBox.Show("Quantite invalide!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        tableAdd.SelectedRows[0].Cells[2].Value = qte;
                        panel2.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string idExemplaire = "";
        private void tableAdd_Click(object sender, EventArgs e)
        {
            try
            {
                idExemplaire = tableAdd.SelectedRows[0].Cells[0].Value.ToString();
                txtQuantite.Text = tableAdd.SelectedRows[0].Cells[2].Value.ToString();
                panel3.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show("Charger d'abord le panier "); }
        }

        private void recher_Leave(object sender, EventArgs e)
        {
           
        }

        private void recher_Enter(object sender, EventArgs e)
        {
            
        }

        private void recher_TextChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {

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

        private void rech_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select  Fournisseur, Ouvrage, Quantite, Auteur, Date_Appro from[Rapport_Appro_Date] WHERE ouvrage like '"+rech.Text+"'", Table);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            code_ouvra = dao.IdCombo("Exemplaire", "CODE", txtouvrage.Text, "Designation");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
