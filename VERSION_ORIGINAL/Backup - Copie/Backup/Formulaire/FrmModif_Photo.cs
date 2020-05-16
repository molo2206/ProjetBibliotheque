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

namespace Backup.Formulaire
{
    public partial class FrmModif_Photo : Form
    {
        public FrmModif_Photo()
        {
            InitializeComponent();
        }
        ClsDAO ao = new ClsDAO();
        ClsAgents ag = new ClsAgents();
        Clsfonctions fx = new Clsfonctions();
        public string codeagent;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iTalk_Panel1_Click(object sender, EventArgs e)
        {
        }

        private void FrmModif_Photo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (System.Net.WebClient client=new System.Net.WebClient())
            {
                try
                {
                    string url = "http://smsc.vianett.no/v3/send.ashx?" +
                    "src=" + txttelephone.Text + "&" +
                    "dst=" + txttelephone.Text + "&" +
                    "msg=" + System.Web.HttpUtility.UrlEncode
                    (txtmessage.Text, System.Text.Encoding.GetEncoding("ISO-8859-1")) + "" +
                    "username=" + System.Web.HttpUtility.UrlEncode(txtuser.Text) + "&" +
                    "password=" + System.Web.HttpUtility.UrlEncode(txtpwd.Text) + "&";
                    string result = client.DownloadString(url);
                    if (result.Contains("ok"))
                        MessageBox.Show("Message envoyer!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Message n'est pas envoyer!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
