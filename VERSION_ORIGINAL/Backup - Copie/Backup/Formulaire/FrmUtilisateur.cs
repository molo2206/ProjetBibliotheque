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
    public partial class FrmUtilisateur : Form
    {
        public FrmUtilisateur()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        ClsLogin lg = new ClsLogin();
        Clsfonctions fx = new Clsfonctions();
        ClsEntrprise ag = new ClsEntrprise();
        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {

        }

        public void initialiser()
        {
            Matricule.Text = "";
            entrprise.Text = "";
            mail.Text = "";
            adresse.Text = "";
            phone.Text = "";
            profile.Image.Equals("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fx.Photos(profile);
        }
       
      
        String chem;
        private void FrmUtilisateur_Load_1(object sender, EventArgs e)
        {
            dao.Autocomplete("select NomComplet from Agent where NomComplet = 'Admin'", "nomcomplet", agent);
            dao.Autocomplete("select Nom_entreprise from Entreprise ", "Nom_entreprise", txtfonction);
            //notification1.Visible = false;
            //notif.Visible = false;

        }

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
        }

        private void iTalk_Button_21_Click_1(object sender, EventArgs e)
        {
           
        }

        private void agent_TextChanged(object sender, EventArgs e)
        {
            lg.CodeAgent = dao.IdCombo("agent", "code", txtfonction.Text, "Nomcomplet");
        }

        private void txtfonction_SelectedIndexChanged(object sender, EventArgs e)
        {
            lg.Code_entreprise = dao.IdComboS("entreprise", "code_entreprise", txtfonction.Text, "Nom_entreprise");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lg.Code_entreprise = dao.IdComboS("entreprise", "code_entreprise", txtfonction.Text, "Nom_entreprise");
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.verifier_Numerique(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (entrprise.Text.Equals("Entrez le nom de l'entreprise") || phone.Text.Equals("Entrez le num phone") || Matricule.Text.Equals("Entrez le matricule") || adresse.Text.Equals("Adresse de l'entreprise") || mail.Text.Equals("Adresse mail de l'entreprise") || profile.Image.Equals(null))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (button2.Text)
                    {
                        case "Enregistrer":

                            if (fx.Question(1) == true)
                            {

                                ag.Numero = Matricule.Text;
                                ag.Nom_Entreprise = entrprise.Text;
                                ag.Mail = mail.Text;
                                ag.Adresse = adresse.Text;
                                ag.Logo = fx.GetBytePhoto(profile.Image);
                                ag.Telephone = phone.Text;
                                dao.InsertionUpdateDeleteEntreprise_avec_photo(ag, 1);
                                fx.Messages(1);
                            }
                            else { initialiser(); }
                            break;
                        case "Modifier":

                            if (fx.Question(2) == true)
                            {

                            }
                            else { initialiser(); }
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (agent.Text.Equals("Entrez le nom de l'agent") ||txtnom.Text.Equals("") || txtfonction.Text.Equals("Entrez le nom  de votre entreprise") || txtpwd.Text.Equals("Entrez"))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (button3.Text)
                    {
                        case "Enregistrer":

                                lg.NomUser = txtnom.Text;
                                lg.Fonction = txtfonction.Text;
                                lg.Pwd = txtpwd.Text;
                                if (txtnom.Text != "Admin")
                                {
                                    MessageBox.Show("L'utilisateur doit etre Admin!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                        if (lg.Pwd!=confirmation.Text)
                                        {
                                            fx.Messages(5);
                                        }
                                        else {

                                        string admin = dao.Admin__("Admin");
                                        if (lg.NomUser == admin)
                                        {
                                            MessageBox.Show("Il existe déjà!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            string rqt = "exec [Ajouter_Admin] '" + lg.Code + "','" + agent.Text + "','" + lg.NomUser + "','" + lg.Pwd + "','" + lg.Code_entreprise + "'";
                                            dao.Executer(rqt);
                                            fx.Messages(1);
                                        initialiser();
                                        }
                                    }                                 
                                }
                            break;
                        case "Modifier":

                            if (fx.Question(2) == true)
                            {

                                lg.NomUser = txtnom.Text;
                                lg.Fonction = txtfonction.Text;
                                lg.Pwd = txtpwd.Text;
                                string rqt = "exec [Ajouter_User] '" + lg.Code + "','" + lg.CodeAgent + "','" + lg.NomUser + "','" + lg.Pwd + "','" + lg.Fonction + "','" + lg.Niveau + "'";
                                dao.Executer(rqt);
                            }
                            else { initialiser(); }
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void entrprise_Leave(object sender, EventArgs e)
        {
            if (entrprise.Text=="")
            {
                entrprise.Text = "Entrez le nom de l'entreprise";
            }
        }

        private void entrprise_Enter(object sender, EventArgs e)
        {
            if (entrprise.Text == "Entrez le nom de l'entreprise")
            {
                entrprise.Text = "";
            }
        }

        private void Matricule_Leave(object sender, EventArgs e)
        {
            if (Matricule.Text=="")
            {
                Matricule.Text = "Entrez le matricule";
            }
        }

        private void Matricule_Enter(object sender, EventArgs e)
        {
            if (Matricule.Text == "Entrez le matricule")
            {
                Matricule.Text = "";
            }
        }

        private void adresse_Leave(object sender, EventArgs e)
        {
            if (adresse.Text == "")
            {
                adresse.Text = "Adresse de l'entreprise";
            }
        }

        private void adresse_Enter(object sender, EventArgs e)
        {
            if (adresse.Text == "Adresse de l'entreprise")
            {
                adresse.Text = "";
            }
        }

        private void mail_Leave(object sender, EventArgs e)
        {
            if (mail.Text == "")
            {
                mail.Text = "Adresse mail de l'entreprise";
            }
            
        }

        private void mail_Enter(object sender, EventArgs e)
        {
            if (mail.Text == "Adresse mail de l'entreprise")
            {
                mail.Text = "";
            }
        }

        private void phone_Leave(object sender, EventArgs e)
        {
            if (phone.Text == "")
            {
                phone.Text = "Entrez le num phone";
            }
        }

        private void phone_Enter(object sender, EventArgs e)
        {
            if (phone.Text == "Entrez le num phone")
            {
                phone.Text = "";
            }
        }

        private void entrprise_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void agent_Leave(object sender, EventArgs e)
        {
            if (agent.Text=="")
            {
                agent.Text = "Entrez le nom de l'agent";
            }
        }

        private void agent_Enter(object sender, EventArgs e)
        {
            if (agent.Text== "Entrez le nom de l'agent")
            {
                agent.Text = "";
            }
        }

        private void txtfonction_Enter(object sender, EventArgs e)
        {
            if (txtfonction.Text == "Entrez le nom  de votre entreprise")
            {
                txtfonction.Text = "";
            }
        }

        private void txtfonction_Leave(object sender, EventArgs e)
        {
            if (txtfonction.Text == "")
            {
                txtfonction.Text = "Entrez le nom  de votre entreprise";
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Admin";
            }
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text == "Admin")
            {
                txtnom.Text = "";
            }
        }

        private void txtpwd_Leave(object sender, EventArgs e)
        {
            if (txtpwd.Text == "")
            {
                txtpwd.Text = "Entrez";
            }
        }

        private void txtpwd_Enter(object sender, EventArgs e)
        {
            if (txtpwd.Text == "Entrez")
            {
                txtpwd.Text = "";
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmPrincipale frp = new FrmPrincipale();
            //frp.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {

        }

        private void confirmation_Leave(object sender, EventArgs e)
        {
            if (confirmation.Text=="")
            {
                confirmation.Text = "Entrez";
            }
        }

        private void confirmation_Enter(object sender, EventArgs e)
        {
            if (confirmation.Text=="Entrez")
            {
                confirmation.Text = "";
            }
        }
    }
  
}

