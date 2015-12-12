using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVoiture.Services
{
    class SuccursalesDAO
    {
        private locationvoitureEntities succursaleEntitie { get; set; }

        public SuccursalesDAO()
        {
            succursaleEntitie = new locationvoitureEntities();
        }

        /// <summary>
        /// Ajouter une succursale à la table Succursales de la BD
        /// </summary>
        /// <param name="succursale">La succursale qui doit être ajoutée</param>
        public bool addSuccursale(succursale succursale)
        {
            try
            {
                succursaleEntitie.succursales.Add(succursale);
                Save();
                return true;
            }
            catch
            {
                Console.WriteLine("Erreur :: Cannot Add Succursale (Méthode AddSuccursale)");
                return false;
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
                succursaleToFind = succursaleEntitie.succursales.Where(succ => succ.succursaleID == succursaleID).SingleOrDefault();
            }
            catch
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
                    // SEARCH BY SUCCURSALE ID
                    if (searchBy.Equals("succursaleID"))
                    {
                        int searchByInt = int.Parse(searchValue);
                        succursaleFinder = succursaleEntitie.succursales.Where(succ => succ.succursaleID == searchByInt).ToList();
                    }

                    // SEARCH BY SUCCURSALE NAME
                    if (searchBy.Equals("nom"))
                    {
                        succursaleFinder = succursaleEntitie.succursales.Where(succ => succ.nom.ToLower().Contains(searchValue.ToLower())).ToList();
                    }

                    // SEARCH BY SUCCURSALE ADDRESSE
                    if (searchBy.Equals("addresse"))
                    {
                        succursaleFinder = succursaleEntitie.succursales.Where(succ => succ.addresse.ToLower().Contains(searchValue.ToLower())).ToList();
                    }
                    // SEARCH BY SUCCURSALE TELEPHONE
                    if (searchBy.Equals("telephone"))
                    {
                        succursaleFinder = succursaleEntitie.succursales.Where(succ => succ.telephone.ToLower().Contains(searchValue.ToLower())).ToList();
                    }
                    // SEARCH BY SUCCURSALE COURRIEL
                    if (searchBy.Equals("courriel"))
                    {
                        succursaleFinder = succursaleEntitie.succursales.Where(succ => succ.courriel.ToLower().Contains(searchValue.ToLower())).ToList();
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

        public void Delete(succursale succursaleToDelete)
        {
            try
            {
                succursaleEntitie.succursales.Remove(succursaleToDelete);
                Save();
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
            try
            {
                succursaleEntitie.SaveChanges();
                succursaleEntitie.Dispose();
                return true;
            }
            catch
            {
                Console.WriteLine("Cannot save");
                return false;
            }

        }
    }
}
