using Backup.Formulaire;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models
{
    public class Clsfonctions
    {
        public bool Messages(int choix)
        {
            bool retour=false ;
            switch (choix)
            {
                case 1:
                    FrmMessage fs = new FrmMessage();
                    fs.ShowDialog();
                    retour = true;                  
                    break;
                case 2:
                    FrmEchec fe = new FrmEchec();
                    fe.ShowDialog();
                    retour = true;
                    break;
                case 3:
                    FrmVide fv = new FrmVide();
                    fv.ShowDialog();
                    retour = true;
                    break;
                case 4:
                    FrmModif fm = new FrmModif();
                    fm.ShowDialog();
                    retour = true;
                    break;
                case 5:
                    FrmIncorrecte fi = new FrmIncorrecte();
                    fi.ShowDialog();
                    retour = true;
                    break;
            }
            return retour;
        }
        public void Picture_Rond(PictureBox p)
        {
            System.Drawing.Drawing2D.GraphicsPath gd = new System.Drawing.Drawing2D.GraphicsPath();
            gd.AddEllipse(0, 0, p.Width - 3, p.Height - 3);
            Region rg = new Region(gd);
            p.Region = rg;
        }
        public void verifier_Numerique(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        public void verifier_Character(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        int nbrfois = 0;
        public int occurrence(DataGridView table, string code)
        {
            string id;
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                id = (table.Rows[i].Cells[0].Value.ToString());
                if (id == code)
                {
                    nbrfois = +1;
                }

            }
            return nbrfois;
        }
        public void ajouter(DataGridView dt, string id, string design, int qte)
        {
            try
            {
                if (design.Equals("") || qte.Equals(""))
                {
                    MessageBox.Show("Veuilez completer les champs !");
                }
                else
                {
                    dt.Rows.Add(id, design, qte);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        public void chargerUserControl(Panel panel, UserControl user)
        {
            panel.Controls.Clear();
            panel.Controls.Add(user);
            panel.Show();
        }
        public void initialiserTable(DataGridView table)
        {
            int x = table.Rows.Count - 2;
            for (int y = 0; y < x; y++)
            {
                table.Rows.RemoveAt(y);
            }
        }
        int ligne;
        public void Supprimer(DataGridView table)
        {
            string indexe = table.CurrentRow.Index.ToString();
            ligne = int.Parse(indexe);
            table.Rows.RemoveAt(ligne);
        }
        string nomFichier = "";
        public void Photos(PictureBox photo)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "(Photos)|*.jpg;*.jpeg;*.ico|(Photo png)|*.png|(Toutes)|*.*";
            fl.ShowDialog();
            nomFichier = fl.FileName.ToString();
            photo.ImageLocation = nomFichier;
        }
        public byte[] GetBytePhoto(Image image)
        {
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(image, typeof(byte[]));
            return arr;
        }
        public string Message(int choix)
        {
            string message = "";
            switch (choix)
            {
                //case 1: MessageBox.Show(" Insertion reuçi!","",MessageBoxButtons.OK,MessageBoxIcon.Information ); break;
                case 2: MessageBox.Show("La modification reuçi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                case 3: MessageBox.Show("La suppression reuçi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
            }
            return message;
        }
        public string Erreur(int choix)
        {
            string message = "";
            switch (choix)
            {
                case 1: MessageBox.Show(" Echec de l'insertion !", "", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case 2: MessageBox.Show("Echec de la modification !", "", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case 3: MessageBox.Show("Echec de la suppression !", "", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
            return message;
        }

        public bool Question(int choix)
        {
            bool test = false;
            switch (choix)
            {
                case 1:
                    DialogResult dr = MessageBox.Show("Voulez vous enregistré?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr.Equals(DialogResult.Yes))
                    {
                        test = true;
                    }
                    else { test = false; MessageBox.Show("L'enregistrement annulé !", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    break;
                case 2:
                    DialogResult rp = MessageBox.Show("Voulez vous modifié ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rp.Equals(DialogResult.Yes))
                    {
                        test = true;
                    }
                    else { test = false; MessageBox.Show("La modification annulée annulé !", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    break;

                case 3:
                    DialogResult r = MessageBox.Show("Voulez vous supprimé?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r.Equals(DialogResult.Yes))
                    {
                        test = true;
                    }
                    else { test = false; MessageBox.Show("La suppression annulée !", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    break;
                case 4:
                    DialogResult imp = MessageBox.Show("Voulez vous imprimé ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (imp.Equals(DialogResult.Yes))
                    {
                        test = true;
                    }
                    else { test = false; MessageBox.Show("L'impression annulé !", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    break;
            }
            return test;


        }
    }
}
