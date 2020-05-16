using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
    public class ClsTEmprunteurs
    {
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        public void InsertionUpdateDeleteEmpunteurs(ClsEmprunteurs empr, int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!empr.NomComplet.Equals("") || !empr.Sexe.Equals("") || !empr.Sexe.Equals("") || !empr.Mail.Equals("") || !empr.Tele1.Equals("") || !empr.Tele2.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_Emprunteur '" + empr.Code + "','" + empr.NomComplet + "','" + empr.Sexe + "','" + empr.Mail + "','" + empr.Tele1 + "','" + empr.Tele2 + "'") == true)
                        {
                            fx.Messages(1);
                        }
                        else { fx.Messages(2); }
                    }
                    else {fx.Messages(3); }
                    break;
                case 2:
                    if (!empr.NomComplet.Equals("") || !empr.Sexe.Equals("") || !empr.Sexe.Equals("") || !empr.Mail.Equals("") || !empr.Tele1.Equals("") || !empr.Tele2.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_Emprunteur '" + empr.Code + "','" + empr.NomComplet + "','" + empr.Sexe + "','" + empr.Mail + "','" + empr.Tele1 + "','" + empr.Tele2 + "'") == true)
                        {
                            fx.Messages(4);
                        }
                        else { fx.Messages(2); }
                    }
                    else { fx.Messages(3); }
                    break;
                case 3:
                    if (!empr.Code.Equals(""))
                    {
                        if (dao.Executer("Delete from Emprunteur where Code='" + empr.Code + "' ").Equals(true))
                        {
                            fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer le champs svp!"); }
                    break;
            }

        }

    }
}
