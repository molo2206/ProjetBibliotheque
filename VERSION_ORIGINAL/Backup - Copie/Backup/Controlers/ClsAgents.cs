using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup.Controlers
{
   public class ClsAgents
    {
        string code, nomComplet, sexe, mail, tele1, tele2;
        byte[] photo;

        public string Code { get; set; }
        public string NomComplet { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        public string Mail { get; set; }
        public string Tele1 { get; set; }
        public byte[] Photo { get; set; }
    }
}
