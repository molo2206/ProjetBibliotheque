using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
    public class ClsTApprov
    {

        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        string code;
        public void InsertionUpdateAppro(ClsApprov appro, DataGridView table, int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!appro.CodeEntete.Equals("") || !appro.CodeOuvage.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_EnteteAppro '" + appro.CodeEntete + "','" + appro.CodeFournisseur + "','" + appro.Motif + "'") == true)
                        {
                            int i = 0;
                            for (int x = 0; x < table.Rows.Count - 1; x++)
                            {

                                appro.CodeOuvage = table.Rows[x].Cells[0].Value.ToString();
                                appro.Qte = int.Parse(table.Rows[x].Cells[2].Value.ToString());
                                dao.Executer("Exec  [Ajout_DetailAppro] '" + appro.CodeEntete + "','" + appro.CodeOuvage + "','" + appro.Qte + "'");
                            }
                            //fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 2:
                    if (!appro.CodeEntete.Equals("") || !appro.CodeFournisseur.Equals(""))
                    {
                        if (dao.Executer("Exec  Ajouter_EnteteAppro '" + appro.CodeEntete + "','" + appro.CodeFournisseur + "','" + appro.Motif + "'").Equals(true))
                        {
                            int i = 0;
                            for (int x = 0; x < table.Rows.Count - 1; x++)
                            {
                                appro.CodeOuvage = table.Rows[x].Cells[0].Value.ToString();
                                appro.Qte = int.Parse(table.Rows[x].Cells[2].Value.ToString());
                                dao.Executer("Exec  [Ajout_DetailAppro]  '" + appro.CodeEntete + "','" + appro.CodeOuvage + "','" + appro.Qte + "'");
                            }
                            fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }

                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 3:
                    if (!appro.CodeEntete.Equals(""))
                    {
                        if (dao.Executer("Delete from DetailAppro where Code='" + appro.CodeDet + "' ").Equals(true) && dao.Executer("Delete from EntetAppro where Code='" + appro.CodeEntete + "' ").Equals(true))
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
