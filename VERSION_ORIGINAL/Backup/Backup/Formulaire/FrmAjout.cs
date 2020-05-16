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
    public partial class FrmAjout : Form
    {
        public FrmAjout()
        {
            InitializeComponent();
        }
        ClsDAO dao = new ClsDAO();
        ClsEtalages et = new ClsEtalages();
        ClsTEtalageEtRayon tet = new ClsTEtalageEtRayon();
        Clsfonctions fx = new Clsfonctions();
        ClsExemplaires ex = new ClsExemplaires();
        ClsRayon ra = new ClsRayon();
        ClsExemplaires exem = new ClsExemplaires();
        string codeRayo;
        string code;
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        string coderayon;
        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtRayon.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (iTalk_Button_22.Text)
                    {
                        case "Enregistrer":
                                ra.Designation = txtRayon.Text;
                                string rqt = "exec [Ajouter_Rayon] '" + ra.Code + "','" + ra.Designation + "'";
                                dao.Executer(rqt);
                                dao.chargementGridOptimise("Select * from Rayon", Table1);
                                initialiser(); dao.chargementGridOptimise("Select * from Rayon", Table1);
                            fx.Messages(1);
                            break;
                        case "Modifier":
                                ra.Code = coderayon;
                                ra.Designation = txtRayon.Text;
                                string rq = "exec [Ajouter_Rayon] '" + ra.Code + "','" + ra.Designation + "'";
                                dao.Executer(rq);
                                dao.chargementGridOptimise("Select * from Rayon", Table1);
                                initialiser(); dao.chargementGridOptimise("Select * from Rayon", Table1);
                            fx.Messages(4); 
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void FrmAjout_Load(object sender, EventArgs e)
        {
            eta.Enabled = false;
            domaine.Enabled = false;
            ray.Enabled = false;
            rech.Enabled = false;
            dao.chargerCombo("select DESIGNATION as des from rayon ", "des", txtRayonEt);
        }

        private void etala_CheckedChanged(object sender, EventArgs e)
        {
            if (checketala.Checked.Equals(true))
            {
                eta.Enabled = true;
                domaine.Enabled = false;
                ray.Enabled = false;
                rech.Enabled = true;
                dao.chargementGridOptimise("Select * from V_Etalage", Table1); ;
            }
        }

        private void checkdomaine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkdomaine.Checked.Equals(true))
            {
                eta.Enabled = false;
                domaine.Enabled = true;
                ray.Enabled = false;
                rech.Enabled = true;
                dao.chargementGridOptimise("select * from domaine", Table1);
            }
        }

        private void checkrayon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkrayon.Checked.Equals(true))
            {
                eta.Enabled = false;
                domaine.Enabled = false;
                ray.Enabled = true;
                rech.Enabled = true;
                dao.chargementGridOptimise("select * from rayon", Table1);
            }
        }
        string code__;
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtetalage.Text.Equals("") )
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (iTalk_Button_12.Text)
                    {
                        case "Enregistrer":

                                et.Code = code;
                                et.Designation = txtetalage.Text;
                                et.Rayon = codeRayon;
                                string rqt = "exec [Ajouter_Etalage] '" + et.Code + "','" + et.Designation + "'";
                                dao.Executer(rqt);
                                dao.chargementGridOptimise("Select * from V_Etalage", Table1);
                                initialiser(); dao.chargementGridOptimise("Select * from V_Etalage", Table1);
                                fx.Messages(1);
                            break;

                        case "Modifier":
                                    et.Code = code__;
                                    et.Designation = txtetalage.Text;
                                    et.Rayon = codeRayon;
                                    string rq = "exec [Ajouter_Etalage] '" + et.Code + "','" + et.Designation + "'";
                                    dao.Executer(rq);
                                    dao.chargementGridOptimise("Select * from V_Etalage", Table1);
                                    initialiser(); dao.chargementGridOptimise("Select * from V_Etalage", Table1);
                            fx.Messages(4);
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        public void initialiser()
        {
            txtRayonEt.Text = "";
        }
        string codeRayon;

        private void txtRayonEt_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeRayon = dao.IdCombo("Rayon", "code", txtRayonEt.Text, "designation");
        }

        string codeDomaine;
        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
         try
            {
                if (txtdomaine.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (iTalk_Button_21.Text)
                    {
                        case "Enregistrer":

                                exem.Code = codeDomaine;
                                exem.Designation = txtdomaine.Text;
                                string rqt = "Exec  [Ajouter_Domaine] '" + exem.Code + "','" + exem.Designation + "'";
                                dao.Executer(rqt);                            
                                dao.chargementGridOptimise("Select * from domaine", Table1);
                                initialiser(); dao.chargementGridOptimise("Select * from domaine", Table1);
                                fx.Messages(1);
                            break;

                        case "Modifier":

                                    exem.Code = codes;
                                    exem.Designation = txtdomaine.Text;
                                    string rq = "Exec  [Ajouter_Domaine] '" + exem.Code + "','" + exem.Designation + "'";
                                    dao.Executer(rq);
                                    dao.chargementGridOptimise("Select * from domaine", Table1);
                                    initialiser(); dao.chargementGridOptimise("Select * from domaine", Table1);
                            fx.Messages(4);
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        string codes;
        private void Table1_Click(object sender, EventArgs e)
        {
            if (checketala.Checked.Equals(true))
            {
                try
                {
                    code__ = Table1.SelectedRows[0].Cells[0].Value.ToString();
                    txtetalage.Text = Table1.SelectedRows[0].Cells[1].Value.ToString();
                    txtRayonEt.Text = Table1.SelectedRows[0].Cells[2].Value.ToString();
                    iTalk_Button_12.Text = "Modifier";
                }
                catch (Exception ex) { MessageBox.Show("Faite une recherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else if (checkdomaine.Checked.Equals(true))
            {
                try
                {
                    codes = Table1.SelectedRows[0].Cells[0].Value.ToString();
                    txtdomaine.Text = Table1.SelectedRows[0].Cells[1].Value.ToString();
                    iTalk_Button_21.Text = "Modifier";
                }
                catch (Exception ex) { MessageBox.Show("Faite une recherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else
            {
                try
                {
                    coderayon = Table1.SelectedRows[0].Cells[0].Value.ToString();
                    txtRayon.Text = Table1.SelectedRows[0].Cells[1].Value.ToString();
                    iTalk_Button_22.Text = "Modifier";
                }
                catch (Exception ex) { MessageBox.Show("Faite une recherhe d'abord", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }

        private void rech_TextChanged(object sender, EventArgs e)
        {
            if (checketala.Checked.Equals(true))
            {
                try
                {
                    dao.chargementGridOptimise("select * from V_Etalage where Etalage like '%"+rech.Text+"%'", Table1);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if (checkdomaine.Checked.Equals(true))
            {
                try
                {
                    dao.chargementGridOptimise("Select * from domaine where designation like '%" + rech.Text + "%'", Table1);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                try
                {
                    dao.chargementGridOptimise("Select * from rayon where designation like '%" + rech.Text + "%'", Table1);
                }
                catch (Exception ex) { MessageBox.Show("erreur"); }
            }
        }

        private void rech_Enter(object sender, EventArgs e)
        {
            if (rech.Text == "Rechercher dans :  Tableau")
            {
                rech.Text = "";
            }
        }

        private void rech_Leave(object sender, EventArgs e)
        {
            if (rech.Text == "")
            {
                rech.Text = "Rechercher dans :  Tableau";
            }
        }
    }
}
