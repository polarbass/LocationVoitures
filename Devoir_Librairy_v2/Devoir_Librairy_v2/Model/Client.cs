using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Devoir_Librairy_v2.Model
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Courriel { get; set; }

        public Client()
        {
        }
    }
}