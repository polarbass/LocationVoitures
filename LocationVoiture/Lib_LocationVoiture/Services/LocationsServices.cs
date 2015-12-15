using Lib_LocationVoiture.Model;
using System;

namespace Lib_LocationVoiture.Services
{
    public class LocationsServices
    {
        // Propriétés
        private LocationsDAO locationsDAO{ get; set; }
        private ReservationsDAO reservationsDAO { get; set; }

        private const double TAXE_VALUE = 14.175;

        //Constructeur
        public LocationsServices()
        {
            locationsDAO    = new LocationsDAO();
            reservationsDAO = new ReservationsDAO();
        }

        /// <summary>
        /// Ajoute une location à la table location
        /// </summary>
        /// <param name="locationToAdd">La location qui doit être ajoutée</param>
        /// <returns>True si la location a été ajoutée ; False sinon</returns>
        public Boolean AddLocation(location locationToAdd)
        {
            bool isAdded = false;

            reservation reservationToUpdate = reservationsDAO.FindReservation(locationToAdd.reservationID.ToString());
            if(reservationToUpdate != null)
            {
                int id = locationsDAO.AddLocation(locationToAdd);
                if(id != 0)
                {
                    reservationToUpdate.locationID = id;
                    reservationsDAO.Save();
                    isAdded = true;
                }
                
            }
            return isAdded;
        }

        /// <summary>
        /// Recherche par ID d'une location dans la table location
        /// </summary>
        /// <param name="searchValue">Le ID de la location recherchée</param>
        /// <returns>La location recherchée ; Null sinon</returns>
        public location FindLocation(string searchValue)
        {
            return locationsDAO.FindLocation(searchValue);
        }

        public double GetTaxesValue()
        {
            return LocationsServices.TAXE_VALUE;
        }

        /// <summary>
        /// Enregistre les modification fait à la table location
        /// </summary>
        public Boolean Save()
        {
            return locationsDAO.Save();
        }
    }
}
