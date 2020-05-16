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
    public partial class FrmAuteur : Form
    {
        public FrmAuteur()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        ClsAuteurs aut = new ClsAuteurs();
        ClsTAuteur TAut = new ClsTAuteur();
        private void FrmAuteur_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from Auteur", Table);
            notification1.Visible = false;
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
           
    }

        private void Table_Click(object sender, EventArgs e)
        {
            try
            {
                aut.Code = (Table.SelectedRows[0].Cells[0].Value.ToString());
                nom.Text = Table.SelectedRows[0].Cells[1].Value.ToString();
                postnom.Text = Table.SelectedRows[0].Cells[2].Value.ToString();
                prenom.Text = Table.SelectedRows[0].Cells[3].Value.ToString();
                sexe.Text = Table.SelectedRows[0].Cells[4].Value.ToString();
                nationalite.Text = Table.SelectedRows[0].Cells[5].Value.ToString();
                datenaiss.Text = Table.SelectedRows[0].Cells[6].Value.ToString();
                iTalk_Button_11.Text = "Modifier";
                notification1.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Faite une recherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void recher_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from Auteur where nom like '%" + recher.Text + "%'", Table);
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
                if (nom.Text.Equals("") || postnom.Text.Equals("") || prenom.Text.Equals("") || sexe.Text.Equals("") || datenaiss.Text.Equals("") || nationalite.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (iTalk_Button_11.Text)
                    {
                        case "Enregistrer":
                                string date = datenaiss.Value.ToString("yyyy/MM/dd");

                                aut.Nom = nom.Text;
                                aut.Postnom = postnom.Text;
                                aut.Prenom = prenom.Text;
                                aut.Sexe = sexe.Text;
                                aut.DateNaiss = date;
                                aut.Nationalite = nationalite.Text;
                                TAut.InsertionUpdateDeleteAuteur(aut, 1);
                                
                                dao.chargementGridOptimise("Select * from Auteur", Table);                          
                                initialiser(); dao.chargementGridOptimise("Select * from Auteur", Table); 
                            break;
                        case "Modifier":

                                string dates = datenaiss.Value.ToString("yyyy/MM/dd");
                                aut.Nom = nom.Text;
                                aut.Postnom = postnom.Text;
                                aut.Prenom = prenom.Text;
                                aut.Sexe = sexe.Text;
                                aut.DateNaiss = dates;
                                aut.Nationalite = nationalite.Text;
                                TAut.InsertionUpdateDeleteAuteur(aut, 2);
                               
                                dao.chargementGridOptimise("Select * from Auteur", Table);
                                initialiser(); dao.chargementGridOptimise("Select * from Auteur", Table); 
                            break;
                    }
                }
            }

            catch (Exception ex) { MessageBox.Show("Faite une reherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
        public void initialiser()
        {
            nom.Text = "";
            postnom.Text = "";
            prenom.Text = "";
            sexe.Text = "";
            nationalite.Text = "";
        }

        private void datenaiss_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
