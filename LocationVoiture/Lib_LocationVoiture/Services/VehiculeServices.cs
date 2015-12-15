using Lib_LocationVoiture.Model;
using System;
using System.Collections.Generic;

namespace Lib_LocationVoiture.Services
{
    public class VehiculeServices
    {
        // Propriétés
        private VehiculesDAO vehiculesDAO { get; set; }

        // Constructeur
        public VehiculeServices()
        {
            vehiculesDAO = new VehiculesDAO();
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
                isAdded = vehiculesDAO.AddVehicule(vehicule);
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur : Cannot Add Vehicule (Méthode AddVehicule)");
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
                vehiculeFinder = vehiculesDAO.FindVehicule(searchValue);
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot Find Vehicule (Méthode FindVehicule)");
            }
            return vehiculeFinder;
        }

        /// <summary>
        /// Recherche des véhicules selon certains critères de recher
        /// </summary>
        /// <param name="searchValue">La valeur qui est recherchée</param>
        /// <param name="searchBy">La colonne à utiliser pour la recherche</param>
        /// <returns>Une liste de véhicules corresponds aux critères : Une liste vide sinon</returns>
        public List<vehicule> FindBy(String searchValue, String searchBy)
        {
            List<vehicule> vehiculeFinder = new List<vehicule>();

            if (searchValue != "")
            {
                try
                {
                    vehiculeFinder = vehiculesDAO.FindBy(searchValue, searchBy);                   
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
                vehiculeFinder = vehiculesDAO.GetVehiculesFromSuccursale(succuraleID);
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot retreive Vehicule from succursale (Méthode GetVehiculesFromSuccursale)");
            }
            return vehiculeFinder;
        }

        /// <summary>
        /// Retourne une liste avec les modèles disponibles, sans doublons
        /// </summary>
        /// <param name="succuraleID">Le ID de la succursale pour laquelle la recherche est effectuée</param>
        /// <returns>Une liste de modèle qui correspond : Liste vide sinon</returns>
        public List<modele> getDistinctModele(int succuraleID)
        {
            List<modele> vehiculeFinder = new List<modele>();
            try
            {
                vehiculeFinder = vehiculesDAO.getDistinctModele(succuraleID);
            }
            catch
            {
                Console.WriteLine("Erreur dans le GetDistinctModele");
            }            
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
                vehiculesDAO.Delete(vehiculeToDelete);
            }
            catch
            {
                Console.WriteLine("erreur Delete véhicule");
            }
        }

        /// <summary>
        /// Vérification des voitures disponibles selon la liste des paramètres suivant
        /// </summary>
        /// <param name="dateStart">La date du début de la réservation</param>
        /// <param name="dateEnd">La date de la fin de la réservation</param>
        /// <param name="succursaleID">La succursale où le véhicule doit être réservé</param>
        /// <param name="typeID">Le type de véhicule désiré</param>
        /// <returns>Une liste de voiture qu'il est possible de réserver</returns>
        public List<vehicule> AvailableCarsForReservation(DateTime dateStart, DateTime dateEnd, int succursaleID, int typeID)
        {
            List<vehicule> availableCars = new List<vehicule>();
            List<vehicule> availableCarsForReservation = new List<vehicule>();

            try
            {
                // Tout les véhicules disponible à la succursale et selon le type choisi
                availableCars = vehiculesDAO.GetAvailableCars(succursaleID, typeID);

                foreach(vehicule veh in availableCars)
                {
                    if(veh.reservations.Count > 0)
                    {
                        // recherche des réservations en cours pour chaque véhicule de la liste
                        foreach (reservation res in veh.reservations)
                        {
                            DateTime reservationDateDebut = res.date_debut_reservation.Value.Date;
                            DateTime reservationDateFin = res.date_fin_reservation.Value.Date;

                            if (!(reservationDateDebut == dateStart.Date ||
                                reservationDateDebut == dateEnd.Date ||
                                reservationDateFin == dateStart.Date ||
                                reservationDateFin == dateEnd.Date ||
                                (dateStart >= reservationDateDebut && dateStart <= reservationDateFin) ||
                                (dateEnd >= reservationDateDebut && dateEnd <= reservationDateFin) ||
                                (reservationDateDebut > dateStart.Date && reservationDateFin < dateEnd.Date))
                                )
                            {
                                if (!availableCarsForReservation.Contains(veh))
                                {
                                    availableCarsForReservation.Add(veh);
                                }
                            }
                            else
                            {
                                if (availableCarsForReservation.Contains(veh))
                                {
                                    availableCarsForReservation.Remove(veh);
                                }
                            }
                        }
                    }
                    else
                    {
                        availableCarsForReservation.Add(veh);
                    }

                }

            }
            catch
            {
                Console.WriteLine("erreur AvailableCarsForReservation véhicule");
            }

            return availableCarsForReservation;
        }


        /// <summary>
        /// Enregistre les modification fait à la table véhicule
        /// </summary>
        public bool Save()
        {
            return vehiculesDAO.Save();
        }

    }
}
