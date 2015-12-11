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
    public partial class panier : System.Web.UI.Page
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
        /// Bouton recherche : La valeur inscrite, le combo titre ou auteur et la catégorie
        /// </summary>       
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string searchVal = searchValue.Text;
            string searchBy = comboSearchBy.SelectedItem.Text;
            int label = int.Parse(comboCategorie.SelectedValue);
        }


        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string cat = e.Item.Value;
            int categorieInt = int.Parse(cat.Substring(cat.Length - 1));
        }

        /// <summary>
        /// Bouton supprimer qui retire un ouvrage du panier
        /// </summary>
        protected void CartView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Supprimer")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                // récupération des valeur du Cartview
                GridViewRow selectedRow = CartView.Rows[index];
                TableCell ISBN          = selectedRow.Cells[0];
                TableCell Titre         = selectedRow.Cells[1];
                TableCell Prix          = selectedRow.Cells[2];

                Ouvrage o   = new Ouvrage();
                o.ISBN      = ISBN.Text;
                o.Titre     = Titre.Text;
                o.Prix      = float.Parse(Prix.Text);

                Cart cart   = (Cart)System.Web.HttpContext.Current.Session["panier"];
                cart.removeProduct(o.ISBN);

                // affichage du panier
                CartView.DataSource = cart.CartClient;
                CartView.DataBind();

                // affichage du résultat
                orderTotalPrice.Text = cart.getTotal() + " $";

            }
        }

        /// <summary>
        /// Bouton commander : redirection vers la page commande
        /// </summary>
        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("commande.aspx");
        }

    }
}
