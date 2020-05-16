using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
    public class ClsTCompte
    {
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        public void InsertionUpdateDeleteRetour(ClsCompte cpt, int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!cpt.Code.Equals("") || !cpt.Pseudo.Equals("") || !cpt.MotDePasse.Equals("") || !cpt.Fonction.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouerter_Compte '" + (cpt.Code).ToUpper() + "','" + (cpt.Pseudo).ToUpper() + "','" + (cpt.MotDePasse).ToUpper() + "','" + (cpt.Fonction).ToUpper() + "'") == (true))
                        {
                            fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 2:
                    if (!cpt.Code.Equals("") || !cpt.Pseudo.Equals("") || !cpt.MotDePasse.Equals("") || !cpt.Fonction.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouerter_Compte '" + (cpt.Code).ToUpper() + "','" + (cpt.Pseudo).ToUpper() + "','" + (cpt.MotDePasse).ToUpper() + "','" + (cpt.Fonction).ToUpper() + "'") == (true))
                        {
                            fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 3:
                    if (!cpt.Code.Equals(""))
                    {
                        if (dao.Executer("Delete from Utilisateur where Code='" + cpt.Code + "' ") == (true))
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
