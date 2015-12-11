using Devoir_Librairy_v2.DB;
using Devoir_Librairy_v2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Devoir_Librairy_v2.DAO
{
    public class OuvrageDAO
    {

        private Connexion connexion { get; set; }

        public OuvrageDAO(Connexion cnn)
        {
            connexion = cnn;
        }

        /// <summary>
        /// Recherche d'un ouvrage selon son ISBN
        /// </summary>
        /// <param name="isbn">Le ISBN recherché</param>
        /// <returns>Un ouvrage : null sinon</returns>
        public Ouvrage Get(string isbn)
        {

            Ouvrage ouvrage = null;

            try
            {
                connexion.Open();

                DbCommand cmnd = connexion.CreateCommand();
                cmnd.CommandType = CommandType.Text;

                cmnd.CommandText = "Select * FROM Ouvrages WHERE Ouvrages.ISBN = @ISBN";


                DbParameter param = cmnd.CreateParameter();
                param.ParameterName = "@ISBN";
                param.Value = isbn;
                cmnd.Parameters.Add(param);

                DbDataReader dr = cmnd.ExecuteReader();

                while (dr.Read())
                {
                    string ISBN     = dr[0].ToString();
                    string titre    = dr[1].ToString();
                    string Auteur   = dr[2].ToString();
                    int categorie   = int.Parse(dr[3].ToString());
                    float prix      = float.Parse(dr[4].ToString());
                    DateTime date   = Convert.ToDateTime(dr[6]);
                    int nbPage      = int.Parse(dr[7].ToString());

                    Ouvrage o = new Ouvrage();

                    o.ISBN      = ISBN;
                    o.Titre     = titre;
                    o.Auteur    = Auteur;
                    o.categorie = categorie;
                    o.Prix      = prix;
                    o.Date      = date.ToShortDateString();
                    o.NbPages   = nbPage;

                    ouvrage = o;
                }

                connexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in the GetAll ! ");
            } 
            return ouvrage;
        }

        /// <summary>
        /// Get all ouvrages
        /// </summary>
        /// <returns>List d'ouvrages</returns>
        public List<Ouvrage> getAll()
        {

            List<Ouvrage> listeOuvrages = new List<Ouvrage>();

            try
            {
                connexion.Open();

                DbCommand cmnd = connexion.CreateCommand();
                cmnd.CommandType = CommandType.Text;
                cmnd.CommandText = "Select * from Ouvrages";

                DbDataReader dr = cmnd.ExecuteReader();

                while (dr.Read())
                {
                    string ISBN = dr[0].ToString();
                    string titre = dr[1].ToString();
                    string Auteur = dr[2].ToString();
                    int categorie = int.Parse(dr[3].ToString());
                    float prix = float.Parse(dr[4].ToString());
                    DateTime date = Convert.ToDateTime(dr[6]);
                    int nbPage = int.Parse(dr[7].ToString());

                    Ouvrage o = new Ouvrage();

                    o.ISBN = ISBN;
                    o.Titre = titre;
                    o.Auteur = Auteur;
                    o.categorie = categorie;
                    o.Prix = prix;
                    o.Date = date.ToShortDateString();
                    o.NbPages = nbPage;

                    listeOuvrages.Add(o);
                }

                connexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in the GetAll ! ");
            }

            return listeOuvrages;
        }
        
        /// <summary>
        /// Recherche des livres par catégorie
        /// </summary>
        /// <param name="categorieNumber">Le numéro de la catégorie</param>
        /// <returns>Une liste d'ouvrage : liste vide sinon</returns>
        public List<Ouvrage> FindByCategorie(int categorieNumber)
        {

            List<Ouvrage> listeOuvrages = new List<Ouvrage>();

            try
            {
                connexion.Open();

                DbCommand cmnd = connexion.CreateCommand();
                cmnd.CommandType = CommandType.Text;
                cmnd.CommandText = "Select * from Ouvrages WHERE Ouvrages.Catégorie = @categorie";

                DbParameter param = cmnd.CreateParameter();
                param.ParameterName = "@categorie";
                param.Value = categorieNumber;
                cmnd.Parameters.Add(param);

                DbDataReader dr = cmnd.ExecuteReader();

                while (dr.Read())
                {
                    string ISBN = dr[0].ToString();
                    string titre = dr[1].ToString();
                    string Auteur = dr[2].ToString();
                    int categorie = int.Parse(dr[3].ToString());
                    float prix = float.Parse(dr[4].ToString());
                    DateTime date = Convert.ToDateTime(dr[6]);
                    int nbPage = int.Parse(dr[7].ToString());

                    Ouvrage o = new Ouvrage();

                    o.ISBN = ISBN;
                    o.Titre = titre;
                    o.Auteur = Auteur;
                    o.categorie = categorie;
                    o.Prix = prix;
                    o.Date = date.ToShortDateString();
                    o.NbPages = nbPage;

                    listeOuvrages.Add(o);
                }


                Console.WriteLine("Connection Open ! ");
                connexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }

            return listeOuvrages;
        }
   
        /// <summary>
        /// Recherche d'ouvrages selons les informations inscrites par l'utilisateur
        /// </summary>
        /// <param name="searchValue">La valeur inscrite dans le textbox</param>
        /// <param name="searchBy">Le paramètre de recherche (Auteur ou titre)</param>
        /// <param name="categorieNumber">Le numéro de la catégorie</param>
        /// <returns>Une liste d'ouvrages ; une liste vide sinon</returns>
        public List<Ouvrage> FindByUserInput(string searchValue, string searchBy, int categorieNumber)
        {

            List<Ouvrage> listeOuvrages = new List<Ouvrage>();
 
                connexion.Open();

                DbCommand cmnd = connexion.CreateCommand();
                cmnd.CommandType = CommandType.Text;

                if (searchBy.Equals("Titre"))
                {
                    cmnd.CommandText = "Select * FROM Ouvrages WHERE Ouvrages.Catégorie = @categorie AND Ouvrages.Titre Like @searchValue";
                }
                else
                {
                    cmnd.CommandText = "Select * FROM Ouvrages WHERE Ouvrages.Catégorie = @categorie AND Ouvrages.Auteur Like @searchValue";
                }

                DbParameter param1 = cmnd.CreateParameter();
                param1.ParameterName = "@categorie";
                param1.Value = categorieNumber;
                cmnd.Parameters.Add(param1);

                DbParameter param2 = cmnd.CreateParameter();
                param2.ParameterName = "@searchValue";
                param2.Value = "%" +  searchValue.ToLower() + "%";
                cmnd.Parameters.Add(param2);

                DbDataReader dr = cmnd.ExecuteReader();

                while (dr.Read())
                {
                    string ISBN = dr[0].ToString();
                    string titre = dr[1].ToString();
                    string Auteur = dr[2].ToString();
                    int categorie = int.Parse(dr[3].ToString());
                    float prix = float.Parse(dr[4].ToString());
                    DateTime date = Convert.ToDateTime(dr[6]);
                    int nbPage = int.Parse(dr[7].ToString());

                    Ouvrage o = new Ouvrage();

                    o.ISBN = ISBN;
                    o.Titre = titre;
                    o.Auteur = Auteur;
                    o.categorie = categorie;
                    o.Prix = prix;
                    o.Date = date.ToShortDateString();
                    o.NbPages = nbPage;

                    listeOuvrages.Add(o);
                }


                Console.WriteLine("Connection Open ! ");
                connexion.Close();


            return listeOuvrages;
        }
    }
}
