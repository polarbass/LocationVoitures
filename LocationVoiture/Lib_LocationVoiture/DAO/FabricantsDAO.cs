using Lib_LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocationVoiture.Services
{
    class FabricantsDAO
    {

        // Propriétés

        private locationVoitures fabricantsEntitie { get; set; }

        // Constructeur

        public FabricantsDAO()
        {
            fabricantsEntitie = new locationVoitures();
        }

        /// <summary>
        /// Ajouter un fabricants à la table Fabricants
        /// </summary>
        /// <param name="fabricant">Le Fabricants à ajouter</param>
        public void AddFabriquant(fabriquant fabriquant)
        {
            try
            {
                fabricantsEntitie.fabriquants.Add(fabriquant);
                Save();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                Console.WriteLine("Erreur : Cannot Add Fabriquants (Méthode AddFabriquant)");
            }
        }

        /// <summary>
        /// Recherche par ID d'un fabriquant dans la table fabriquant
        /// </summary>
        /// <param name="searchValue">Le ID du fabriquant recherché</param>
        /// <returns>Le fabriquant recherché ; Null sinon</returns>
        public fabriquant FindFabriquant(String searchValue)
        {
            fabriquant fabriquantFinder = null;
            try
            {
                int fabriquantID = int.Parse(searchValue);
                fabriquantFinder = fabricantsEntitie.fabriquants.Where(fab => fab.fabriquantID == fabriquantID).SingleOrDefault();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                Console.WriteLine("Erreur : Cannot Find Vehicule (Méthode FindVehicule)");
            }
            return fabriquantFinder;
        }

        /// <summary>
        /// Recherche de tout les fabriquants
        /// </summary>
        /// <returns>Une liste qui contient tout les fabriquant ; Une liste vide sinon</returns>
        public List<fabriquant> GetAllFabriquants()
        {
            List<fabriquant> listeFabriquants = new List<fabriquant>();
            try
            {
                listeFabriquants = fabricantsEntitie.fabriquants.ToList();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur : Cannot retreive the fabriquants list");
            }

            return listeFabriquants;
        }

        /// <summary>
        /// Retourne une liste avec le nom des fabriquants selon une succursale, sans doublons
        /// </summary>
        /// <param name="succuraleID">Le ID de la succursale</param>
        /// <returns>Une liste de fabriquant ; Une liste vide sinon</returns>
        public List<fabriquant> GetDistinctFabriquants(int succuraleID)
        {
            List<fabriquant> vehiculeFinder = new List<fabriquant>();
            try
            {
                var query = (from vehi in fabricantsEntitie.vehicules.Include("modele").Include("fabriquant")
                             where vehi.succursaleID == succuraleID
                             select vehi.fabriquant).Distinct();

                vehiculeFinder = query.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                Console.WriteLine("Erreur : Cannot retreive Distinct fabriquant (Méthode GetDistinctFabriquants)");
            }

            return vehiculeFinder;
        }

        /// <summary>
        /// Enregistre les modification fait à la table fabricant
        /// </summary>
        public void Save()
        {
            fabricantsEntitie.SaveChanges();
            fabricantsEntitie.Dispose();
        }
    }
}
