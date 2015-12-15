using Lib_LocationVoiture.Model;
using Lib_LocationVoiture.Controller;
using LocationVoiture.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace LocationVoiture.Vues
{
    public partial class ReservationForm_version2 : Form
    {

        // Attributs

        private const string OPERATION_RESERVATION_CREATION = "Création";
        private const string OPERATION_RESERVATION_UPDATE = "Updater";

        private static DateTime HEURE_OUVERTURE = DateTime.Parse("08:00:00");
        private static DateTime HEURE_FERMETURE = DateTime.Parse("21:00:00");
        private static double INTERVALLE_TEMPS = 60;

        private enum columnName
        {
            [Description("VehiculeID")]
            vehiculeID,
            Fabricant,
            Modele,
            [Description("No. Plaque")]
            plate_num
        };

        // Propriétés

        private LocationController locationController { get; set; }



        public string messageToSend { get; private set; }

        // Constructeur

        public ReservationForm_version2(String operation)
        {
            InitializeComponent();

            locationController = new LocationController();

            fillTheComboBoxOpenHours();
            fillTheComboBoxSuccursale();
            disableClientField();
            lblLoading.Hide();
            panel_CarChoice.Visible = false;
            setCarFieldStatus(false);
            lblClientCreate_operation.Text = operation;

            // Selection de l'affichage
            // Création
            if (operation.Equals(OPERATION_RESERVATION_CREATION))
            {
                setFieldsVisibility(true);
                setCarFieldStatus(true);
                btnClientCreate_add.Text = ReservationForm_version2.OPERATION_RESERVATION_CREATION;
            }
            // Modification
            else
            {
                setFieldsVisibility(true);
                lblClientCreate_id.Text = "réservation :";
                btnReservationCreate_creerClient.Visible = false;
                btnClientCreate_add.Text = ReservationForm_version2.OPERATION_RESERVATION_UPDATE;
            }

        }

        // Méthodes

        #region BOUTONS

        /// <summary>
        /// Création d'une réservation à l'aide des informations inscrites dans les champs
        /// </summary>        
        private void btnClientCreate_add_Click(object sender, EventArgs e)
        {
            // Compléter la string pour l'heure IN et OUT
            String timeOUT = cbReservationCreate_HeureOUT.SelectedItem.ToString() + ":00";
            String timeIN  = cbReservationCreate_HeureIN.SelectedItem.ToString() + ":00";

            // Parse de la date et de l'heure en objet DateTime
            DateTime reservationOUT = dateTimePicker_ReservationCreate_DateOUT.Value.Date.Add(TimeSpan.Parse(timeOUT));
            DateTime reservationIN  = dateTimePicker_ReservationCreate_DateIN.Value.Date.Add(TimeSpan.Parse(timeIN));

            if (panel_CarChoice.Visible)
            {

            int clientID        = int.Parse(txtClientCreate_clientId.Text);
            int succursaleID    = int.Parse((cbReservationCreate_Succursale.SelectedItem as ComboboxItem).Value.ToString());
            int vehiculeID      = int.Parse(txtReservation_carID.Text);

            /* TODO : Valeur temporaire pour l'employé. Doit incorporer le ID de l'employée logger */
            int employeID = 1;
            /***************************************************************************************/

            // Création d'une réservation
            if (!btnClientCreate_add.Text.Equals(ReservationForm_version2.OPERATION_RESERVATION_UPDATE))
            {

                // Création de la réservation
                reservation reservationToCreate = new reservation();

                reservationToCreate.clientID                = clientID;
                reservationToCreate.succursaleID            = succursaleID;
                reservationToCreate.vehiculeID              = vehiculeID;
                reservationToCreate.date_debut_reservation  = reservationOUT;
                reservationToCreate.date_fin_reservation    = reservationIN;
                reservationToCreate.date_appel_reservation  = DateTime.Now;
                reservationToCreate.employeID               = employeID;

                if (locationController.ReservationsServices.AddReservation(reservationToCreate))
                {
                    messageToSend = "La réservation a été créée";
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
                    reservationToUpdate.succursaleID            = succursaleID;
                    reservationToUpdate.vehiculeID              = vehiculeID;
                    reservationToUpdate.date_debut_reservation  = reservationOUT;
                    reservationToUpdate.date_fin_reservation    = reservationIN;
                    reservationToUpdate.employeID               = employeID;
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
            else
            {
                MessageBox.Show("Vous devez choisir un véhicule");
            }

        }

        /// <summary>
        /// Recherche d'un client afin de modifier ses informations.
        /// Si le champ est vide, un nouveau formulaire de recherche est lancé afin de permettre la recherche à l'aide de plus de champs
        /// Sinon, la recherche est effectué à l'aide de l'id du client.
        /// </summary>        
        private void btnReservationForm_Find_Click(object sender, EventArgs e)
        {
            // recherche de client
            if (!btnClientCreate_add.Text.Equals(ReservationForm_version2.OPERATION_RESERVATION_UPDATE))
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

                    txtClientCreate_clientId.Text   = reservationClient.clientID.ToString();
                    txtClientCreate_nom.Text        = reservationClient.nom;
                    txtClientCreate_prenom.Text     = reservationClient.prenom;
                    txtClientCreate_phone.Text      = reservationClient.telephone;
                    txtClientCreate_adresse.Text    = reservationClient.adresse_client;
                    txtClientCreate_email.Text      = reservationClient.courriel;
                }
                else
                {
                    //MessageBox.Show("Aucun client n'a pu etre trouvé");
                    emptyClientFormFields();
                }
            }

            // recherche réservation
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
                    txtClientCreate_clientId.Text   = reservationToUpdate.clientID.ToString();
                    txtClientCreate_nom.Text        = reservationToUpdate.client.nom;
                    txtClientCreate_prenom.Text     = reservationToUpdate.client.prenom;
                    txtClientCreate_phone.Text      = reservationToUpdate.client.telephone;
                    txtClientCreate_adresse.Text    = reservationToUpdate.client.adresse_client;
                    txtClientCreate_email.Text      = reservationToUpdate.client.courriel;

                    string succursaleName   = reservationToUpdate.vehicule.succursale.nom;
                    string fabricantName    = reservationToUpdate.vehicule.fabriquant.nom_fabriquant;
                    string modeleName       = reservationToUpdate.vehicule.modele.nom_modele;
                    string nbPassager       = reservationToUpdate.vehicule.modele.nb_place.ToString();
                    string plateNo          = reservationToUpdate.vehicule.plaque_num;
                    string type             = reservationToUpdate.vehicule.modele.type.nom_type;

                    // VEHICULE COMBOBOX
                    cbReservationCreate_Succursale.SelectedIndex    = cbReservationCreate_Succursale.FindStringExact(succursaleName);
                    cbReservationCreate_Types.SelectedIndex         = cbReservationCreate_Types.FindStringExact(type);
                    panel_CarChoice.Visible = true;
                    txtReservation_carID.Text       = reservationToUpdate.vehiculeID.ToString();
                    txtReservation_fabriquant.Text  = fabricantName;
                    txtReservation_modele.Text      = modeleName;
                    txtReservation_plateNum.Text    = plateNo; 

                    // DATETIMEPICKER
                    dateTimePicker_ReservationCreate_DateOUT.Value  = reservationToUpdate.date_debut_reservation.Value.Date;
                    dateTimePicker_ReservationCreate_DateIN.Value   = reservationToUpdate.date_fin_reservation.Value.Date;

                    String timeOut = reservationToUpdate.date_debut_reservation.Value.TimeOfDay.ToString().Substring(0, 5);
                    String timeIn  = reservationToUpdate.date_fin_reservation.Value.TimeOfDay.ToString().Substring(0, 5);

                    // TIME COMBOBOX
                    cbReservationCreate_HeureOUT.SelectedIndex = cbReservationCreate_HeureOUT.FindStringExact(timeOut);
                    cbReservationCreate_HeureIN.SelectedIndex  = cbReservationCreate_HeureIN.FindStringExact(timeIn);
                    

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

                txtClientCreate_clientId.Text   = clientAdded.clientID.ToString();
                txtClientCreate_nom.Text        = clientAdded.nom;
                txtClientCreate_prenom.Text     = clientAdded.prenom;
                txtClientCreate_phone.Text      = clientAdded.telephone;
                txtClientCreate_adresse.Text    = clientAdded.adresse_client;
                txtClientCreate_email.Text      = clientAdded.courriel;
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
            List<vehicule> listeVehicule = new List<vehicule>();

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
        }

        /// <summary>
        /// Rempli les combobox HeureIN et HeureOUT de la réservation
        /// </summary>
        private void fillTheComboBoxOpenHours()
        {

            TimeSpan interval = TimeSpan.FromMinutes(ReservationForm_version2.INTERVALLE_TEMPS);

            for (DateTime current = ReservationForm_version2.HEURE_OUVERTURE; current <= ReservationForm_version2.HEURE_FERMETURE; current += interval)
            {
                String stringTime = current.TimeOfDay.ToString().Substring(0, 5);
                cbReservationCreate_HeureIN.Items.Add(stringTime);
                cbReservationCreate_HeureOUT.Items.Add(stringTime);
            }

            cbReservationCreate_HeureIN.SelectedIndex = 0;
            cbReservationCreate_HeureOUT.SelectedIndex = 0;
        }

        /// <summary>
        /// Lorsqu'on change l'index du comboBox des succursales
        /// </summary>
        private void cbReservationCreate_Succursale_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbReservationCreate_Types.Items.Clear();

            int succursaleID = int.Parse((cbReservationCreate_Succursale.SelectedItem as ComboboxItem).Value.ToString());

            List<type> types = locationController.TypesService.getDistinctTypes(succursaleID);

            foreach (type t in types)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = t.nom_type;
                item.Value = t.typeID;
                cbReservationCreate_Types.Items.Add(item);
            }

            if (types.Count == 0)
            {
                cbReservationCreate_Types.SelectedIndex = -1;
                cbReservationCreate_Types.Enabled = false;
                noReservationPossible();
            }
            else
            {
                cbReservationCreate_Types.SelectedIndex = 0;
                cbReservationCreate_Types.Enabled = true;
            }

        }

        /// <summary>
        /// Losrqu'on change l'index du comboBox des types de voitures
        /// </summary>
        private void cbReservationCreate_Types_SelectedIndexChanged(object sender, EventArgs e)
        {
            affichageAvailableCars();
        }

        #endregion COMBOBOX

        #region DATAGRIDVIEW

        /// <summary>
        /// Sélection de la voiture pour la réservation en double cliquant sur la DataGridView_AvailableCars
        /// </summary>
        private void dataGridView_AvailableCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!panel_CarChoice.Visible)
            {
                Animations.Animate(panel_CarChoice, Animations.Effect.Slide, 100, 360);
            }
            
            int selectedRow = dataGridView_AvailableCars.CurrentRow.Index;

            String vehiculeID = dataGridView_AvailableCars[0, selectedRow].Value.ToString();
            String fabricant = dataGridView_AvailableCars[1, selectedRow].Value.ToString();
            String modele = dataGridView_AvailableCars[2, selectedRow].Value.ToString();
            String plateNum = dataGridView_AvailableCars[3, selectedRow].Value.ToString();

            txtReservation_carID.Text = vehiculeID;
            txtReservation_fabriquant.Text = fabricant;
            txtReservation_modele.Text = modele;
            txtReservation_plateNum.Text = plateNum;
        }

        #endregion DATAGRIDVIEW

        #region UTILITAIRES

        /// <summary>
        /// Affichage d'un message dans le DataGridView qu'il n'y a aucune voiture de disponible à cette succursale ou du type choisi
        /// </summary>
        private void noReservationPossible()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Message", typeof(string));
            table.Rows.Add(
                    "Aucun véhicule disponible"
                );
            dataGridView_AvailableCars.DataSource = table;
            dataGridView_AvailableCars.ClearSelection();
            dataGridView_AvailableCars.ReadOnly = true;
            dataGridView_AvailableCars.Enabled = false;
        }

        private void disableClientField()
        {
            txtClientCreate_clientId.Enabled    = false;
            txtClientCreate_nom.Enabled         = false;
            txtClientCreate_prenom.Enabled      = false;
            txtClientCreate_phone.Enabled       = false;
            txtClientCreate_adresse.Enabled     = false;
            txtClientCreate_email.Enabled       = false;
        }

        private void setCarFieldStatus(bool status)
        {
            cbReservationCreate_Succursale.Enabled  = status;

            dateTimePicker_ReservationCreate_DateOUT.Enabled = status;
            dateTimePicker_ReservationCreate_DateIN.Enabled  = status;

            cbReservationCreate_HeureOUT.Enabled    = status;
            cbReservationCreate_HeureIN.Enabled     = status;
        }

        private void emptyClientFormFields()
        {
            txtClientCreate_clientId.Text   = "";
            txtClientCreate_idSearch.Text   = "";
            txtClientCreate_nom.Text        = "";
            txtClientCreate_prenom.Text     = "";
            txtClientCreate_phone.Text      = "";
            txtClientCreate_adresse.Text    = "";
            txtClientCreate_email.Text      = "";

            cbReservationCreate_HeureOUT.SelectedIndex = 0;
            cbReservationCreate_HeureIN.SelectedIndex  = 0;

            dateTimePicker_ReservationCreate_DateOUT.Value = DateTime.Now;
            dateTimePicker_ReservationCreate_DateIN.Value  = DateTime.Now;
        }

        private void setFieldsVisibility(bool visibilityChoice)
        {
            btnClientForm_Find.Visible          = visibilityChoice;
            txtClientCreate_idSearch.Visible    = visibilityChoice;
            txtClientCreate_clientId.Visible    = visibilityChoice;
            lblClientCreate_id.Visible          = visibilityChoice;
            panelClientForm_id.Visible          = visibilityChoice;
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
        /// Affichage dans la DataGridView des véhicules disponibles pour une location
        /// </summary>
        private void affichageAvailableCars()
        {

            // Compléter la string pour l'heure IN et OUT
            String timeOUT = cbReservationCreate_HeureOUT.SelectedItem.ToString() + ":00";
            String timeIN = cbReservationCreate_HeureIN.SelectedItem.ToString() + ":00";

            // Parse de la date et de l'heure en objet DateTime
            DateTime reservationOUT = dateTimePicker_ReservationCreate_DateOUT.Value.Date.Add(TimeSpan.Parse(timeOUT));
            DateTime reservationIN = dateTimePicker_ReservationCreate_DateIN.Value.Date.Add(TimeSpan.Parse(timeIN));

            int succursaleID = int.Parse((cbReservationCreate_Succursale.SelectedItem as ComboboxItem).Value.ToString());
            int typeID = int.Parse((cbReservationCreate_Types.SelectedItem as ComboboxItem).Value.ToString());

            List<vehicule> availableCars = new List<vehicule>();

            availableCars = locationController.VehiculeServices.AvailableCarsForReservation(reservationOUT, reservationIN, succursaleID, typeID);

            if (availableCars.Count != 0)
            {
                DataTable table = new DataTable();

                foreach (columnName enumValue in Enum.GetValues(typeof(columnName)))
                {
                    table.Columns.Add(EnumDescriptor.GetEnumDescription(enumValue), typeof(string));
                }

                foreach (vehicule veh in availableCars)
                {
                    table.Rows.Add(
                        veh.vehiculeID.ToString(),
                        veh.fabriquant.nom_fabriquant,
                        veh.modele.nom_modele,
                        veh.plaque_num
                        );
                }

                dataGridView_AvailableCars.DataSource = table;
                dataGridView_AvailableCars.ReadOnly = false;
                dataGridView_AvailableCars.Enabled = true;
            }
            else
            {
                noReservationPossible();
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            affichageAvailableCars();
        }
    }
}
