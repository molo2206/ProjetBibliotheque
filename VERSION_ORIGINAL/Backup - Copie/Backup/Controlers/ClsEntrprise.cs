using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup.Models.Traitements
{
  public class ClsEntrprise
    {
         string  numero, adress, mail, telephone, nom_entreprise;
            byte[] logo;
        int code;       
        
            public int Code { get; set; }
            public string Numero { get; set; }
            public string Adresse { get; set; }
            public string Mail { get; set; }
            public string Telephone { get; set; }
            public string Nom_Entreprise { get; set; }
            public byte[] Logo { get; set; }
      
    }
}
