using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Devoir_Librairy_v2.Model
{
    public class Ouvrage
    {
        public string ISBN { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public float Prix { get; set; }
        public string Date { get; set; }
        public int NbPages { get; set; }
        public int categorie { get; set; }

        public Ouvrage()
        {
        }
    }
}