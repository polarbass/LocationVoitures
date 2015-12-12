using Lib_LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocationVoiture.Services
{
    class VehiculesDAO
    {
        // Propriétés
        private locationVoitures vehiculeEntitie { get; set; }

        // Constructeur
        public VehiculesDAO()
        {
            vehiculeEntitie = new locationVoitures();
        }

        /// <summary>
        /// Ajouter une vehicule à la table Vehicule
        /// </summary>
        /// <param name="vehicule">Le véhicule à ajouter</param>
        public bool AddVehicule(vehicule vehicule)
        {
            bool isAdded = false;
            try
            {
                vehicule.loc_state = "LIBRE";
                vehicule.kilometrage = 0;

                vehiculeEntitie.vehicules.Add(vehicule);
                Save();
                isAdded = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur :: Cannot Add Vehicule (Méthode AddVehicule)");
                Console.WriteLine(e.ToString());
            }
            return isAdded;
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
                vehiculeFinder = vehiculeEntitie.vehicules.Include("modele").Include("succursale").Where(veh => veh.vehiculeID == vehiculeID).SingleOrDefault();
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot Find Vehicule (Méthode FindVehicule)");
            }
            return vehiculeFinder;
        }

        public List<vehicule> FindBy(String searchValue, String searchBy)
        {
            List<vehicule> vehiculeFinder = new List<vehicule>();

            if (searchValue != "")
            {
                try
                {                    

                    // SEARCH BY VEHICULE ID
                    if (searchBy.Equals("vehiculeID"))
                    {
                        int searchValueInt = int.Parse(searchValue);
                        vehiculeFinder = vehiculeEntitie.vehicules.Where(veh => veh.vehiculeID == searchValueInt).ToList();
                    }

                    // SEARCH BY VEHICULE FABRIQUANT
                    else if (searchBy.Equals("fabricant"))
                    {
                        int searchValueInt = int.Parse(searchValue);
                        vehiculeFinder = vehiculeEntitie.vehicules.Where(veh => veh.fabriquantID == searchValueInt).ToList();
                    }

                    // SEARCH BY VEHICULE MODELE
                    else if (searchBy.Equals("modele"))
                    {
                        int searchValueInt = int.Parse(searchValue);
                        vehiculeFinder = vehiculeEntitie.vehicules.Where(veh => veh.modeleID == searchValueInt).ToList();
                    }

                    // SEARCH BY VEHICULE PLATE NUMBER
                    else if (searchBy.Equals("plateNum"))
                    {
                        vehiculeFinder = vehiculeEntitie.vehicules.Where(veh => veh.plaque_num.ToLower().Contains(searchValue)).ToList();
                    }

                    // SEARCH BY vehicules SUCCURSALE
                    else if (searchBy.Equals("succursale"))
                    {
                        int searchValueInt = int.Parse(searchValue);
                        vehiculeFinder = vehiculeEntitie.vehicules.Where(veh => veh.succursaleID == searchValueInt).ToList();
                    }

                }
                catch
                {
                    Console.WriteLine("Erreur dans le findBy vehicule");
                }

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
        /// Retire un véhicule de la table véhicule
        /// </summary>
        /// <param name="vehiculeToDelete">Le véhicule à effacer</param>
        public void Delete(vehicule vehiculeToDelete)
        {
            try
            {
                vehiculeEntitie.vehicules.Remove(vehiculeToDelete);
                Save();
            }
            catch
            {
                Console.WriteLine("erreur Delete véhicule");
            }
        }


        /// <summary>
        /// Enregistre les modification fait à la table client
        /// </summary>
        public bool Save()
        {
            try
            {
                vehiculeEntitie.SaveChanges();
                vehiculeEntitie.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
