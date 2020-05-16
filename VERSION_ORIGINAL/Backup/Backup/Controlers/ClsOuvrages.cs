using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup.Controlers
{
    public class ClsOuvrages
    {

        string code, titre, ville, domaine, codeAuteur, etalage, code_Exemplaire,code_rayon;
        int qte;
        DateTime anneeEdition;
        public int Qte { get; set; }
        public string Code { get; set; }
        public string CodeAuteur { get; set; }
        public string Code_Exemplaire { get; set; }
        public string Titre { get; set; }
        public string Ville { get; set; }
        public string Domaine { get; set; }
        public string AnneeEdition { get; set; }
        public string Etalage { get; set; }
        public string Rayon { get; set; }
    }
}
