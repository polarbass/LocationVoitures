using Lib_LocationVoiture.Model;
using System.Collections.Generic;
using System.Linq;

namespace Lib_LocationVoiture.Services
{
    class TypesDAO
    {
        private locationVoitures TypesEntitie { get; set; }

        public TypesDAO()
        {
            TypesEntitie = new locationVoitures();
        }

        /// <summary>
        /// Retourne tout les types de voiture
        /// </summary>
        /// <returns>Une liste avec tout les types de voitures ; Liste vide sinon</returns>
        public List<type> getAll()
        {
            List<type> types = new List<type>();

            types = TypesEntitie.types.ToList();

            return types;
        }


        public List<type> getDistinctTypes(int succuraleID)
        {
            List<type> types = new List<type>();

            var query = (from vehi in TypesEntitie.vehicules
                            where vehi.succursaleID == succuraleID
                            select vehi.modele.type).Distinct();

            types = query.ToList();


            return types;
        }
    }
}
