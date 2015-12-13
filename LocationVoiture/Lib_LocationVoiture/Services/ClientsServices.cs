using Lib_LocationVoiture.Model;
using System;
using System.Collections.Generic;

namespace Lib_LocationVoiture.Services
{
    public class ClientsServices
    {
        private ClientsDAO clientDAO { get; set; }

        public ClientsServices()
        {
            clientDAO = new ClientsDAO();
        }

        /// <summary>
        /// Ajouter un client dans la table Client
        /// </summary>
        /// <param name="client">Le client à ajouter</param>
        /// <returns>True si le client à été ajouté ; False sinon</returns>
        public Boolean AddClient(client client)
        {

            bool isAdded = false;

            try
            {
                if (clientDAO.AddClient(client))
                {
                    isAdded = true;
                }                
            }
            catch
            {
                Console.WriteLine("Erreur dans le ADDCLIENT");
            }

            return isAdded;             
        }

        /// <summary>
        /// Retourne un client dont le ID correspond au searchvalue
        /// </summary>
        /// <param name="searchValue">Le ID du client qui est recherché</param>
        /// <returns></returns>
        public client Find(String searchValue)
        {
            client clientFinder = null;
            try
            {
                clientFinder = clientDAO.Find(searchValue);
            }
            catch
            {
                Console.WriteLine("erreur FIND Client");
            }        
            return clientFinder;
        }

        /// <summary>
        /// Recherche un client dans la base de donné
        /// </summary>
        /// <param name="searchValue">La valeur recherché</param>
        /// <param name="searchBy">La valeur recherchée dans la table client</param>
        /// <returns></returns>
        public List<client> FindBy(String searchValue, String searchBy)
        {
            List<client> clientFinder = new List<client>();

            if(searchValue != "")
            {
                try
                {
                    clientFinder = clientDAO.FindBy(searchValue, searchBy);              
                }
                catch
                {
                    Console.WriteLine("Erreur dans le find du client");
                }

            }

            return clientFinder;
        }

        /// <summary>
        /// Retire un client de la table client
        /// </summary>
        /// <param name="clientToDelete">Le client à effacer</param>
        public void DeleteClient(client clientToDelete)
        {
            clientDAO.DeleteClient(clientToDelete);
        }

        /// <summary>
        /// Retourne une liste qui contient tout les clients enregistré dans la table client
        /// </summary>
        /// <returns>La liste qui contients les client ; Une liste vide sinon</returns>
        public List<client> GetAllClients()
        {
            List<client> listeClients = new List<client>();
            try
            {
                listeClients = clientDAO.GetAllClients();
            }
            catch
            {
                Console.WriteLine("Erreur : Cannot retreive the clients list");
            }          
            return listeClients;
        }

        /// <summary>
        /// Enregistre les modification fait à la table client
        /// </summary>
        public void Save()
        {
            clientDAO.Save();
        }
    }
}
