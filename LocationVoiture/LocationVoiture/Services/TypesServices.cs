using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVoiture.Services
{
    public class TypesServices
    {
        private locationvoitureEntities TypesEntitie { get; set; }

        public TypesServices()
        {
            TypesEntitie = new locationvoitureEntities();
        }

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
