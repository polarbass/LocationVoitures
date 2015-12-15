using Lib_LocationVoiture.Model;
using Lib_LocationVoiture.Controller;
using LocationVoiture.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LocationVoiture.Vues
{
    public partial class LocationFacture : Form
    {

        // Propriétés

        private LocationController locationController { get; set; }

        private string clientID { get; set; }
        private string vehiculeID { get; set; }

        // Constructeur

        public LocationFacture(string idClient, string idVehicule)
        {
            InitializeComponent();

            locationController = new LocationController();
            clientID = idClient;
            vehiculeID = idVehicule;

            fillTheTxtFields();
        }

        private void fillTheTxtFields()
        {
            client clientFacture = locationController.ClientsServices.Find(clientID);

            txtFacture_nom.Text         = clientFacture.prenom + " " + clientFacture.nom;
            txtFacture_telephone.Text   = clientFacture.telephone;
            txtFacture_adresse.Text     = clientFacture.adresse_client;

            vehicule vehiculeFacture = locationController.VehiculeServices.FindVehicule(vehiculeID);

            txtFacture_car.Text         = vehiculeFacture.fabriquant.nom_fabriquant + " " + vehiculeFacture.modele.nom_modele;
            txtFacture_categorie.Text   = vehiculeFacture.modele.type.nom_type;
            txtFacture_plaqueNum.Text   = vehiculeFacture.plaque_num;

            txtFacture_succursale.Text  = vehiculeFacture.succursale.nom;
            txtFacture_date.Text        = DateTime.Now.ToShortDateString();

            float commissionValue = vehiculeFacture.modele.type.commission;
            double taxesValue = locationController.LocationsService.GetTaxesValue() * commissionValue;

            txtFacture_comission.Text = commissionValue.ToString();
            txtFacture_taxe.Text = (taxesValue * commissionValue) + " $";
            txtFacture_total.Text = taxesValue + commissionValue + " $";
        }


        #region UTILITAIRES

        private void disableClientField()
        {
            txtFacture_nom.Enabled          = false;
            txtFacture_telephone.Enabled    = false;
            txtFacture_adresse.Enabled      = false;

            txtFacture_car.Enabled          = false;
            txtFacture_categorie.Enabled    = false;
            txtFacture_plaqueNum.Enabled    = false;

            txtFacture_succursale.Enabled   = false;
            txtFacture_date.Enabled         = false;

            txtFacture_comission.Enabled    = false;
            txtFacture_taxe.Enabled         = false;
            txtFacture_total.Enabled        = false;
        }

        private void emptyFormFields()
        {
            txtFacture_nom.Text         = "";
            txtFacture_telephone.Text   = "";
            txtFacture_adresse.Text     = "";

            txtFacture_car.Text         = "";
            txtFacture_categorie.Text   = "";
            txtFacture_plaqueNum.Text   = "";

            txtFacture_succursale.Text  = "";
            txtFacture_date.Text        = "";

            txtFacture_comission.Text   = "";
            txtFacture_taxe.Text        = "";
            txtFacture_total.Text       = "";
        }

        #endregion UTILITAIRES

        #region EVENTS

        private void mouseEnterEventHandler(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.White;
            button.ForeColor = Color.Teal;
        }

        private void mouseLeaveEventHandler(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Teal;
            button.ForeColor = Color.WhiteSmoke;
        }

        #endregion EVENTS

        private void btnFacture_Completer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
