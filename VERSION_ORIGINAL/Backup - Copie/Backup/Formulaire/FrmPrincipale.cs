using Backup.Controlers;
using Backup.Formulaire;
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

namespace Backup
{
    public partial class FrmPrincipale : Form
    {
        public FrmPrincipale()
        {
            InitializeComponent();
            Agrandir_design();
            openChildForm(new DashBord());
        }

        ClsDAO dao = new ClsDAO();
        ClsLogin lg = new ClsLogin();
        Clsfonctions fx = new Clsfonctions();
        //FrmPrincipale frm = new FrmPrincipale();
        public void Agrandir_design()
        {
            panelEnregiSubmenu.Visible = false;
            EmprunSubemenu.Visible = false;
            ApproSubemenu.Visible = false;
            ConfigSubemenu.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelEnregiSubmenu.Visible == true)
                panelEnregiSubmenu.Visible = false;
            if (EmprunSubemenu.Visible == true)
                EmprunSubemenu.Visible = false;
            if (ConfigSubemenu.Visible == true)
                ConfigSubemenu.Visible = false;
            if (ApproSubemenu.Visible == true)
                ApproSubemenu.Visible = false;
        }
        private void Shosubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public int alarm;
        public string xxx;
        public int niveau;


        public int id_entreprise;

        private void FrmPrincipale_Load(object sender, EventArgs e)
        {
            fx.Picture_Rond(profil);
            fx.Picture_Rond(logo_entreprise);
            Photo();
            xxx = alarm.ToString();
            alarme.Text = xxx;

            Entreprise.Text=dao.RetourneEntreprise(id_entreprise);
        }
        public void Photo()
        {
            try
            {
                dao.Photo("Agent", id.Text, profil);             
                
                dao.Photos("entreprise", id_entreprise, logo_entreprise);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmClient());
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {

            Shosubmenu(panelEnregiSubmenu);
        }

        private void btnplayer_Click(object sender, EventArgs e)
        {

            Shosubmenu(EmprunSubemenu);
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {

            Shosubmenu(ApproSubemenu);
        }
        public void Autorisation()
        {

            switch (niveau)
            {
                case 4:
                    openChildForm(new FrmAutres());
                    break;

                default:
                    MessageBox.Show("Autorisation refusée !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void btntools_Click(object sender, EventArgs e)
        {

            Shosubmenu(ConfigSubemenu);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmlogin f = new Frmlogin();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAuteur());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAgent());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAjout());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmOuvrage());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmFournisseur());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmApprovision());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmApprovisionnement());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEmprunt());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRetour());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRapport_Emprunt());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Autorisation();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DashBord());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        FrmLoginUtilisateur fru = new FrmLoginUtilisateur();
        private void user_Click(object sender, EventArgs e)
        {
            try
            {

                fru.nom.Text = dao.nom_utili(user.Text);
                fru.id.Text = dao.code_utili(user.Text);
                fru.ShowDialog();

            }
            catch (Exception ex)
            {

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
