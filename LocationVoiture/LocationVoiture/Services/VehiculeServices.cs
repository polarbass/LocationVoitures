using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationVoiture.Services
{
    class VehiculeServices
    {
        // Propriétés
        private locationvoitureEntities vehiculeEntitie { get; set; }

        // Constructeur
        public VehiculeServices()
        {
            vehiculeEntitie = new locationvoitureEntities();
        }

        /// <summary>
        /// Ajouter une vehicule à la table Vehicule
        /// </summary>
        /// <param name="vehicule">Le véhicule à ajouter</param>
        public void AddVehicule(vehicule vehicule)
        {
            try
            {
                vehiculeEntitie.vehicules.Add(vehicule);
                Save();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                Console.WriteLine("Erreur : Cannot Add Vehicule (Méthode AddVehicule)");
            }
        }

        /// <summary>
        /// Recherche par ID d'un véhicule dans la table véhicule
        /// </summary>
        /// <param name="searchValue">Le ID du véhicule recherché</param>
        /// <returns>Le véhicule recherché ; Null sinon</returns>
        public vehicule FindVehicule(String searchValue)
        {
            vehicule vehiculeFinder = null;
            try
            {
                int vehiculeID = int.Parse(searchValue);
                vehiculeFinder = vehiculeEntitie.vehicules.Where(veh => veh.vehiculeID == vehiculeID).Single();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                Console.WriteLine("Erreur : Cannot Find Vehicule (Méthode FindVehicule)");
            }
            return vehiculeFinder;
        }

        /// <summary>
        /// Recherche la liste des véhicules selon une succursale
        /// </summary>
        /// <param name="succuraleID">Le ID de la succursale utilisée pour la recherche</param>
        /// <returns>La liste des véhicules qui se trouvent à la succursale ; Une liste vide sinon</returns>
        public List<vehicule> GetVehiculesFromSuccursale(int succuraleID)
        {
            List<vehicule> vehiculeFinder = new List<vehicule>();
            try
            {
                var query = from vehi in vehiculeEntitie.vehicules.Include("modele").Include("fabriquant")
                            where vehi.succursaleID == succuraleID
                            select vehi;
                vehiculeFinder = query.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                Console.WriteLine("Erreur : Cannot retreive Vehicule from succursale (Méthode GetVehiculesFromSuccursale)");
            }
            return vehiculeFinder;
        }


        public List<modele> getDistinctModele(int succuraleID)
        {
            List<modele> vehiculeFinder = new List<modele>();

            var query = (from vehi in vehiculeEntitie.vehicules.Include("modele").Include("fabriquant")
                         where vehi.succursaleID == succuraleID
                         select vehi.modele).Distinct();

            vehiculeFinder = query.ToList();

            return vehiculeFinder;
        }


        /// <summary>
        /// Enregistre les modification fait à la table client
        /// </summary>
        public void Save()
        {
            vehiculeEntitie.SaveChanges();
        }
    }
}
