using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVoiture.Services
{
    public class FabricantsServices
    {

        // Propriétés

        private FabricantsDAO fabricantsDAO{ get; set; }

        // Constructeur

        public FabricantsServices()
        {
            fabricantsDAO = new FabricantsDAO();
        }

        /// <summary>
        /// Ajouter un fabricants à la table Fabricants
        /// </summary>
        /// <param name="fabricant">Le Fabricants à ajouter</param>
        public void AddFabriquant(fabriquant fabriquant)
        {
            try
            {
                fabricantsDAO.AddFabriquant(fabriquant);
            }
            catch
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
                fabriquantFinder = fabricantsDAO.FindFabriquant(searchValue);
            }
            catch
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
                listeFabriquants = fabricantsDAO.GetAllFabriquants();
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
                vehiculeFinder = fabricantsDAO.GetDistinctFabriquants(succuraleID);
            }
            catch
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
            fabricantsDAO.Save();
        }
    }
}
