using Devoir_Librairy_v2.DAO;
using Devoir_Librairy_v2.DB;
using Devoir_Librairy_v2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Devoir_Librairy_v2
{
    public partial class Commande : System.Web.UI.Page
    {

        private Connexion connection { get; set; }
        private OuvrageDAO ouvrageDAO { get; set; }
        private Cart cart { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new Connexion();
            ouvrageDAO = new OuvrageDAO(connection);

            cart = (Cart) System.Web.HttpContext.Current.Session["panier"];

            CartView.DataSource = cart.CartClient;
            CartView.DataBind();

            orderTotalPrice.Text = cart.getTotal() + " $";

        }

        /// <summary>
        /// Placer la commande (création d'un client et d'une commande)
        /// </summary>        
        protected void btnOrder_Click(object sender, EventArgs e)
        {
            // read the fields
            string prenom = txtPrenom.Text;
            string nom = txtNom.Text;
            string adresse = txtAdresse.Text;
            string postalCode = txtCodePostal.Text;
            string courriel = txtCouriel.Text;

            float totalBill = cart.getTotal();

            // création du client
            Client client = new Client();
            client.Nom = nom;
            client.Prenom = prenom;
            client.Adresse = adresse;
            client.CodePostal = postalCode;
            client.Courriel = courriel;

            // ajouter le client
            ClientDAO clientDAO = new ClientDAO(connection);
            clientDAO.InscrireClient(client);

            // récupération de son ID
            Client clientAdded = clientDAO.Get(client.Nom, client.Prenom); 

            if(clientAdded.IdClient != 0)
            {
                // création de la commande
                CommandeDTO commandeDTO = new CommandeDTO();
                commandeDTO.IdClient = clientAdded.IdClient;
                commandeDTO.Ouvrages = cart.CartClient;

                // add
                CommandeDAO commandeDAO = new CommandeDAO(connection);
                commandeDAO.InscrireCommande(commandeDTO);
            }

            // redirection
            Response.Redirect("Completed.aspx", false);
        }

    }
}
