using Backup.Models;
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

namespace Backup.Rapport
{
    public partial class FrmFiche_Appro : Form
    {
        public FrmFiche_Appro()
        {
            InitializeComponent();
        }

        private void Rapport1_InitReport(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rapport();
        }
        ClsDAO dao = new ClsDAO();
        public void rapport()
        {
            string date = date1.Value.ToString("yyyy/MM/dd");
            string dates = date2.Value.ToString("yyyy/MM/dd");
            try
            {
                Rapport cr = new Rapport();
                dao.InitialiserConnexion();
                if (!dao.conn.State.ToString().ToLower().Equals("open")) dao.conn.Open();
                string rqt = "SELECT * FROM ListeAppro WHERE Date_Appro BETWEEN CONVERT(varchar(10), '"+date+"', 103) AND CONVERT(varchar(10), '"+dates+"', 103) ";
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
