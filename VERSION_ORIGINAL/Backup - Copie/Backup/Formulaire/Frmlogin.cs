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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        ClsDAO don = new ClsDAO();
        ClsLogin lg = new ClsLogin();
        Clsfonctions fx = new Clsfonctions();
        FrmPrincipale frm = new FrmPrincipale();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

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

        private void confirme_Enter(object sender, EventArgs e)
        {
            if (pwd.Text == "Entrez")
            {
                pwd.Text = "";
            }
        }

        private void confirme_Leave(object sender, EventArgs e)
        {
            if (pwd.Text == "")
            {
                pwd.Text = "Entrez";
            }
        }
        public void loguer(ClsLogin l)
        {
            l.NomUser = nom.Text;
            l.Pwd = pwd.Text;
        }
        public int nive;
        public int nive1;
        DashBord da = new DashBord();
        ClsEntrprise entre = new ClsEntrprise();
        private void button1_Click(object sender, EventArgs e)
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
                        frm.id.Text = lg.IdAgent.ToString();
                        frm.user.Text = lg.NomUser;
                        frm.label2.Text = lg.Code;
                        frm.niveau = lg.Niveau1;
                        nive = lg.Niveau1;
                        frm.alarm = nive;

                        nive1 = lg.Code_entreprise;
                        frm.id_entreprise = nive1;
                        da.id_entreprise = nive1;

                        nom.Text = "";
                        pwd.Text = "";
                        this.Hide();
                        frm.Show();

                    }
                    else
                    {
                        fx.Messages(5);
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void Frmlogin_Load(object sender, EventArgs e)
        {
        }
        private void iTalk_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Frmnotification fs = new Frmnotification();
            fs.ShowDialog();
        }
        private void iTalk_LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Frmnotification fs = new Frmnotification();
            fs.ShowDialog();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nom_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
    }
}
