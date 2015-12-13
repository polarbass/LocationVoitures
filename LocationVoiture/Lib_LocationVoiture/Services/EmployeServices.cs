using Lib_LocationVoiture.Model;
using System;
using System.Collections.Generic;

namespace Lib_LocationVoiture.Services
{
    public class EmployeServices
    {

        private EmployesDAO employesDAO { get; set; }

        public EmployeServices()
        {
            employesDAO = new EmployesDAO();
        }

        /// <summary>
        /// Ajouter un employé dans la table Employe
        /// </summary>
        /// <param name="employe">L'employé à ajouter</param>
        /// <returns>True si l'employé a été ajouté ; False sinon</returns>
        public Boolean AddEmploye(employe employe)
        {
            bool isAdded = false;

            try
            {
                if (employesDAO.AddEmploye(employe))
                {
                    isAdded = true;
                }
                
            }
            catch
            {
                Console.WriteLine("Erreur AddEmploye");
            }

            return isAdded;
        }

        /// <summary>
        /// Retourne un employé dont le ID correspond au searchvalue
        /// </summary>
        /// <param name="searchValue">Le ID de l'employé qui est recherché</param>
        /// <returns>L'employé recherché ; null sinon</returns>
        public employe Find(String searchValue)
        {
            employe employeFinder = null;
            try
            {
                employeFinder = employesDAO.Find(searchValue);
            }
            catch
            {
                Console.WriteLine("erreur FIND employe");
            }
            return employeFinder;
        }

        /// <summary>
        /// Retire un employé de la table employé
        /// </summary>
        /// <param name="employeToDelete">L'employé à effacer</param>
        public void DeleteEmploye(employe employeToDelete)
        {
            try
            {
                employesDAO.DeleteEmploye(employeToDelete);
            }
            catch
            {
                Console.WriteLine("erreur Delete employé");
            }
        }

        public List<employe> FindBy(String searchValue, String searchBy)
        {
            List<employe> employeFinder = new List<employe>();

            if (searchValue != "")
            {
                try
                {
                    employeFinder = employesDAO.FindBy(searchValue, searchBy);
                }
                catch
                {
                    Console.WriteLine("Erreur dans le findBy Employe");
                }

            }

            return employeFinder;
        }

        /// <summary>
        /// Enregistre les modification fait à la table employé
        /// </summary>
        public bool Save()
        {
            return employesDAO.Save();
        }
    }
}
