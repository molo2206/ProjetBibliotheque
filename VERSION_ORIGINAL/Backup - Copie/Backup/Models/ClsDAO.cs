using Backup.Controlers;
using Backup.Formulaire;
using Backup.Models.Traitements;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Backup.Rapport;
using System.Data.Common;

namespace Backup.Models
{
    class ClsDAO
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public IDataReader dr = null;
        //public SqlDataAdapter datApt;
        public DataSet daset = null;
        public SqlDataAdapter dp;
        public DataSet dst = null;
        ClsConnexion cnx = new ClsConnexion();
        static ClsDAO dao;
        public static ClsDAO GetInstance()
        {
            if (dao == null)
                dao = new ClsDAO();
            return dao;
        }
        public void InitialiserConnexion()
        {
            try
            {
                cnx.connect();
                conn = new SqlConnection(cnx.chemin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool Executer(string rqt)
        {
            bool test = false;
            try
            {

                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = (rqt);
                cmd.ExecuteNonQuery();
                test = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return test;

        }
        public int IdComboS(string table, string id, string combo, string colonne1)
        {
            int code = 0;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT * from " + table + " where " + colonne1 + " = '" + combo + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = int.Parse(dr[id].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;
        }
        public DataAdapter Rapport(string requette,string table)
        {
            dp = null;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();

                cmd = new SqlCommand(requette, conn);
                dp = new SqlDataAdapter(cmd);
                daset = new DataSet();
                dp.Fill(daset, table);
                //CrystalReport1 cr = new CrystalReport1();
                //cr.SetDataSource(dp);
                //f.Emprunt.ReportSource = cr;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return dp;
         
        }
        public string IdCombo(string table, string id, string combo, string colonne1)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT * from " + table + " where " + colonne1 + " = '" + combo + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr[id].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;
        }
        public string IdCombo_avec_Integer(string table, string id, int combo, string colonne1)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT * from " + table + " where " + colonne1 + " = '" + combo + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr[id].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;
        }
        public string Barcode(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select Ouvrage from ListeAppro where Barcode='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["Ouvrage"].ToString());
                    FrmEmprunt fr = new FrmEmprunt();
                    if (fr.barcode.Text!="")
                    {
                        fr.barcode.Text = "";
                    }
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
        }
        public string Barcode_emprunter(string rech)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select Empunteur from [Rapport_Emprunt] where Barcode='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["Empunteur"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
        }
        public string Code_Barcode(string rech)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select Code_Exemplaire as code from ListeAppro where Barcode='" + rech + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    code = (dr["code"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;
        }
        public string MaxId(string table)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT  coalesce(max(Code),0) as Id from " + table + " ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Id"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;

        }
        public string IdEntete()
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[GetCodeAppro]() as Id ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Id"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;

        }
        public string chargerNombre(string table, string colonne)
        {
            string id = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT " + colonne + " as nbr from " + table + "", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["nbr"].ToString();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return id;
        }
        public string ChargerCode(string rqt, string colonne)
        {
            string id = null;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr[colonne].ToString();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return id;
        }
        public string IdEnteteEmprunt()
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[GetIdEnteteEmprunt]() as Id ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Id"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;

        }
        public string Etat(string emprunteur)
        {
            string code = "0";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[Etat]('" + emprunteur + "') as val ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code =(dr["val"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public string nom_utili(string nom)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[Nomutilisateur]('" + nom + "') as val ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["val"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public string code_utili(string nom)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[Codeutilisateur]('" + nom + "') as val ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["val"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public int RetournerInt(string sql, string colone)
        {
            int code = 0;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = int.Parse(dr[colone].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public string RetournerString(string sql, string colone)
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = dr[colone].ToString();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }
        public void chargerChat(string table, Chart chart1, string colonne, string colonne1)
        {
            try
            {
                InitialiserConnexion();
                conn.Open();
                cmd = new SqlCommand("SELECT * from " + table + "", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chart1.Series["s1"].Points.AddY(dr[colonne].ToString(), dr[colonne1].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }

        }
        public void RechercheGrid(string rqt, DataGridView table)
        {
            try
            {
                InitialiserConnexion();
                conn.Open();
                SqlDataAdapter n = new SqlDataAdapter(rqt, conn);
                DataTable v = new DataTable();
                n.Fill(v);
                table.DataSource = v;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int QteRetour(string emprunteur, string ouvrage)
        {
            int code = 0;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[QteRetour]('" + emprunteur + "','" + ouvrage + "') as val ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = int.Parse(dr["val"].ToString());
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            return code;

        }

        public void Autocompleted(ComboBox comb, string query, string colonne, string table)
        {
            try
            {
                if (conn.State.ToString().ToLower().Equals("closed")) conn.Open();
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, table);
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i][colonne].ToString());
                }
                comb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                comb.AutoCompleteCustomSource = col;
                comb.AutoCompleteMode = AutoCompleteMode.Suggest;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
           MessageBoxIcon.Error);
            }
        }
        Clsfonctions fx = new Clsfonctions();
        public void SavePhoto(byte[] profil, string Table, string code)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("update " + Table + " set Profil= @photo where Code='" + code + "'", conn);
                cmd.Parameters.Add("@Photo", SqlDbType.Binary, Int32.MaxValue).Value = profil;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
        }
        public void chargementGridOptimise(string sql, DataGridView grid)
        {
            try
            {
                InitialiserConnexion();
                conn.Open();
                SqlDataAdapter n = new SqlDataAdapter(sql, conn);
                System.Data.DataTable v = new DataTable();
                n.Fill(v);
                grid.DataSource = v;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Autocomplete(string rqt,string colone,TextBox auto)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auto.AutoCompleteCustomSource.Add(dr[colone].ToString());

                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }

        }
        public void chargerCombo(string rqt, string colonne, ComboBox combo)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    combo.Items.Add(dr[colonne].ToString());

                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
        }
        public void chargerlist(string rqt, string colonne, ListBox combo)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    combo.Items.Add(dr[colonne].ToString());

                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }

        }
        public string IdEnteteRetour()
        {
            string code = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("Select dbo.[GetIdEnteteRetour]() as Id ", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = (dr["Id"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return code;

        }
        private void SetParametre(IDbCommand cmd, string name, DbType type, int length, object valeurname)
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
        public void InsertionUpdateDeleteAgent_avec_photo(ClsAgents pt, int choix)
        {
            try
            {
                InitialiserConnexion();

                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = conn.CreateCommand();
                switch (choix)
                {
                    case 1:
                        cmd.CommandText = "insert into agent values () ";
                        SetParametre(cmd, "@code_membre", DbType.String, 50, pt.Code.ToUpper());
                        if (pt.Photo != null)
                            SetParametre(cmd, "@Photo", DbType.Binary, Int32.MaxValue, pt.Photo);
                        else
                            SetParametre(cmd, "@Photo", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Enregistrement reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case 2:
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

                        break;
                    case 3:
                        cmd.CommandText = "delete from agent where code=@code";
                        MessageBox.Show("Suppression reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public void InsertionUpdateDeleteEntreprise_avec_photo(ClsEntrprise pt, int choix)
        {
            try
            {
                InitialiserConnexion();

                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = conn.CreateCommand();
                switch (choix)
                {
                    case 1:
                        cmd.CommandText = "insert into Entreprise values (@Numero_mat,@Adresse,@mail,@logo,@Telephone,@Nom_entreprise) ";
                        SetParametre(cmd, "@Numero_mat", DbType.String, 50, pt.Numero.ToUpper());
                        SetParametre(cmd, "@Adresse", DbType.String, 50, pt.Adresse.ToUpper());
                        SetParametre(cmd, "@mail", DbType.String, 50, pt.Mail.ToUpper());
                        if (pt.Logo != null)
                            SetParametre(cmd, "@logo", DbType.Binary, Int32.MaxValue, pt.Logo);
                        else
                            SetParametre(cmd, "@logo", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        SetParametre(cmd, "@Telephone", DbType.String, 50, pt.Numero.ToUpper());
                        SetParametre(cmd, "@Nom_entreprise", DbType.String, 50, pt.Nom_Entreprise.ToUpper());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enregistrement reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        cmd.CommandText = "update Entreprise set  where code=@codeArt";

                        SetParametre(cmd, "@Numero_mat", DbType.String, 50, pt.Numero.ToUpper());
                        SetParametre(cmd, "@Adresse", DbType.String, 50, pt.Adresse.ToUpper());
                        SetParametre(cmd, "@mail", DbType.String, 50, pt.Mail.ToUpper());
                        if (pt.Logo != null)
                            SetParametre(cmd, "@logo", DbType.Binary, Int32.MaxValue, pt.Logo);
                        else
                            SetParametre(cmd, "@logo", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        SetParametre(cmd, "@Nom_entreprise", DbType.String, 50, pt.Nom_Entreprise.ToUpper());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enregistrement reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show("Modification reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        cmd.CommandText = "delete from Membre where Id_Memb=@id";
                        MessageBox.Show("Suppression reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool logine(ClsLogin log)
        {
            bool test = false;
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("SELECT * from Utilisateur where NomUtilisateur='" + log.NomUser + "' and CONVERT(varchar(25),deCRYPTBYPASSPHRASE('tdi202',Mot_de_passe))='" + log.Pwd + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    log.IdAgent = dr["CodeAgent"].ToString();
                    log.NomUser = dr["NomUtilisateur"].ToString();
                    log.Niveau1 = int.Parse(dr["Niveau"].ToString());
                    log.Fonction1 = dr["Fonction"].ToString();
                    log.Code_entreprise = int.Parse(dr["Code_entrePrise"].ToString());
                    log.Code = dr["code"].ToString();
                    test = true;
                }
                else
                {
                    test = false;
                }
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
            return test;
        }
        public void Photo(string table, string id, PictureBox pict)
        {
            try
            {
                InitialiserConnexion();
                cmd = new SqlCommand("select Profil from " + table + " where Code='" + id + "'", conn);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Byte[] dat = new Byte[0];
                    dat = (Byte[])(ds.Tables[0].Rows[0]["Profil"]);
                    MemoryStream men = new MemoryStream(dat);
                    pict.Image = System.Drawing.Image.FromStream(men);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void Photos(string table, int id, PictureBox pict)
        {
            try
            {
                InitialiserConnexion();
                cmd = new SqlCommand("select logo from " + table + " where Code_entreprise='" + id + "'", conn);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Byte[] dat = new Byte[0];
                    dat = (Byte[])(ds.Tables[0].Rows[0]["logo"]);
                    MemoryStream men = new MemoryStream(dat);
                    pict.Image = System.Drawing.Image.FromStream(men);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public string RetourneEntreprise(int la)
        {
            string Nom = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select Nom_entreprise as nom from Entreprise where code_entreprise='" + la + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Nom = (dr["nom"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return Nom;
        }
        public DataSet liste(string requete)
        {
            dao.InitialiserConnexion();
            try
            {
                dao.conn.Open();
                dao.cmd = new SqlCommand(requete, dao.conn);
                dao.dp = new SqlDataAdapter(dao.cmd);
                dao.dst = new DataSet();
                dao.dp.Fill(dao.dst, requete);
                dao.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dao.dst;
        }
        public string Admin__(string admi)
        {
            string Nom = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new SqlCommand("select NomUtilisateur from Utilisateur where NomUtilisateur = '" + admi + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Nom = (dr["NomUtilisateur"].ToString());
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return Nom;
        }
       

    }
}
