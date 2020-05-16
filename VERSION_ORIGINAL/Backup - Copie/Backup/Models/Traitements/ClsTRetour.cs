using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
    public class ClsTRetour
    {

        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        public void InsertionUpdateRetour(ClsRetour emp, DataGridView table, int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!emp.CodeEntete.Equals("") || !emp.CodeEmprunteur.Equals(""))
                    {
                        if (dao.Executer("Exec  [Ajouter_EnteteRetour] '" + emp.CodeEntete + "','" + emp.Motif + "','" + emp.CodeEmprunteur + "'") == true)
                        {
                            int i = 0;
                            for (int x = 0; x < table.Rows.Count - 1; x++)
                            {
                                emp.CodeExemplaire = table.Rows[x].Cells[0].Value.ToString();
                                emp.Nombre = int.Parse(table.Rows[x].Cells[2].Value.ToString());
                                dao.Executer("Exec  [Ajouter_DetailRetour] '" + emp.Code + "','" + emp.CodeEntete + "','" + emp.CodeExemplaire + "','" + emp.Nombre + "','"+emp.CodeEmprunteur+"'");
                            }
                            if (dao.Executer("Exec  [UpdateEtat] '" + emp.NomEmprunteur + "','" + emp.NomExemplaire + "','" + emp.Nombre + "'") == true)
                            { }

                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 2:
                    if (!emp.CodeEntete.Equals("") || !emp.CodeEmprunteur.Equals(""))
                    {
                        if (dao.Executer("Exec  [Ajouter_EnteteRetour] '" + emp.CodeEntete + "','" + emp.Motif + "','" + emp.CodeEmprunteur + "'") == true)
                        {
                            int i = 0;
                            for (int x = 0; x < table.Rows.Count - 1; x++)
                            {
                                emp.CodeExemplaire = table.Rows[x].Cells[0].Value.ToString();
                                emp.Nombre = int.Parse(table.Rows[x].Cells[2].Value.ToString());
                                dao.Executer("Exec  [Ajouter_DetailEmprunt] '" + emp.CodeEntete + "','" + emp.CodeExemplaire + "','" + emp.Nombre + "'");
                            }
                            fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 3:
                    if (!emp.CodeEntete.Equals(""))
                    {
                        if (dao.Executer("Delete from Detail_Retour where Code='" + emp.Code + "' ").Equals(true) && dao.Executer("Delete from Entete_Retour  where Code='" + emp.CodeEntete + "' ").Equals(true))
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
