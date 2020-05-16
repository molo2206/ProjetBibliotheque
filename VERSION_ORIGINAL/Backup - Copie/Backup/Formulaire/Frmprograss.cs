using Backup.Formulaire;
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
    public partial class Frmprograss : Form
    {
        public Frmprograss()
        {
            InitializeComponent();
        }

        private void Frmprograss_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         ProgressBar1__.Value= ProgressBar1__.Value +2;
            if(ProgressBar1__.Value>99)
            {
                Frmlogin fr = new Frmlogin();
                fr.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }
    }
}
