using Lib_LocationVoiture.Model;
using System;
using System.Linq;

namespace Lib_LocationVoiture.Services
{
    class LocationsDAO
    {
        // Propriétés
        public locationVoitures locationEntitie { get; private set; }

        //Constructeur
        public LocationsDAO()
        {
            locationEntitie = new locationVoitures();
        }

        /// <summary>
        /// Ajoute une location à la table location
        /// </summary>
        /// <param name="locationToAdd">La location qui doit être ajoutée</param>
        /// <returns>True si la location a été ajoutée ; False sinon</returns>
        public int AddLocation(location locationToAdd)
        {
            int locationID = 0;        
            try
            {
                locationEntitie.locations.Add(locationToAdd);
                Save();
                locationID = locationToAdd.locationID;
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot Add location (Méthode AddLocation)");
            }
            return locationID;
        }

        /// <summary>
        /// Recherche par ID d'une location dans la table location
        /// </summary>
        /// <param name="searchValue">Le ID de la location recherchée</param>
        /// <returns>La location recherchée ; Null sinon</returns>
        public location FindLocation(string searchValue)
        {
            location locationFinder = null;
            try
            {
                int locationID = int.Parse(searchValue);
                locationFinder = locationEntitie.locations.Where(loc => loc.locationID == locationID).SingleOrDefault();
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot Find Location (Méthode FindLocation)");
            }
            return locationFinder;
        }

        /// <summary>
        /// Enregistre les modification fait à la table reservation
        /// </summary>
        public Boolean Save()
        {
            try
            {
                locationEntitie.SaveChanges();
                locationEntitie.Dispose();
                return true;
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot save location (Méthode AddLocation)");
                return false;
            }
        }
    }
}
