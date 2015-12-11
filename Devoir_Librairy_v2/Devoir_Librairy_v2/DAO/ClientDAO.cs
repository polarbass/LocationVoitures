using Devoir_Librairy_v2.DB;
using Devoir_Librairy_v2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Devoir_Librairy_v2.DAO
{
    public class ClientDAO
    {
        private Connexion connexion { get; set; }

        public ClientDAO(Connexion cnn)
        {
            connexion = cnn;
        }

        /// <summary>
        /// ADD CLIENT
        /// </summary>
        /// <param name="client">Le client à ajouter</param>
        public void InscrireClient(Client client)
        {

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand();

            connexion.Open();

            command.Connection = connexion.cnn;

            command.CommandText = "INSERT INTO Clients (nom, prenom, adresse, cp, email) VALUES (@nom, @prenom, @adresse, @cp, @email)";
            command.Parameters.AddWithValue("@nom", client.Nom);
            command.Parameters.AddWithValue("@prenom", client.Prenom);
            command.Parameters.AddWithValue("@adresse", client.Adresse);
            command.Parameters.AddWithValue("@cp", client.CodePostal);
            command.Parameters.AddWithValue("@email", client.Courriel);

            command.ExecuteNonQuery();

            connexion.Close();

        }

        /// <summary>
        /// GET Client
        /// </summary>
        /// <param name="nom">Nom recherché</param>
        /// <param name="prenom">Prénom recherché</param>
        /// <returns></returns>
        public Client Get(string nom, string prenom)
        {

            Client client = null;

            try
            {
                connexion.Open();

                DbCommand cmnd = connexion.CreateCommand();
                cmnd.CommandType = CommandType.Text;

                cmnd.CommandText = "Select ID, nom, prenom, adresse, cp, email FROM Clients WHERE Clients.nom = @nom AND Clients.prenom = @prenom";

                DbParameter param1 = cmnd.CreateParameter();
                param1.ParameterName = "@nom";
                param1.Value = nom;
                cmnd.Parameters.Add(param1);

                DbParameter param2 = cmnd.CreateParameter();
                param2.ParameterName = "@prenom";
                param2.Value = prenom;
                cmnd.Parameters.Add(param2);

                DbDataReader dr = cmnd.ExecuteReader();

                while (dr.Read())
                {
                    string id = dr[0].ToString();
                    string name = dr[1].ToString();
                    string prename = dr[2].ToString();
                    string adresse = dr[3].ToString();
                    string cp = dr[4].ToString();
                    string email = dr[5].ToString();


                    Client c = new Client();

                    c.IdClient = int.Parse(id);
                    c.Nom = name;
                    c.Prenom = prename;
                    c.Adresse = adresse;
                    c.CodePostal = cp;
                    c.Courriel = email;

                    client = c;
                }

                connexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in the GetAll ! ");
            }
            return client;

        }
    }
}