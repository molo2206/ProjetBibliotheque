using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backup.Models;

namespace Backup.Rapport
{
    public partial class FrmRapportGeneral : Form
    {
        public FrmRapportGeneral()
        {
            InitializeComponent();
        }

        private void FrmRapportGeneral_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rapport();

        }
        ClsDAO dao = new ClsDAO();
        public void rapport()
        {
            try
            {
                Rapport cr = new Rapport();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "Select * from Rapport_appro";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "Rapport_appro");
                cr.SetDataSource(dao.daset.Tables["Rapport_appro"]);
                ViewRepport.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string date = date1.Value.ToString("yyyy/MM/dd");
            string dates = date2.Value.ToString("yyyy/MM/dd");
            try
            {
                RapportEmprunt cr = new RapportEmprunt();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "select * from Rapport_Emprunt where Date_ BETWEEN CONVERT(varchar(10), '" + date + "', 103) AND CONVERT(varchar(10), '" + dates + "', 103) ";
                dao.daset = new DataSet();
                dao.dp = new SqlDataAdapter(rqt, dao.conn);
                dao.dp.Fill(dao.daset, "Rapport_Emprunt");
                cr.SetDataSource(dao.daset.Tables["Rapport_Emprunt"]);
                ViewRepport.ReportSource = cr;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
