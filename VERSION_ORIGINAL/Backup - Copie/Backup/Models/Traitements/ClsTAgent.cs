using Backup.Controlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.Models.Traitements
{
     public class ClsTAgent
    {
        ClsDAO dao = new ClsDAO();
        Clsfonctions fx = new Clsfonctions();
        public SqlConnection conn;
        public SqlCommand cmd;
        public IDataReader dr = null;
        public SqlDataAdapter datApt;
        public DataSet daset = null;
        ClsConnexion cnx = new ClsConnexion();
       
        string code_s;
            public void SetParametre(IDbCommand cmd, string name, DbType type, int length, object valeurname)
        {
            //Déclaration et la création de l'objet parametre sur l'objet commande
            IDbDataParameter param = cmd.CreateParameter();
            //Affectation du nom de parametre sur la variable parametre créée
            param.ParameterName = name;
            //Affectation de la longueur du parametre
            param.Size = length;
            //Affectation de type de données au parametre créé
            param.DbType = type;
            if (valeurname == null)
            {
                param.DbType = DbType.String;
                param.Value = DBNull.Value;
            }
            else
                param.Value = valeurname;
            cmd.Parameters.Add(param);
        }
        ClsAgents pt = new ClsAgents();
        public void InsertionUpdateDeleteAgent(ClsAgents ag, int choix)
        {
            switch (choix)
            {
                case 1:
                    if (!ag.NomComplet.Equals("") || !ag.Sexe.Equals("") || !ag.Sexe.Equals("") || !ag.Mail.Equals("") || !ag.Tele1.Equals("") || !ag.Tele1.Equals(""))
                    {
                        ag.Code = code_s;
                        if (dao.Executer("Exec  [Ajouter_Agent] '" + ag.Code + "','" + (ag.NomComplet).ToUpper() + "','" + (ag.Sexe).ToUpper() + "','" + (ag.Mail).ToUpper() + "','" + (ag.Tele1).ToUpper() + "'") == true)
                        {
                            //code_s = dao.MaxId("Agent");
                            //dao.SavePhoto(ag.Photo,"Agent", code_s);
                            fx.Message(choix);
                        }
                        else { fx.Erreur(choix); }
                    }
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 2:
                    if (!ag.NomComplet.Equals("") || !ag.Sexe.Equals("") || !ag.Sexe.Equals("") || !ag.Mail.Equals("") || !ag.Tele1.Equals("") || !ag.Tele1.Equals(""))
                    {
                        cmd.CommandText = " update agent set NomComplet=@nom, sexe=@sexe, email=@mail, Phone=@phone, Profil=@Photo where Code=@code ";
                        SetParametre(cmd, "@code", DbType.String, 50, pt.Code);
                        SetParametre(cmd, "@nom", DbType.String, 50, pt.NomComplet);
                        SetParametre(cmd, "@sexe", DbType.String, 50, pt.Sexe);
                        SetParametre(cmd, "@mail", DbType.String, 50, pt.Mail);
                        SetParametre(cmd, "@phone", DbType.String, 50, pt.Tele1);
                        if (pt.Photo != null)
                            SetParametre(cmd, "@Photo", DbType.Binary, Int32.MaxValue, pt.Photo);
                        else
                            SetParametre(cmd, "@Photo", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        cmd.ExecuteNonQuery();
                    } 
                    else { MessageBox.Show("Veillez completer les champs svp!"); }
                    break;
                case 3:
                    if (ag.Code.Equals(""))
                    {
                        if (dao.Executer("Delete from Agent where Code='" + ag.Code + "' ")==(true))
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
