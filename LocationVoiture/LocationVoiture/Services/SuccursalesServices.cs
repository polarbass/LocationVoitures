using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVoiture.Services
{
    class SuccursalesServices
    {
        private locationvoitureEntities succursaleEntitie { get; set; }

        public SuccursalesServices(locationvoitureEntities succursaleEntities)
        {
            succursaleEntitie = succursaleEntities;
        }

        /// <summary>
        /// Ajouter une succursale à la table Succursales de la BD
        /// </summary>
        /// <param name="succursale">La succursale qui doit être ajoutée</param>
        public void AddSuccursale(succursale succursale)
        {
            try
            {
                succursaleEntitie.succursales.Add(succursale);
                Save();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                Console.WriteLine("Erreur : Cannot Add Succursale (Méthode AddSuccursale)");
            }
            
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
                int succursaleID = int.Parse(searchValue);
                succursaleToFind = succursaleEntitie.succursales.Where(succ => succ.succursaleID == succursaleID).Single();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                Console.WriteLine("Erreur : Cannot retreive Succursale (Méthode SuccursaleFind)");
            }
            return succursaleToFind;
        }

        public List<succursale> FindBy(String searchValue, String searchBy)
        {
            List<succursale> succursaleFinder = new List<succursale>();

            if (searchValue != "")
            {
                try
                {
                    // SEARCH BY SUCCURSALE NAME
                    if (searchBy.Equals("nom"))
                    {
                        succursaleFinder = succursaleEntitie.succursales.Where(succ => succ.nom.Contains(searchValue)).ToList();
                    }
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
                listSsuccursale = succursaleEntitie.succursales.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                Console.WriteLine("Erreur : Cannot retreive the fabriquants list");
            }            

            return listSsuccursale;
        }

        /// <summary>
        /// Enregistre les modification fait à la table Succursale
        /// </summary>
        public void Save()
        {
            succursaleEntitie.SaveChanges();
            succursaleEntitie.Dispose();
        }
    }
}
