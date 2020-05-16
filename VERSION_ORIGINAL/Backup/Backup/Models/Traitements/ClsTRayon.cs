using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
   public class ClsTRayon
    {
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        public void InsertionUpdateDeleteRayon(ClsRayon ex , int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!ex.Code.Equals("") || !ex.Designation.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajout_Domaine '" + ex.Code + "','" + ex.Designation + "'"))
                        {
                            //fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 2:
                    if (!ex.Code.Equals("") || !ex.Designation.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajout_Domaine '" + ex.Code + "', '" + ex.Designation + "'"))
                        {
                            fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 3:
                    if (!ex.Code.Equals(""))
                    {
                        if (dao.Executer("Delete from Domaine where Code='" + ex.Code + "' ") == (true))
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
