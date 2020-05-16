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
    public partial class FrmApprovisionnement : Form
    {
        public FrmApprovisionnement()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        ClsTApprov appro = new ClsTApprov();
        ClsApprov app = new ClsApprov();
        Clsfonctions fx = new Clsfonctions();
        ClsOuvrages ou = new ClsOuvrages();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmApprovisionnement_Load(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from Rapport_Appro", Table);
        }

        private void recher_Leave(object sender, EventArgs e)
        {
            if (recher.Text == "")
            {
                recher.Text = "Rechercher dans :  Tableau";
            }
        }

        private void recher_Enter(object sender, EventArgs e)
        {
            if (recher.Text == "Rechercher dans :  Tableau")
            {
                recher.Text = "";
            }
        }
        string date;
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
          
        }

        private void recher_TextChanged(object sender, EventArgs e)
        {
            dao.chargementGridOptimise("Select * from Rapport_Appro where ouvrage like '%"+recher.Text+"%'", Table);
        }
        string dat;
        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
                dat = dateTimePicker2.Value.ToString("dd/MM/yyyy");
                dao.chargementGridOptimise("select * from Rapport_Appro where convert(varchar(10), date_appro, 103) LIKE '%" + dat + "%'", Table);
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            try
            {
                Rapport.FrmFiche_Appro fr = new Rapport.FrmFiche_Appro();
                fr.ShowDialog();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
