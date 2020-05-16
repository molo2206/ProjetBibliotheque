using Backup.Models;
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
    public partial class Fr_Configurqtion : Form
    {
        public Fr_Configurqtion()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fr_Configurqtion_Load(object sender, EventArgs e)
        {
            serveur.Items.Add(".");
            serveur.Items.Add("(local)");
            serveur.Items.Add(@".\SQLEXPRESS");
            serveur.Items.Add(string.Format(@"{0}", Environment.MachineName) + "");
            serveur.SelectedIndex = 3;
        }

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
        }
              private void configuration()
        {
            if (serveur.Text.Equals("") || txtdatabase.Text.Equals("Entrez le nom du BD") || txtusername.Text.Equals("Entrez le nom d'utilisateur") || txtpassword.Text.Equals("Entrez") || confirmation.Text.Equals("Entrez"))
            {
                fx.Messages(2);
            }
            else
            {
                if (confirmation.Text!=txtpassword.Text)
                {
                    fx.Messages(2);
                }
                else
                {
                    try
                    {
                        connecter();
                        chem = "Data Source=" + ClsConfiguration.dataS + "; Initial Catalog=" + ClsConfiguration.initcat + "; User Id=" + ClsConfiguration.id + "; Password=" + ClsConfiguration.pass + ";";
                        File.WriteAllText(ClsConstante.Table.chemin, chem.ToString());                       
                        fx.Messages(1);
                        initialiser();
                        
                        Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
        public void initialiser()
        {
            serveur.Text = ""; txtdatabase.Text = ""; txtusername.Text = ""; txtpassword.Text = "";
        }
        String chem;
        void connecter()
        {
            ClsConfiguration.dataS = serveur.Text;
            ClsConfiguration.initcat = txtdatabase.Text;
            ClsConfiguration.id = txtusername.Text;
            ClsConfiguration.pass = txtpassword.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtdatabase_Leave(object sender, EventArgs e)
        {
            if (txtdatabase.Text == "")
            {
                txtdatabase.Text = "Entrez le nom du BD";

            }
        }

        private void txtdatabase_Enter(object sender, EventArgs e)
        {

            if (txtdatabase.Text == "Entrez le nom du BD")
            {
                txtdatabase.Text = "";

            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Entrez le nom d'utilisateur";

            }
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {

            if (txtusername.Text == "Entrez le nom d'utilisateur")
            {
                txtusername.Text = "";

            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Entrez";
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Entrez")
            {
                txtpassword.Text = "";
            }
        }

        private void confirmation_Leave(object sender, EventArgs e)
        {
            if (confirmation.Text == "")
            {
                confirmation.Text = "Entrez";
            }
        }

        private void confirmation_Enter(object sender, EventArgs e)
        {
            if (confirmation.Text == "Entrez")
            {
                confirmation.Text = "";

            }
        }

        private void v_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            configuration(); 
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Frmlogin fs = new Frmlogin();
            //fs.Show();
            //this.Hide();
        }
    }  
}

