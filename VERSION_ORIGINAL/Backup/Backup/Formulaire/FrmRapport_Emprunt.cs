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
using Backup.Rapport;
using System.Data.Common;
using System.Data.SqlClient;

namespace Backup.Formulaire
{
    public partial class FrmRapport_Emprunt : Form
    {
        public FrmRapport_Emprunt()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        private void FrmRapport_Emprunt_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select  Code,Empunteur,Ouvrage,Motif,Auteur,Qte,Date_ as Date_Operation from Rapport_Emprunt where Etat=0", Table1);
            dao.chargementGridOptimise("select Code,Empunteur,Ouvrage,Motif,Auteur,Qte,Date_ as Date_Operation from [Rapport_Emprunt] order by Code asc", Table);
            ouvrageEmprunte.Text = (dao.RetournerInt("select COUNT(Code) as Code from Rapport_Emprunt where ETAT = 1", "Code").ToString());
            ouvrageRetourne.Text = (dao.RetournerInt("select COUNT(Code) as Code from Rapport_Emprunt where ETAT = 0", "Code").ToString());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }
        string date;
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            dao.chargementGridOptimise("select Code, Empunteur, Ouvrage, Motif, Auteur, Qte, Date_ as Date_Operation from Rapport_Emprunt where convert(varchar(10), Date_, 103) LIKE '%" + date + "%'", Table);      
        }
        string dates;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dates = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            dao.chargementGridOptimise("select Code, Empunteur, Ouvrage, Motif, Auteur, Qte, Date_ as Date_Operation from Rapport_Emprunt where convert(varchar(10), Date_, 103) LIKE '%" + dates + "%'", Table1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select Code, Empunteur, Ouvrage, Motif, Auteur, Qte, Date_ as Date_Operation from Rapport_Emprunt where ouvrage LIKE '%" + rech1.Text + "%'", Table);
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("select Code, Empunteur, Ouvrage, Motif, Auteur, Qte, Date_ as Date_Operation from Rapport_Emprunt where ouvrage LIKE '%" + rech.Text + "%'", Table1);
        }

        private void rech1_Leave(object sender, EventArgs e)
        {
            if (rech1.Text == "")
            {
                rech1.Text = "Rechercher dans :  Tableau";
            }
        }

        private void rech1_Enter(object sender, EventArgs e)
        {
            if (rech1.Text == "Rechercher dans :  Tableau")
            {
                rech1.Text = "";
            }
        }

        DataAdapter d = null;
        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            try
            {
                   Rapport.FrmFiche_Appro fr = new Rapport.FrmFiche_Appro();
                   fr.ShowDialog(); 
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void rech_Leave(object sender, EventArgs e)
        {

        }

        private void rech_Enter(object sender, EventArgs e)
        {

        }
        public void rapport()
        {
            try
            {
                FrmRapportGeneral fr = new FrmRapportGeneral();
                RpEmprunt cr = new RpEmprunt();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "Select * from Rapport_appro";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt,dao.conn);
                dao.dp.Fill(dao.daset,"Emprunt");
                cr.SetDataSource(dao.daset.Tables["Emprunt"]);
                fr.ShowDialog();



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {

        }
    }
    
}