using Lib_LocationVoiture.Model;
using System;
using System.Collections.Generic;

namespace Lib_LocationVoiture.Services
{
    public class SuccursalesServices
    {
        private SuccursalesDAO succursalesDAO { get; set; }

        public SuccursalesServices()
        {
            succursalesDAO = new SuccursalesDAO();
        }

        /// <summary>
        /// Ajouter une succursale à la table Succursales de la BD
        /// </summary>
        /// <param name="succursale">La succursale qui doit être ajoutée</param>
        public bool addSuccursale(succursale succursale)
        {
            return succursalesDAO.addSuccursale(succursale);            
        }

        /// <summary>
        /// Recherche une succursale dans la table Succursale
        /// </summary>
        /// <param name="searchValue">Le ID de la succursale à chercher</param>
        /// <returns>La succursale si elle existe ; Null sinon</returns>
        public succursale Find(String searchValue)
        {
            succursale succursaleToFind = null;
            try
            {
                succursaleToFind = succursalesDAO.Find(searchValue);
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot retreive Succursale (Méthode SuccursaleFind)");
            }
            return succursaleToFind;
        }

        /// <summary>
        /// Recherche les succursales selon certains critères
        /// </summary>
        /// <param name="searchValue">La valeur recherchée</param>
        /// <param name="searchBy">Le paramètre de recherche</param>
        /// <returns>Une liste contenant les succursales qui correspondes : Une liste vide sinon</returns>
        public List<succursale> FindBy(String searchValue, String searchBy)
        {
            List<succursale> succursaleFinder = new List<succursale>();

            if (searchValue != "")
            {
                try
                {
                    succursaleFinder = succursalesDAO.FindBy(searchValue, searchBy);
                }
                catch
                {
                    Console.WriteLine("Erreur dans le findBy Reservation");
                }
            }
            return succursaleFinder;
        }

        /// <summary>
        /// Retourne une liste qui contient toute les succursales qui se trouvent dans la table
        /// </summary>
        /// <returns>Une liste qui contient les succursales ; Une liste vite sinon</returns>
        public List<succursale> getAllSuccursale()
        {
            List<succursale> listSsuccursale = new List<succursale>();
            try
            {
                listSsuccursale = succursalesDAO.getAllSuccursale();
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot retreive the fabriquants list");
            }            
            return listSsuccursale;
        }

        /// <summary>
        /// Efface une succursale de la table Succursales
        /// </summary>
        /// <param name="succursaleToDelete">La succursales à effacer</param>
        public void Delete(succursale succursaleToDelete)
        {
            try
            {
                succursalesDAO.Delete(succursaleToDelete);
            }
            catch
            {
                Console.WriteLine("Error : Cannot delete succursale");
            }            
        }

        /// <summary>
        /// Enregistre les modification fait à la table Succursale
        /// </summary>
        public bool Save()
        {            
            return succursalesDAO.Save();         
        }
    }
}
