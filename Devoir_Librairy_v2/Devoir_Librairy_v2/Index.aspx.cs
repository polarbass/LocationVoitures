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
    public partial class Index : System.Web.UI.Page
    {

        private Connexion connection { get; set; }
        private OuvrageDAO ouvrageDAO { get; set; }

        private Cart panier { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new Connexion();
            ouvrageDAO = new OuvrageDAO(connection);            

            // création du panier
            if (Session.IsNewSession)
            {
                panier = new Cart();
                System.Web.HttpContext.Current.Session["panier"] = panier;
            }

            // affichage des ouvrages
            if (!IsPostBack)
            {
                GridView1.DataSource = ouvrageDAO.getAll();
                GridView1.DataBind();
            }
        }

        /// <summary>
        /// Rechercher un ouvrage : Valeur inscrite, titre ou auteur et catégorie
        /// </summary>
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string searchVal = searchValue.Text;
            string searchBy = comboSearchBy.SelectedItem.Text;
            int label = int.Parse(comboCategorie.SelectedValue);            

            // affichage des ouvrages correspondant
            GridView1.DataSource = ouvrageDAO.FindByUserInput(searchVal, searchBy, label);
            GridView1.DataBind();
        }

        /// <summary>
        /// Recherche par catégorie
        /// </summary>
        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string cat = e.Item.Value;
            int categorieInt = int.Parse(cat.Substring(cat.Length - 1));

            GridView1.DataSource = ouvrageDAO.FindByCategorie(categorieInt);
            GridView1.DataBind();
        }

        /// <summary>
        /// Ajouter un livre dans le panier
        /// </summary>
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow selectedRow = GridView1.Rows[index];

                TableCell ISBN  = selectedRow.Cells[0];
                TableCell Titre = selectedRow.Cells[1];
                TableCell Prix  = selectedRow.Cells[3];

                // trouve l'ouvrage selon le ISBN récupéré
                Ouvrage o = ouvrageDAO.Get(ISBN.Text);

                // ajoute celui-ci au panier
                Cart cart = (Cart)System.Web.HttpContext.Current.Session["panier"];
                cart.addOuvrage(o, 1);

                // affichage
                CartView.DataSource = cart.CartClient;
                CartView.DataBind();

                orderTotalPrice.Text = cart.getTotal() + " $";

            }
        }

        /// <summary>
        /// Retire un ouvrage du panier
        /// </summary>
        protected void CartView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Supprimer")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow selectedRow = CartView.Rows[index];
                TableCell ISBN = selectedRow.Cells[0];
                TableCell Titre = selectedRow.Cells[1];
                TableCell Prix = selectedRow.Cells[2];

                // l'ouvrage à retirer
                Ouvrage o = new Ouvrage();
                o.ISBN = ISBN.Text;
                o.Titre = Titre.Text;
                o.Prix = float.Parse(Prix.Text);

                // remove
                Cart cart = (Cart)System.Web.HttpContext.Current.Session["panier"];
                cart.removeProduct(o.ISBN);

                // affichage
                CartView.DataSource = cart.CartClient;
                CartView.DataBind();

                orderTotalPrice.Text = cart.getTotal() + " $";

            }
        }

        /// <summary>
        /// Bouton commande
        /// </summary>
        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("panier.aspx");
        }
    }
}