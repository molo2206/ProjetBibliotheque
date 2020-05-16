using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup.Controlers
{
    public class ClsEmprunt
    {
        public string chemin;
        string code, codeEntete, codeEmprunteur, motif, codeExemplaire;
        int nombre;

        public string Code { get; set; }
        public string CodeEntete { get; set; }
        public string Motif { get; set; }
        public string CodeEmprunteur { get; set; }
        public string CodeExemplaire { get; set; }
        public int Nombre { get; set; }

    }
}
