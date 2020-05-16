using Backup.Controlers;
using Backup.Models;
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
    public partial class FrmLoginUtilisateur : Form
    {
        public FrmLoginUtilisateur()
        {
            InitializeComponent();
        }
        ClsDAO don = new ClsDAO();
        ClsLogin lg = new ClsLogin();
        Clsfonctions fx = new Clsfonctions();
      
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        //    this.Close();
        }

        private void nom_Leave(object sender, EventArgs e)
        {
            if (nom.Text == "")
            {
                nom.Text = "Entrez le nom d'utilisateur";
            }
        }

        private void nom_Enter(object sender, EventArgs e)
        {

            if (nom.Text == "Entrez le nom d'utilisateur")
            {
                nom.Text = "";
            }
        }

        private void pwd_Leave(object sender, EventArgs e)
        {

            if (pwd.Text == "")
            {
                pwd.Text = "Entrez";
            }
        }

        private void pwd_Enter(object sender, EventArgs e)
        {
            if (pwd.Text == "Entrez")
            {
                pwd.Text = "";
            }
        }
        private void confirm_Leave(object sender, EventArgs e)
        {
            if (confirm.Text == "")
            {
                confirm.Text = "Entrez";
            }
        }

        private void confirm_Enter(object sender, EventArgs e)
        {
            if (confirm.Text == "Entrez")
            {
                confirm.Text = "";
            }
        }

        private void FrmLoginUtilisateur_Load(object sender, EventArgs e)
        {
            confirm.Enabled = false;
            Photo();
            fx.Picture_Rond(profile);
        }
        public void Photo()
        {
            try
            {
                don.Photo("Code_Photo", id.Text, profile);

            }
            catch
            {

            }
        }
        public void loguer(ClsLogin l)
        {
            l.NomUser = nom.Text;
            l.Pwd = pwd.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nom.Text.Equals("Entrez le nom d'utilisateur") || pwd.Text.Equals("Entrez") || confirm.Enabled.Equals(false))
                {
                    fx.Messages(3);
                }
                else
                {
                    switch (iTalk_Button_23.Text)
                    {                      
                        case "Modifier":
                            lg.Code = id.Text;
                            lg.NomUser = nom.Text;
                            lg.Pwd = confirm.Text;
                            string rqt = "exec [Ajouter_User] '" + lg.Code + "','" + lg.CodeAgent + "','" + lg.NomUser + "','" + lg.Pwd + "','" + lg.Fonction + "','" + lg.Niveau + "','" + lg.Code_entreprise + "'";
                            don.Executer(rqt);
                            fx.Messages(1);                               
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (nom.Text.Equals("Entrez le nom d'utilisateur") || pwd.Text.Equals("Entrez"))
            {
                fx.Messages(3);
            }
            else
            {
                try
                {
                    this.loguer(lg);

                    if (don.logine(lg) == true)
                    {
                        confirm.Enabled = true;
                    }
                    else
                    {
                        fx.Messages(5);

                        confirm.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                }

            }
        }
    }
}
