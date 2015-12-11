using LocationVoiture.Controller;
using LocationVoiture.Model;
using LocationVoiture.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LocationVoiture.Vues
{
    public partial class LocationForm : Form
    {

        // Attributs

        private const string OPERATION_LOCATION_CREATION    = "Création";
        private const string OPERATION_LOCATION_UPDATE      = "Updater";

        private static DateTime HEURE_OUVERTURE = DateTime.Parse("08:00:00");
        private static DateTime HEURE_FERMETURE = DateTime.Parse("21:00:00");
        private static double INTERVALLE_TEMPS  = 60;

        public enum columnName
        {
            [Description("Reservation ID")]
            reservationID,
            Client,
            Fabricant,
            Modele,
            Succursale
        };

        // Propriétés

        private LocationController locationController { get; set; }

        private List<vehicule> listeVehicule { get; set; }
        private List<fabriquant> listeFabriquant { get; set; }
        private List<modele> listeDesModeles { get; set; }

        public string messageToSend { get; private set; }

        // Constructeur

        public LocationForm(String operation)
        {
            InitializeComponent();

            locationController = new LocationController();

            fillTheComboBoxOpenHours();
            fillTheComboBoxSuccursale();
            fillReservationOfTheDay();
            disableClientField();
            lblLoading.Hide();
            setCarFieldStatus(false);
            lblClientCreate_operation.Text = operation;

            // Selection de l'affichage
            // Création
            if (operation.Equals(LocationForm.OPERATION_LOCATION_CREATION))
            {
                setFieldsVisibility(true);
                setCarFieldStatus(true);
                btnClientCreate_add.Text = LocationForm.OPERATION_LOCATION_CREATION;
            }
            // Modification
            else
            {
                setFieldsVisibility(true);
                lblClientCreate_id.Text = "réservation :";
                btnReservationCreate_creerClient.Visible = false;
                btnClientCreate_add.Text = LocationForm.OPERATION_LOCATION_UPDATE;
            }

        }

        private void fillReservationOfTheDay()
        {
            dateTimePicker_today.Value = DateTime.Now;
            String dateSearch = dateTimePicker_today.Value.ToShortDateString();
            MessageBox.Show(dateSearch);
            List<reservation> reservationFound = new List<reservation>();
                    
            reservationFound = locationController.ReservationsServices.FindBy(dateSearch, "dateReservation");

            // Si une ou des réservations sont trouvées
            if (reservationFound.Count > 0)
            {

                DataTable table = new DataTable();

                foreach (columnName enumValue in Enum.GetValues(typeof(columnName)))
                {
                    table.Columns.Add(EnumDescriptor.GetEnumDescription(enumValue), typeof(string));
                }

                foreach (reservation res in reservationFound)
                {
                    table.Rows.Add(
                        res.reservationID.ToString(),
                        res.client.prenom + " " + res.client.nom,
                        res.vehicule.fabriquant.nom_fabriquant,
                        res.vehicule.modele.nom_modele,
                        res.succursale.nom
                        );
                }

                dataGridView_reservation.DataSource = table;
            }
            else
            {
                DataTable table = new DataTable();
                table.Columns.Add("Message", typeof(string));
                table.Rows.Add(
                        "Aucune réservation aujourd'hui"
                    );
                dataGridView_reservation.DataSource = table;
                dataGridView_reservation.ClearSelection();                
                dataGridView_reservation.ReadOnly = true;
            }

            }

        // Méthodes

        #region BOUTONS

        /// <summary>
        /// Création d'un nouveau client à l'aide des informations inscrites dans les champs
        /// </summary>        
        private void btnClientCreate_add_Click(object sender, EventArgs e)
        {
            // Compléter la string pour l'heure IN et OUT
            String timeOUT = cbReservationCreate_HeureOUT.SelectedItem.ToString() + ":00";
            String timeIN = cbReservationCreate_HeureIN.SelectedItem.ToString() + ":00";

            // Parse de la date et de l'heure en objet DateTime
            DateTime reservationOUT = dateTimePicker_ReservationCreate_DateOUT.Value.Date.Add(TimeSpan.Parse(timeOUT));
            DateTime reservationIN = dateTimePicker_ReservationCreate_DateIN.Value.Date.Add(TimeSpan.Parse(timeIN));

            int clientID = int.Parse(txtClientCreate_clientId.Text);
            int succursaleID = ((KeyValuePair<int, string>)cbReservationCreate_Succursale.SelectedItem).Key;
            int vehiculeID = ((KeyValuePair<int, string>)cbReservationCreate_noPlaque.SelectedItem).Key;

            /* TODO : Valeur temporaire pour l'employé. Doit incorporer le ID de l'employée logger */
            int employeID = 1;
            /***************************************************************************************/

            // Création d'une réservation
            if (!btnClientCreate_add.Text.Equals(LocationForm.OPERATION_LOCATION_UPDATE))
            {

                // Création de la réservation
                reservation reservationToCreate = new reservation();

                reservationToCreate.clientID = clientID;
                reservationToCreate.succursaleID = succursaleID;
                reservationToCreate.vehiculeID = vehiculeID;
                reservationToCreate.date_debut_reservation = reservationOUT;
                reservationToCreate.date_fin_reservation = reservationIN;
                reservationToCreate.date_appel_reservation = DateTime.Now;
                reservationToCreate.employeID = employeID;

                if (locationController.ReservationsServices.AddReservation(reservationToCreate))
                {
                    messageToSend = "La réservation a été créer";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    messageToSend = "Une erreur est survenue";
                    this.DialogResult = DialogResult.No;
                    this.Close();
                }
            }

            // Update d'une réservation
            else
            {
                string reservationIdToUpdate = txtClientCreate_idSearch.Text;

                reservation reservationToUpdate = locationController.ReservationsServices.FindReservation(reservationIdToUpdate);
                if (reservationToUpdate != null)
                {
                    //reservationToUpdate.clientID                = clientID;
                    reservationToUpdate.succursaleID = succursaleID;
                    reservationToUpdate.vehiculeID = vehiculeID;
                    reservationToUpdate.date_debut_reservation = reservationOUT;
                    reservationToUpdate.date_fin_reservation = reservationIN;
                    //reservationToUpdate.date_appel_reservation  = DateTime.Now;
                    reservationToUpdate.employeID = employeID;
                }

                if (locationController.ReservationsServices.Save())
                {
                    this.DialogResult = DialogResult.OK;
                    messageToSend = "La réservation a été modifée";
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                    messageToSend = "La réservation n'a pas pu être modifée, une erreur est survenue";
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Recherche d'un client afin de modifier ses informations.
        /// Si le champ est vide, un nouveau formulaire de recherche est lancé afin de permettre la recherche à l'aide de plus de champs
        /// Sinon, la recherche est effectué à l'aide de l'id du client.
        /// </summary>        
        private void btnClientForm_Find_Click(object sender, EventArgs e)
        {
            if (!btnClientCreate_add.Text.Equals(LocationForm.OPERATION_LOCATION_UPDATE))
            {
                List<client> listeClients = new List<client>();
                String searchValue = "";

                if (txtClientCreate_idSearch.Text == "")
                {
                    this.Opacity = 0.1;
                    ClientSearch searchForm = new ClientSearch();
                    searchForm.Owner = this;
                    searchForm.ShowDialog();

                    //récupération du ID sélectionner dans le searchForm
                    searchValue = searchForm.clientSearchID;
                    this.Opacity = 1;
                }
                else
                {
                    Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
                    // le id est lu directement dans le champ
                    searchValue = txtClientCreate_idSearch.Text;
                    Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
                }


                client reservationClient = locationController.ClientsServices.Find(searchValue);

                // Affichage du client
                if (reservationClient != null)
                {
                    txtClientCreate_clientId.Enabled = false;

                    txtClientCreate_clientId.Text = reservationClient.clientID.ToString();
                    txtClientCreate_nom.Text = reservationClient.nom;
                    txtClientCreate_prenom.Text = reservationClient.prenom;
                    txtClientCreate_phone.Text = reservationClient.telephone;
                    txtClientCreate_adresse.Text = reservationClient.adresse_client;
                    txtClientCreate_email.Text = reservationClient.courriel;
                }
                else
                {
                    //MessageBox.Show("Aucun client n'a pu etre trouvé");
                    emptyClientFormFields();
                }
            }
            else
            {
                List<reservation> listeReservation = new List<reservation>();
                String searchValue = "";

                if (txtClientCreate_idSearch.Text == "")
                {
                    this.Opacity = 0.1;
                    ReservationSearch searchForm = new ReservationSearch();
                    searchForm.Owner = this;
                    panel1.Hide();
                    searchForm.ShowDialog();

                    //récupération du ID sélectionner dans le searchForm
                    searchValue = searchForm.ReservationSearchID;

                    this.Opacity = 1;
                }
                else
                {
                    Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
                    // le id est lu directement dans le champ
                    searchValue = txtClientCreate_idSearch.Text;
                    Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
                }

                panel1.Show();
                reservation reservationToUpdate = locationController.ReservationsServices.FindReservation(searchValue);

                if (reservationToUpdate != null)
                {
                    txtClientCreate_idSearch.Text = reservationToUpdate.reservationID.ToString();

                    // CLIENT TXTFIELDS
                    txtClientCreate_clientId.Text = reservationToUpdate.clientID.ToString();
                    txtClientCreate_nom.Text = reservationToUpdate.client.nom;
                    txtClientCreate_prenom.Text = reservationToUpdate.client.prenom;
                    txtClientCreate_phone.Text = reservationToUpdate.client.telephone;
                    txtClientCreate_adresse.Text = reservationToUpdate.client.adresse_client;
                    txtClientCreate_email.Text = reservationToUpdate.client.courriel;

                    string succursaleName = reservationToUpdate.vehicule.succursale.nom;
                    string fabricantName = reservationToUpdate.vehicule.fabriquant.nom_fabriquant;
                    string modeleName = reservationToUpdate.vehicule.modele.nom_modele;
                    string nbPassager = reservationToUpdate.vehicule.modele.nb_place.ToString();
                    string plateNo = reservationToUpdate.vehicule.plaque_num;

                    // VEHICULE COMBOBOX
                    cbReservationCreate_Succursale.SelectedIndex = cbReservationCreate_Succursale.FindStringExact(succursaleName);
                    cbReservationCreate_marque.SelectedIndex = cbReservationCreate_marque.FindStringExact(fabricantName);
                    cbReservationCreate_model.SelectedIndex = cbReservationCreate_model.FindStringExact(modeleName);
                    cbReservationCreate_nbPassager.SelectedIndex = cbReservationCreate_nbPassager.FindStringExact(nbPassager);
                    cbReservationCreate_noPlaque.SelectedIndex = cbReservationCreate_noPlaque.FindStringExact(plateNo);

                    // DATETIMEPICKER
                    dateTimePicker_ReservationCreate_DateOUT.Value = reservationToUpdate.date_debut_reservation.Value.Date;
                    dateTimePicker_ReservationCreate_DateIN.Value = reservationToUpdate.date_fin_reservation.Value.Date;

                    String timeOut = reservationToUpdate.date_debut_reservation.Value.TimeOfDay.ToString().Substring(0, 5);
                    String timeIn = reservationToUpdate.date_fin_reservation.Value.TimeOfDay.ToString().Substring(0, 5);

                    // TIME COMBOBOX
                    cbReservationCreate_HeureOUT.SelectedIndex = cbReservationCreate_HeureOUT.FindStringExact(timeOut);
                    cbReservationCreate_HeureIN.SelectedIndex = cbReservationCreate_HeureIN.FindStringExact(timeIn);

                    setCarFieldStatus(true);
                }
                else
                {
                    emptyClientFormFields();
                    setCarFieldStatus(false);
                }
            }
        }

        /// <summary>
        /// Création d'un nouveau client pour faire la réservation
        /// </summary>
        private void btnReservationCreate_creerClient_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm("Création");
            clientForm.Owner = this;
            this.Opacity = 0.1;

            DialogResult resultat = clientForm.ShowDialog();
            if (resultat == DialogResult.OK)
            {
                client clientAdded = clientForm.clientAdded;

                txtClientCreate_clientId.Enabled = false;

                txtClientCreate_clientId.Text = clientAdded.clientID.ToString();
                txtClientCreate_nom.Text = clientAdded.nom;
                txtClientCreate_prenom.Text = clientAdded.prenom;
                txtClientCreate_phone.Text = clientAdded.telephone;
                txtClientCreate_adresse.Text = clientAdded.adresse_client;
                txtClientCreate_email.Text = clientAdded.courriel;
            }

            this.Opacity = 1;

        }

        /// <summary>
        /// Cancel la création d'un client (fermeture du formulaire)
        /// </summary>       
        private void txtClientCreate_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BOUTONS

        #region COMBOBOX

        private void fillTheComboBoxSuccursale()
        {

            listeVehicule = new List<vehicule>();

            List<succursale> listeSuccursales = new List<succursale>();
            listeSuccursales = locationController.SuccursalesServices.getAllSuccursale();

            foreach (succursale succ in listeSuccursales)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = succ.nom;
                item.Value = succ.succursaleID;
                cbReservationCreate_Succursale.Items.Add(item);
            }

            cbReservationCreate_Succursale.SelectedIndex = 0;

            int succID = int.Parse((cbReservationCreate_Succursale.SelectedItem as ComboboxItem).Value.ToString());

            listeVehicule = locationController.VehiculeServices.GetVehiculesFromSuccursale(succID);

        }

        /// <summary>
        /// COMBOX choix de la succursale
        /// </summary>
        private void cbReservationCreate_Succursale_SelectedIndexChanged(object sender, EventArgs e)
        {

            int succID = int.Parse((cbReservationCreate_Succursale.SelectedItem as ComboboxItem).Value.ToString());

            listeFabriquant = new List<fabriquant>();
            listeFabriquant = locationController.FabricantsService.GetDistinctFabriquants(succID);

            listeVehicule = new List<vehicule>();
            listeVehicule = locationController.VehiculeServices.GetVehiculesFromSuccursale(succID);

            listeDesModeles = new List<modele>();

            // LISTE DES FABRICANTS
            cbReservationCreate_marque.Items.Clear();
            cbReservationCreate_model.Items.Clear();
            cbReservationCreate_nbPassager.Items.Clear();
            cbReservationCreate_noPlaque.Items.Clear();

            if (cbReservationCreate_Succursale.SelectedItem.ToString() != null)
            {
                foreach (fabriquant fab in listeFabriquant)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = fab.nom_fabriquant;
                    item.Value = fab.fabriquantID;
                    cbReservationCreate_marque.Items.Add(item);
                }
            }

            if (listeFabriquant.Count == 0)
            {
                cbReservationCreate_marque.Items.Clear();
                cbReservationCreate_model.Items.Clear();
                cbReservationCreate_noPlaque.Items.Clear();
                cbReservationCreate_noPlaque.ResetText();
                cbReservationCreate_noPlaque.SelectedIndex = -1;
                cbReservationCreate_marque.ResetText();
                cbReservationCreate_marque.SelectedIndex = -1;
            }
            else
            {
                cbReservationCreate_marque.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// COMBOBOX Choix du fabriquant
        /// </summary>
        private void cbReservation_marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeFabriquant.Count != 0)
            {

                int succID = int.Parse((cbReservationCreate_Succursale.SelectedItem as ComboboxItem).Value.ToString());
                int fabricantID = int.Parse((cbReservationCreate_marque.SelectedItem as ComboboxItem).Value.ToString());

                listeDesModeles = new List<modele>();
                listeDesModeles = locationController.ModelesServices.DistinctModelBySuccursaleAndFabricant(succID, fabricantID);

                // LISTE DES MODELES
                cbReservationCreate_model.Items.Clear();
                cbReservationCreate_nbPassager.Items.Clear();
                cbReservationCreate_noPlaque.Items.Clear();

                foreach (modele model in listeDesModeles)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = model.nom_modele;
                    item.Value = model.modeleID;
                    cbReservationCreate_model.Items.Add(item);
                }

                if (listeDesModeles.Count == 0)
                {
                    cbReservationCreate_model.Items.Clear();
                    cbReservationCreate_model.ResetText();
                    cbReservationCreate_model.SelectedIndex = -1;
                }
                else
                {
                    cbReservationCreate_model.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// COMBOX Choix du modele
        /// </summary>        
        private void cbReservationCreate_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbReservationCreate_nbPassager.Items.Clear();
            cbReservationCreate_noPlaque.Items.Clear();

            if (listeDesModeles.Count != 0)
            {

                int modeleID = int.Parse((cbReservationCreate_model.SelectedItem as ComboboxItem).Value.ToString());
                cbReservationCreate_nbPassager.Items.Add(locationController.ModelesServices.getNbPassager(modeleID));

                cbReservationCreate_nbPassager.SelectedIndex = 0;
            }
            else
            {
                cbReservationCreate_nbPassager.Items.Clear();
                cbReservationCreate_nbPassager.ResetText();
                cbReservationCreate_nbPassager.SelectedIndex = -1;
            }

        }

        /// <summary>
        /// COMBOBOX nombre de passager
        /// </summary>
        private void cbReservationCreate_nbPassager_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbReservationCreate_noPlaque.Items.Clear();

            if (listeDesModeles.Count != 0 && listeVehicule.Count != 0)
            {

                int modeleID = int.Parse((cbReservationCreate_model.SelectedItem as ComboboxItem).Value.ToString());
                int fabricantID = int.Parse((cbReservationCreate_marque.SelectedItem as ComboboxItem).Value.ToString());
                int succID = int.Parse((cbReservationCreate_Succursale.SelectedItem as ComboboxItem).Value.ToString());

                cbReservationCreate_noPlaque.DataSource = null;

                foreach (vehicule veh in listeVehicule)
                {

                    if (veh.modeleID == modeleID && veh.fabriquantID == fabricantID && veh.succursaleID == succID)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = veh.plaque_num;
                        item.Value = veh.vehiculeID;
                        cbReservationCreate_noPlaque.Items.Add(item);
                    }
                }

                cbReservationCreate_noPlaque.SelectedIndex = 0;
            }
            else
            {
                cbReservationCreate_noPlaque.Items.Clear();
                cbReservationCreate_noPlaque.ResetText();
                cbReservationCreate_noPlaque.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Rempli les combobox HeureIN et HeureOUT de la réservation
        /// </summary>
        private void fillTheComboBoxOpenHours()
        {

            TimeSpan interval = TimeSpan.FromMinutes(LocationForm.INTERVALLE_TEMPS);

            for (DateTime current = LocationForm.HEURE_OUVERTURE; current <= LocationForm.HEURE_FERMETURE; current += interval)
            {
                String stringTime = current.TimeOfDay.ToString().Substring(0, 5);
                cbReservationCreate_HeureIN.Items.Add(stringTime);
                cbReservationCreate_HeureOUT.Items.Add(stringTime);
            }

            cbReservationCreate_HeureIN.SelectedIndex = 0;
            cbReservationCreate_HeureOUT.SelectedIndex = 0;
        }

        #endregion COMBOBOX

        #region UTILITAIRES

        private void disableClientField()
        {
            txtClientCreate_clientId.Enabled = false;
            txtClientCreate_nom.Enabled = false;
            txtClientCreate_prenom.Enabled = false;
            txtClientCreate_phone.Enabled = false;
            txtClientCreate_adresse.Enabled = false;
            txtClientCreate_email.Enabled = false;
        }

        private void setCarFieldStatus(bool status)
        {
            cbReservationCreate_Succursale.Enabled = status;
            cbReservationCreate_marque.Enabled = status;
            cbReservationCreate_model.Enabled = status;
            cbReservationCreate_nbPassager.Enabled = status;
            cbReservationCreate_noPlaque.Enabled = status;

            dateTimePicker_ReservationCreate_DateOUT.Enabled = status;
            dateTimePicker_ReservationCreate_DateIN.Enabled = status;

            cbReservationCreate_HeureOUT.Enabled = status;
            cbReservationCreate_HeureIN.Enabled = status;
        }

        private void emptyClientFormFields()
        {
            txtClientCreate_clientId.Text = "";
            txtClientCreate_idSearch.Text = "";
            txtClientCreate_nom.Text = "";
            txtClientCreate_prenom.Text = "";
            txtClientCreate_phone.Text = "";
            txtClientCreate_adresse.Text = "";
            txtClientCreate_email.Text = "";

            cbReservationCreate_HeureOUT.SelectedIndex = 0;
            cbReservationCreate_HeureIN.SelectedIndex = 0;

            dateTimePicker_ReservationCreate_DateOUT.Value = DateTime.Now;
            dateTimePicker_ReservationCreate_DateIN.Value = DateTime.Now;
        }

        private void setFieldsVisibility(bool visibilityChoice)
        {
            btnClientForm_Find.Visible = visibilityChoice;
            txtClientCreate_idSearch.Visible = visibilityChoice;
            txtClientCreate_clientId.Visible = visibilityChoice;
            lblClientCreate_id.Visible = visibilityChoice;
            panelClientForm_id.Visible = visibilityChoice;
        }

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

        #endregion UTILITAIRES

        /// <summary>
        /// Selection de la réservation de la liste, et affichage des informations
        /// </summary>
        private void dataGridView_reservation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedRow = dataGridView_reservation.CurrentRow.Index;
            object selectedRowID = dataGridView_reservation[0, selectedRow].Value;
            String reservationID = selectedRowID.ToString();

            reservation reservationToLocation = locationController.ReservationsServices.FindReservation(reservationID);

            if(reservationToLocation != null)
            {            
                txtClientCreate_idSearch.Text = reservationToLocation.reservationID.ToString();

                // CLIENT TXTFIELDS
                txtClientCreate_clientId.Text   = reservationToLocation.clientID.ToString();
                txtClientCreate_nom.Text        = reservationToLocation.client.nom;
                txtClientCreate_prenom.Text     = reservationToLocation.client.prenom;
                txtClientCreate_phone.Text      = reservationToLocation.client.telephone;
                txtClientCreate_adresse.Text    = reservationToLocation.client.adresse_client;
                txtClientCreate_email.Text      = reservationToLocation.client.courriel;

                string succursaleName   = reservationToLocation.vehicule.succursale.nom;
                string fabricantName    = reservationToLocation.vehicule.fabriquant.nom_fabriquant;
                string modeleName       = reservationToLocation.vehicule.modele.nom_modele;
                string nbPassager       = reservationToLocation.vehicule.modele.nb_place.ToString();
                string plateNo          = reservationToLocation.vehicule.plaque_num;

                // VEHICULE COMBOBOX
                cbReservationCreate_Succursale.SelectedIndex    = cbReservationCreate_Succursale.FindStringExact(succursaleName);
                cbReservationCreate_marque.SelectedIndex        = cbReservationCreate_marque.FindStringExact(fabricantName);
                cbReservationCreate_model.SelectedIndex         = cbReservationCreate_model.FindStringExact(modeleName);
                cbReservationCreate_nbPassager.SelectedIndex    = cbReservationCreate_nbPassager.FindStringExact(nbPassager);
                cbReservationCreate_noPlaque.SelectedIndex      = cbReservationCreate_noPlaque.FindStringExact(plateNo);

                // DATETIMEPICKER
                dateTimePicker_ReservationCreate_DateOUT.Value = reservationToLocation.date_debut_reservation.Value.Date;
                dateTimePicker_ReservationCreate_DateIN.Value  = reservationToLocation.date_fin_reservation.Value.Date;

                String timeOut = reservationToLocation.date_debut_reservation.Value.TimeOfDay.ToString().Substring(0, 5);
                String timeIn  = reservationToLocation.date_fin_reservation.Value.TimeOfDay.ToString().Substring(0, 5);

                // TIME COMBOBOX
                cbReservationCreate_HeureOUT.SelectedIndex = cbReservationCreate_HeureOUT.FindStringExact(timeOut);
                cbReservationCreate_HeureIN.SelectedIndex  = cbReservationCreate_HeureIN.FindStringExact(timeIn);

            }

        }
    }
}
