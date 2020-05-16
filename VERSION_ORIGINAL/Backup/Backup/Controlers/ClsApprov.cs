using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup.Controlers
{
    public class ClsApprov
    {
        string codeEntete, codeDet, codeOuvage, motif, codeFournisseur;
        int qte;

        public string CodeEntete { get; set; }
        public string CodeFournisseur { get; set; }
        public string Motif { get; set; }


        public string CodeDet { get; set; }
        public string CodeOuvage { get; set; }
        public int Qte { get; set; }
    }
}
