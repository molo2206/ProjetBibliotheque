using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
    public class ClsTAuteur
    {
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();

        public void InsertionUpdateDeleteAuteur(ClsAuteurs aut, int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!aut.Nom.Equals("") || !aut.Postnom.Equals("") || !aut.Prenom.Equals("") || !aut.Sexe.Equals("") || !aut.DateNaiss.Equals("") || !aut.Nationalite.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_Auteur '" + aut.Code + "','" + aut.Nom + "','" + aut.Postnom + "','" + aut.Prenom + "','" + aut.Sexe + "','" + aut.Nationalite + "','" + aut.DateNaiss + "'").Equals(true))
                        {
                            fx.Messages(1);
                        }
                        else { fx.Messages(2); }
                    }
                    else {fx.Messages(3); }
                    break;
                case 2:
                    if (!aut.Nom.Equals("") || !aut.Postnom.Equals("") || !aut.Prenom.Equals("") || !aut.Sexe.Equals("") || !aut.DateNaiss.Equals("") || !aut.Nationalite.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_Auteur '" + aut.Code + "','" + aut.Nom + "','" + aut.Postnom + "','" + aut.Prenom + "','" + aut.Sexe + "','" + aut.Nationalite + "','" + aut.DateNaiss + "'").Equals(true))
                        {
                            fx.Messages(4);
                        }
                        else { fx.Messages(2); }
                    }
                    else {fx.Messages(3); }
                    break;
                case 3:
                    if (!aut.Code.Equals(""))
                    {
                        if (dao.Executer("Delete from Auteur where Code='" + aut.Code + "' ").Equals(true))
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
