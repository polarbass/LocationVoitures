using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocationVoiture.Services
{
    public class ClientsServices
    {
        private locationvoitureEntities ClientsEntitie { get; set; }

        public ClientsServices(locationvoitureEntities clientsEntitie)
        {
            ClientsEntitie = clientsEntitie;
        }

        /// <summary>
        /// Ajouter un client dans la table Client
        /// </summary>
        /// <param name="client">Le client à ajouter</param>
        /// <returns>True si le client à été ajouté ; False sinon</returns>
        public Boolean AddClient(client client)
        {

            bool isAdded = false;

            // valeur par défaut
            client.permis_conduire_num = "0000000000";
            client.assurance = "0000000000";
            client.date_enregistrement = DateTime.Now;

            // mot de passe temporaire (prenom + nom + jour de l'inscription)
            client.password = client.prenom.ToLower() + client.nom.ToLower() + DateTime.Now.Day;

            try
            {
                ClientsEntitie.clients.Add(client);
                Save();
                isAdded = true;
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
                int clientID = int.Parse(searchValue);
                clientFinder = ClientsEntitie.clients.Where(c => c.clientID == clientID).Single();
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
                
                // SEARCH BY CLIENT ID
                if (searchBy.Equals("clientID"))
                {
                    int searchValueInt = int.Parse(searchValue);

                    var query = from c in ClientsEntitie.clients
                                where c.clientID == searchValueInt
                                select c;

                    clientFinder = query.ToList();
                }

                // SEARCH BY CLIENT NOM
                else if (searchBy.Equals("nom"))
                {
                    var query = from c in ClientsEntitie.clients
                                where c.nom.Equals(searchValue)
                                select c;

                    clientFinder = query.ToList();
                }

                // SEARCH BY CLIENT PRENOM
                else if (searchBy.Equals("prenom"))
                {
                    var query = from c in ClientsEntitie.clients
                                where c.prenom.Equals(searchValue)
                                select c;

                    clientFinder = query.ToList();
                }

                // SEARCH BY CLIENT PRENOM
                else if (searchBy.Equals("courriel"))
                {
                    var query = from c in ClientsEntitie.clients
                                where c.courriel.Equals(searchValue)
                                select c;

                    clientFinder = query.ToList();
                }

                // SEARCH BY CLIENT PRENOM
                else if (searchBy.Equals("telephone"))
                {
                    var query = from c in ClientsEntitie.clients
                                where c.telephone.Equals(searchValue)
                                select c;

                    clientFinder = query.ToList();
                }

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
            ClientsEntitie.clients.Remove(clientToDelete);
            Save();
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
                listeClients = ClientsEntitie.clients.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
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
            ClientsEntitie.SaveChanges();
            ClientsEntitie.Dispose();
        }
    }
}
