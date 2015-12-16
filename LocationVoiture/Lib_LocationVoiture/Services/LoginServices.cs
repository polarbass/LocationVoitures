using Lib_LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib_LocationVoiture.Services
{
    public class LoginServices
    {
        public locationVoitures LoginEntitie { get; private set; }

        public LoginServices()
        {
            LoginEntitie = new locationVoitures();
        }

        /// <summary>
        /// Recherche un administrateur dans la table administrateur
        /// </summary>
        /// <param name="nomAdmin">Le username de l'administrateur recherché</param>
        /// <returns>Une administrateur qui correspond à la recherche ; Null sinon</returns>
        private administrateur find(String nomAdmin)
        {
            administrateur administratorFinder = new administrateur();
            try
            {
                administratorFinder = LoginEntitie.administrateurs.SingleOrDefault(admin => admin.nom == nomAdmin);
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot find admin");
            }
            return administratorFinder;
        }

        /// <summary>
        /// Vérification des informations pour autoriser l'accès au programme
        /// </summary>
        /// <param name="username">Le username inscrit lors du login</param>
        /// <param name="password">Le password inscrit lors du login</param>
        /// <returns>True si les informations correspondent à ceux de la base de données ; False sinon</returns>
        public Boolean loginAccepted(String username, String password)
        {
            bool isAccepted = false;

            administrateur adminChecker = find(username);
            List<employe> employesChecker = getAllEmployes();

            // vérification des administrateurs
            if(adminChecker != null)
            {
                // vérification si les informations concordes
                if(adminChecker.nom.Equals(username) && adminChecker.password.Equals(password))
                {
                    // login accepté
                    return true;
                }
            }

            // vérification des employées
            else if(adminChecker == null && employesChecker.Count > 0)
            {
                foreach(employe emp in employesChecker)
                {
                    // seul les Commis et les Administrateurs ont le droit d'utiliser le programme
                    if(emp.fonction.Equals("Commis") || emp.fonction.Equals("Administrateur"))
                    {
                        // vérification des informations inscrites
                        if(emp.username.Equals(username) && emp.password.Equals(password))
                        {
                            // Login accepté
                            return true;
                        }
                    }
                }
            }

            return isAccepted;
        }

        /// <summary>
        /// Retourne une liste qui contient tout les administrateurs enregistrés dans la table administrateur
        /// </summary>
        /// <returns>Une liste avec tout les administrateurs ; Liste vide sinon</returns>
        private List<administrateur> getAllAdministrators()
        {
            List<administrateur> listeAdministrateurs = new List<administrateur>();
            try
            {
                listeAdministrateurs = LoginEntitie.administrateurs.ToList();
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot retreive the admin list");
            }
            
            return listeAdministrateurs;
        }

        /// <summary>
        /// Retourne une liste qui contient tous les employés enregistrés dans la table employe
        /// </summary>
        /// <returns>Une liste de tout les employés ; Liste vide sinon</returns>
        private List<employe> getAllEmployes()
        {
            List<employe> listeEmployes = new List<employe>();
            try
            {
                listeEmployes = LoginEntitie.employes.ToList();
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot retreive the employes list");
            }
            return listeEmployes;
        }

    }
}
