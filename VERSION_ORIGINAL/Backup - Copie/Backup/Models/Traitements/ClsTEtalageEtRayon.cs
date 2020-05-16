using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
    public class ClsTEtalageEtRayon
    {
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();

        public void InsertionUpdateDeleteEtalage(ClsEtalages et, int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!et.Code.Equals("") || !et.Designation.Equals("") || !et.Rayon.Equals(""))
                    {
                        if (dao.Executer("Exec  [Ajouter_Etalage] '" + (et.Code) + "', '" + (et.Designation).ToUpper() + "','" + (et.Rayon).ToUpper() + "'") == (true))
                        {
                            fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 2:
                    if (!et.Code.Equals("") || !et.Designation.Equals("") || !et.Rayon.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_Etalage '" + (et.Code).ToUpper() + "', '" + (et.Designation).ToUpper() + "','" + (et.Rayon).ToUpper() + "'") == (true))
                        {
                            fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 3:
                    if (!et.Code.Equals(""))
                    {
                        if (dao.Executer("Delete from Etalage where Code='" + et.Code + "' ") == (true))
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
