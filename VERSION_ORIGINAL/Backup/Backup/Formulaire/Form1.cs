using Backup.Controlers;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClsDAO dao = new ClsDAO();
        ClsLogin lg = new ClsLogin();
        Clsfonctions fx = new Clsfonctions();
        private void Form1_Load(object sender, EventArgs e)
        {
            fx.Picture_Rond(photo);
            dao.Autocomplete("select Nom_entreprise from entreprise ", "Nom_entreprise", txtEntrepris);
            dao.Autocomplete("select nomcomplet from agent","nomcomplet",agent);       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lg.Code_entreprise = dao.IdComboS("entreprise", "code_entreprise", txtEntrepris.Text, "Nom_entreprise");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {

        }
        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
           
        }
        private void photo_Click(object sender, EventArgs e)
        {
            fx.Photos(photo);
        }
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnom.Text.Equals("") || txtfonction.Text.Equals("") || txtpwd.Text.Equals("")||txtEntrepris.Text.Equals("")||txtniveau.Text.Equals(""))
                {
                    fx.Messages(3);
                }
                else
                {

                    switch (iTalk_Button_23.Text)
                    {
                        case "Enregistrer":
                            lg.NomUser = txtnom.Text;
                            lg.Fonction = txtfonction.Text;
                            lg.Pwd = txtpwd.Text;
                            lg.Niveau = int.Parse(txtniveau.Text);
                            string rqt = "exec [Ajouter_Utilis] '" + lg.Code + "','" + lg.CodeAgent + "','" + lg.NomUser + "','" + lg.Pwd + "','" + lg.Niveau + "','" + lg.Fonction + "','" + lg.Code_entreprise+"'";
                            dao.Executer(rqt);
                            fx.Messages(1);
                            
                            break;
                        case "Modifier":
                            lg.NomUser = txtnom.Text;
                            lg.Fonction = txtfonction.Text;
                            lg.Pwd = txtpwd.Text;
                            lg.Niveau = int.Parse(txtniveau.Text);
                            string rq = "exec [Ajouter_User] '" + lg.Code + "','" + lg.CodeAgent + "','" + lg.NomUser + "','" + lg.Pwd + "','" + lg.Fonction + "','" + lg.Niveau + "','" + lg.Code_entreprise + "'";
                            dao.Executer(rq);
                            break;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void agent_TextChanged(object sender, EventArgs e)
        {
            lg.Code_entreprise = dao.IdComboS("entreprise", "code_entreprise", agent.Text, "Nom_entreprise");
        }

        private void agent_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void agent_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void agent_TextChanged_2(object sender, EventArgs e)
        {
            lg.CodeAgent = dao.IdCombo("agent", "code", agent.Text, "Nomcomplet");
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtniveau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
