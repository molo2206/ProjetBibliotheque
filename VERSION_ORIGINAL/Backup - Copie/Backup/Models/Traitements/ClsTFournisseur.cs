using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
    public class ClsTFournisseur
    {
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        public void InsertionUpdateDeleteFournisseur(ClsFournisseur fss, int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!fss.NomComplet.Equals("") || !fss.Sexe.Equals("") || !fss.Mail.Equals("") || !fss.Tele.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_Fournisseur '" + fss.Code + "','" + fss.NomComplet + "','" + fss.Sexe + "','" + fss.Mail + "','" + fss.Tele + "'") == true)
                        {
                            fx.Messages(1);
                        }
                        else { fx.Messages(2); }
                    }
                    else { fx.Messages(3); }
                    break;
                case 2:
                    if (!fss.NomComplet.Equals("") || !fss.Sexe.Equals("") || !fss.Mail.Equals("") || !fss.Tele.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_Fournisseur '" + fss.Code + "','" + fss.NomComplet + "','" + fss.Sexe + "','" + fss.Mail + "','" + fss.Tele + "'") == true)
                        {
                            fx.Messages(4);
                        }
                        else { fx.Messages(3); }
                    }
                    else { fx.Messages(2); }
                    break;
                case 3:
                    if (!fss.Code.Equals(""))
                    {
                        if (dao.Executer("Delete from Fournisseur where code_fourn='" + fss.Code + "' ").Equals(true))
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
