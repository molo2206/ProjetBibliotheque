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
    }
}
