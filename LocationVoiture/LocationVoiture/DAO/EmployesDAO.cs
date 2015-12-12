using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocationVoiture.Services
{
    class EmployesDAO
    {

        private locationvoitureEntities EmployeEntitie { get; set; }

        public EmployesDAO()
        {
            EmployeEntitie = new locationvoitureEntities();
        }

        /// <summary>
        /// Ajouter un employé dans la table Employe
        /// </summary>
        /// <param name="employe">L'employé à ajouter</param>
        /// <returns>True si l'employé a été ajouté ; False sinon</returns>
        public Boolean AddEmploye(employe employe)
        {
            bool isAdded = false;
            employe.date_embauche = DateTime.Now;

            try
            {
                EmployeEntitie.employes.Add(employe);
                Save();
                isAdded = true;
            }
            catch
            {
                Console.WriteLine("Erreur AddEmploye");
                isAdded = false; 
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
                int empID = int.Parse(searchValue);
                employeFinder = EmployeEntitie.employes.Where(emp => emp.employeID == empID).Single();
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
                EmployeEntitie.employes.Remove(employeToDelete);
                Save();
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

                    // SEARCH BY EMPLOYE ID
                    if (searchBy.Equals("employeID"))
                    {
                        int searchValueInt = int.Parse(searchValue);

                        employeFinder = EmployeEntitie.employes.Where(emp => emp.employeID == searchValueInt).ToList();
                    }

                    // SEARCH BY EMPLOYE NOM
                    else if (searchBy.Equals("nom") || searchBy.Equals("prenom"))
                    {
                        employeFinder = EmployeEntitie.employes.Where(emp => emp.nom.ToLower().Contains(searchValue.ToLower())).ToList();
                    }

                    // SEARCH BY EMPLOYE USERNAME
                    else if (searchBy.Equals("username"))
                    {
                        employeFinder = EmployeEntitie.employes.Where(emp => emp.username.ToLower().Contains(searchValue.ToLower())).ToList();
                    }

                    // SEARCH BY EMPLOYE TELEPHONE
                    else if (searchBy.Equals("telephone"))
                    {
                        employeFinder = EmployeEntitie.employes.Where(emp => emp.telephone == searchValue).ToList();
                    }

                    // SEARCH BY EMPLOYES FONCTIONS
                    else if (searchBy.Equals("fonction"))
                    {
                        employeFinder = EmployeEntitie.employes.Where(emp => emp.fonction.ToLower().Contains(searchValue.ToLower())).ToList();
                    }
                    // SEARCH BY EMPLOYES SUCCURSALE
                    else if (searchBy.Equals("succursale"))
                    {
                        int searchValueInt = int.Parse(searchValue);

                        employeFinder = EmployeEntitie.employes.Where(emp => emp.succursaleID == searchValueInt).ToList();
                    }

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
            try
            {
                EmployeEntitie.SaveChanges();
                EmployeEntitie.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
