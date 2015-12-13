using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lib_LocationVoiture;
using LocationVoiture.Controller;
using Lib_LocationVoiture.Model;

namespace Web_LocationVoitures.Web
{
    public partial class Index : System.Web.UI.Page
    {
        LocationController controlleur { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            controlleur = new LocationController();

            List<client> clients = new List<client>();

            clients = controlleur.ClientsServices.GetAllClients();

            GridView1.DataSource = clients;
            GridView1.DataBind();
        }
    }
}