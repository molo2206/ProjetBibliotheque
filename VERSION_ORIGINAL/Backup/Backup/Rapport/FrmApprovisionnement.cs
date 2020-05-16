using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Backup.Rapport
{
    public partial class Alarme : Form
    {
        System.Timers.Timer timer;
        public Alarme()
        {
            InitializeComponent();
        }

        private void FrmApprovisionnement_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed;

        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if(currentTime.Hour==userTime.Hour && currentTime.Minute==userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    updateLabel upd = UpdateDataLabele;
                    if (lblstatus.InvokeRequired)
                    {
                        Invoke(upd,lblstatus,"Stop");
                    }
                    SoundPlayer play = new SoundPlayer();
                    play.SoundLocation=(@"D:\MES PROJETS\Nuxt\Backup\Backup\bin\Debug\SMS Sifflement.wav");
                    play.PlayLooping();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") + (":")+DateTime.Now.Minute.ToString("00");
            if (label4.Text == label1.Text)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("SMS Sifflement.wav");
                player.Play();
                notifyIcon1.Icon = new System.Drawing.Icon("Forme.icon");
                notifyIcon1.Text = "Ma Premiere Notification";
                notifyIcon1.BalloonTipText = "Alarme play";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipTitle = "Message infos";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }
        delegate void updateLabel(Label lbl, string value);
        void UpdateDataLabele(Label lbl,string value)
        {
            lbl.Text = value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text !=null)
            {
                label4.Text = maskedTextBox1.Text;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblstatus.Text = "Running...";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblstatus.Text = "Stop";
        }
    }
}
