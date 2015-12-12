using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVoiture.Services
{
    public class ModeleServices
    {

        // Propriétés
        private ModelesDAO modelesDAO{ get; set; }

        // Constructeur
        public ModeleServices()
        {
            modelesDAO = new ModelesDAO();
        }

        /// <summary>
        /// Ajouter un model à la table Modele
        /// </summary>
        /// <param name="modele">Le modele à ajouter</param>
        public void AddModele(modele modele)
        {
            try
            {
                modelesDAO.AddModele(modele);
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
                modeleFinder = modelesDAO.FindModele(searchValue);
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
                listeModeles = modelesDAO.GetAll();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur : Cannot retreive the modele list");
            }

            return listeModeles;
        }

        /// <summary>
        /// Recherche de modele qui répondent aux critères de recherche
        /// </summary>
        /// <param name="searchValue">La valeur qui est recherché</param>
        /// <param name="searchBy">La colonne de recherche</param>
        /// <returns>Une liste de modèle qui correspondes aux critères : Liste vide sinon</returns>
        public List<modele> findBy(String searchValue, String searchBy)
        {
            List<modele> modeleFinder = new List<modele>();

            if (searchValue != "")
            {
                try
                {
                    modeleFinder = modelesDAO.findBy(searchValue, searchBy);                 
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
                listeDistinctModels = modelesDAO.DistinctModelBySuccursaleAndFabricant(succursaleID, fabricantID);
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
                nbPassager = modelesDAO.getNbPassager(modeleID);
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
            modelesDAO.Save();
        }

    }
}
