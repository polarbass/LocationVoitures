using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVoiture.Services
{
    class ModelesDAO
    {

        // Propriétés
        public locationvoitureEntities modeleEntitie { get; private set; }

        // Constructeur
        public ModelesDAO()
        {
            modeleEntitie = new locationvoitureEntities();
        }

        /// <summary>
        /// Ajouter un model à la table Modele
        /// </summary>
        /// <param name="modele">Le modele à ajouter</param>
        public void AddModele(modele modele)
        {
            try
            {
                modeleEntitie.modeles.Add(modele);
                Save();
            }
            catch 
            {
                Console.WriteLine("Erreur : Cannot Add Modele (Méthode AddModele)");
            }
        }

        /// <summary>
        /// Recherche par ID d'un modele dans la table modele
        /// </summary>
        /// <param name="searchValue">Le ID du modele recherché</param>
        /// <returns>Le modele recherché ; Null sinon</returns>
        public modele FindModele(String searchValue)
        {
            modele modeleFinder = null;
            try
            {
                int modeleID = int.Parse(searchValue);
                modeleFinder = modeleEntitie.modeles.Where(mod => mod.modeleID == modeleID).Single();
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot Find modele (Méthode FindModele)");
            }
            return modeleFinder;
        }

        /// <summary>
        /// Retourne une liste de tout les modeles de la table modele
        /// </summary>
        /// <returns>La liste des modèles ; liste vide sinon</returns>
        public List<modele> GetAll()
        {
            List<modele> listeModeles = new List<modele>();
            try
            {
                listeModeles = modeleEntitie.modeles.ToList();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur : Cannot retreive the modele list");
            }

            return listeModeles;
        }

        public List<modele> findBy(String searchValue, String searchBy)
        {
            List<modele> modeleFinder = new List<modele>();

            if (searchValue != "")
            {
                try
                {
                    int searchValueInt;

                    // SEARCH BY FABRICANT ID
                    if (searchBy.Equals("fabricantID"))
                    {
                        searchValueInt = int.Parse(searchValue);

                        var query = (from vehi in modeleEntitie.vehicules
                                     where vehi.fabriquantID == searchValueInt
                                     select vehi.modele).Distinct();

                        modeleFinder = query.ToList();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Erreur dans le findby modele");
                }
         
            }
            return modeleFinder;
        }
            

        /// <summary>
        /// Une liste des modèle selon une succursale et un fabriquant
        /// </summary>
        /// <param name="succursaleID">La succursale</param>
        /// <param name="fabricantID">Le fabriquant</param>
        /// <returns></returns>
        public List<modele> DistinctModelBySuccursaleAndFabricant(int succursaleID, int fabricantID)
        {
            List<modele> listeDistinctModels = new List<modele>();
            try
            {
                var query = (from vehi in modeleEntitie.vehicules.Include("modele").Include("fabriquant")
                             where vehi.succursaleID == succursaleID
                             where vehi.fabriquantID == fabricantID
                             select vehi.modele).Distinct();

                listeDistinctModels = query.ToList();
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot Find modele (Méthode DistinctModelBySuccursaleAndFabricant)");
            }
            return listeDistinctModels;
        }

        /// <summary>
        /// Retourn le nombre de passager du modèle recherché
        /// </summary>
        /// <param name="modeleID">Le modèle recheché</param>
        /// <returns>Le nombre de passager que le modèle peut contenir</returns>
        public int getNbPassager(int modeleID)
        {
            int nbPassager = 0;
            try
            {
                modele mod = modeleEntitie.modeles.Where(p => p.modeleID == modeleID).Single();
                nbPassager = (int)mod.nb_place;
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot retreive nombre de passager (Méthode getNbPassager)");
            }

            return nbPassager;
        }

        /// <summary>
        /// Enregistre les modification fait à la table modele
        /// </summary>
        public void Save()
        {
            modeleEntitie.SaveChanges();
            modeleEntitie.Dispose();
        }

    }
}
