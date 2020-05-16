using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
    public class ClsTOuvrage
    {
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        public void InsertionUpdateDeleteOuvrage(ClsOuvrages ouv, int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!ouv.Titre.Equals("") || !ouv.Ville.Equals("") || !ouv.Domaine.Equals("") || !ouv.AnneeEdition.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_Ouvrages '" + ouv.Code + "','" + ouv.Titre + "','" + ouv.AnneeEdition + "','" + ouv.Ville + "','" + ouv.Domaine + "','" + ouv.CodeAuteur + "','" + ouv.Etalage + "','" + ouv.Qte + "','"+ouv.Rayon+"'").Equals(true))
                        {
                            fx.Messages(1);
                            
                            
                        }
                        else {fx.Messages(2); }
                    }
                    else {fx.Messages(3); }
                    break;
                case 2:
                    if (!ouv.Titre.Equals("") || !ouv.Ville.Equals("") || !ouv.Domaine.Equals("") || !ouv.AnneeEdition.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_Ouvrages '" + ouv.Code + "','" + ouv.Titre + "','" + ouv.AnneeEdition + "','" + ouv.Ville + "','" + ouv.Domaine + "','" + ouv.CodeAuteur + "','" + ouv.Etalage + "','" + ouv.Qte + "','"+ouv.Rayon+"'").Equals(true))
                        {
                            fx.Messages(4);
                        }
                        else { fx.Messages(4); }
                    }
                    else { fx.Messages(3); }

                    break;
                case 3:
                    if (!ouv.Code.Equals(""))
                    {
                        if (dao.Executer("Delete from Ouvrage where Code='" + ouv.Code + "' ").Equals(true))
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
