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
    public partial class Frmnotification : Form
    {
        public Frmnotification()
        {
            InitializeComponent();
        }
        Clsfonctions fx = new Clsfonctions();
        private void label1_Click(object sender, EventArgs e)
        {
            if (logine.Text.Equals(""))
            {
                fx.Messages(3);
            }
            else
            {
                if (logine.Text.Equals("ZAB"))
                {
                    Fr_Configurqtion fs = new Fr_Configurqtion();
                    fs.ShowDialog();
                    this.Hide();
                }
                else if (logine.Text.Equals("ALI"))
                {
                    FrmUtilisateur fu = new FrmUtilisateur();
                    fu.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrecte!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Frmnotification_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
