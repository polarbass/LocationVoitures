using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Devoir_Librairy_v2.Model
{
    public class CommandeDTO
    {
        public int IdClient { get; set; }
        public List<Ouvrage> Ouvrages { get; set; }
        public DateTime DateCommande { get; set; }

        public CommandeDTO()
        {
        }
    }
}