using Devoir_Librairy_v2.DB;
using Devoir_Librairy_v2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Devoir_Librairy_v2.DAO
{
    public class CommandeDAO
    {
        private Connexion connexion { get; set; }

        public CommandeDAO(Connexion cnn)
        {
            connexion = cnn;
        }

        /// <summary>
        /// ADD Commande
        /// </summary>
        /// <param name="commandeDTO">La commande à ajouter</param>
        public void InscrireCommande(CommandeDTO commandeDTO)
        {
           
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connexion.Open();

            foreach (Ouvrage ouvrage in commandeDTO.Ouvrages)
            {
                OleDbCommand command = new OleDbCommand();

                command.Connection = connexion.cnn;

                command.CommandText = "INSERT INTO Commandes (IDClient, ISBN, DateCommande) VALUES (@ID, @ISBN, NOW())";
                command.Parameters.AddWithValue("@ID", commandeDTO.IdClient);
                command.Parameters.AddWithValue("@ISBN", ouvrage.ISBN);

                command.ExecuteNonQuery();
                
            }

            connexion.Close(); 
        }

    }

}
