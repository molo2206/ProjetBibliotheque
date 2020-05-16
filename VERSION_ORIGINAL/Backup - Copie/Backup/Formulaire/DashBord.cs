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
    public partial class DashBord : Form
    {
        public DashBord()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        public int id;
        public void Photo()
        {
            try
            {


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
       
       public int id_entreprise;
        private void DashBord_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            Photo();
            nom_entreprise.Text = dao.RetourneEntreprise(id_entreprise);

            agent.Text = dao.chargerNombre("Agent", "count(Code)").ToString();
            appro.Text = dao.chargerNombre("Rapport_appro ", "sum(Quantite)").ToString();
            livreEmprunte.Text = dao.chargerNombre("Rapport_Emprunt", "count(Qte)").ToString();
            livreDispo.Text = dao.chargerNombre("liste_exemplaire", "sum(Quantite)").ToString();
            int qteRetournee = dao.RetournerInt("select sum(Qte) as Qte from Rapport_Emprunt where ETAt =0", "Qte");

            string auteur = dao.chargerNombre("ListeAuteur", "count(Code)").ToString();
            string fourniseur = dao.chargerNombre("Fournisseur", "count(code_fourn)").ToString();
            string utilisateur = dao.chargerNombre("Utilisateur", "count(Code)").ToString();

            try
            {
                chart2.Series["s1"].IsValueShownAsLabel = true;
                chart2.Series["s1"].Points.AddXY("Nombre d'agents", int.Parse(agent.Text));
                chart2.Series["s1"].Points.AddXY("Livres approvisionnés", int.Parse(appro.Text));
                chart2.Series["s1"].Points.AddXY("Livres empruntés ", int.Parse(livreEmprunte.Text));
                chart2.Series["s1"].Points.AddXY("Livres retouenés ", qteRetournee);
                chart2.Series["s1"].Points.AddXY("Livres disponibles ", int.Parse(livreDispo.Text));

                chart1.Series["s2"].IsValueShownAsLabel = true;
                chart1.Series["s2"].Points.AddXY("Nombre d'agents", int.Parse(agent.Text));
                chart1.Series["s2"].Points.AddXY("Livres approvisionnés", int.Parse(appro.Text));
                chart1.Series["s2"].Points.AddXY("Livres empruntés ", int.Parse(livreEmprunte.Text));
                chart1.Series["s2"].Points.AddXY("Livres retouenés ", qteRetournee);
                chart1.Series["s2"].Points.AddXY("Livres disponibles ", int.Parse(livreDispo.Text));

                chart3.Series["s3"].IsValueShownAsLabel = true;
                chart3.Series["s3"].Points.AddXY("Nombre d'auteur", int.Parse(auteur));
                chart3.Series["s3"].Points.AddXY("Nombre de fournisseur", int.Parse(fourniseur));
                chart3.Series["s3"].Points.AddXY("Nombre d'utilisateur", int.Parse(utilisateur));
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            clock.Text = dt.ToString("hh:mm:ss");

            DateTime dts = DateTime.Now;
            calendar.Text = dt.ToString("dd/MM/yyyy");

        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
            }
            else
            {
                ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();
                my_menu.Items.Add("Ajouter").Name = "Ajouter";
                my_menu.Items.Add("Deconnecter").Name = "Deconnecter";
                my_menu.Items.Add("Ajouter").Name = "Ajouter";

            }
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tourne.Value = tourne.Value + 2;
            if (tourne.Value>10000)
            {
                tourne.Value++;
                timer2.Enabled = false;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
