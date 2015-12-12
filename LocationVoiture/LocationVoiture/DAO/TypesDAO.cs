using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVoiture.Services
{
    class TypesDAO
    {
        private locationvoitureEntities TypesEntitie { get; set; }

        public TypesDAO()
        {
            TypesEntitie = new locationvoitureEntities();
        }

        /// <summary>
        /// Retourne tout les types de voiture
        /// </summary>
        /// <returns>Une liste avec tout les types de voitures ; Liste vide sinon</returns>
        public List<type> getAll()
        {
            List<type> types = new List<type>();
            using(var context = TypesEntitie)
            {
                types = context.types.ToList();
            }
            return types;
        }
    }
}
