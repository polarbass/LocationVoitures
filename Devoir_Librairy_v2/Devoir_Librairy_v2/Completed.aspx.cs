using Devoir_Librairy_v2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Devoir_Librairy_v2
{
    public partial class Completed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Vide le panier et redirige vers l'index
        /// </summary>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Cart cart = (Cart)System.Web.HttpContext.Current.Session["panier"];
            cart.eraseCart();
            Response.Redirect("index.aspx");
        }
    }
}