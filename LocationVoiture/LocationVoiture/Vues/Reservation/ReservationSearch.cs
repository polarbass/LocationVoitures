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
    public partial class ReservationSearch : Form
    {

        private LocationController locationController { get; set; }
        public String ReservationSearchID { get; private set; }

        private enum findByParameter { reservationID, clientID, employeID, succursaleID, dateReservation };

        private enum columnName
        {
            [Description("Reservation ID")]
            reservationID,
            [Description("ClientID")]
            clientID,
            Client,
            Fabricant,
            Modele,
            Succursale,
            [Description("Date Début")]
            DateOUT,
            [Description("Date fin")]
            DateIN
        };

        private int RightTimeOut = 0;

        public ReservationSearch()
        {
            InitializeComponent();

            locationController = new LocationController();

            btnReservationSearch_select.Enabled = false;
            panel_message.Hide();
            lblLoading.Hide();

            // FadeIn FadeOut pour l'affichage des messages
            animationTimer.Tick += animationTimer_tick;

            // Paramètre de recherche disponible
            foreach (findByParameter parameter in Enum.GetValues(typeof(findByParameter)))
            {
                comboReservationSearch_FindBy.Items.Add(parameter);
            }

            comboReservationSearch_FindBy.SelectedIndex = 0;

        }

        #region BOUTONS

        /// <summary>
        /// Recherche succursale(s)
        /// </summary>
        private void btnReservationSearch_find_Click(object sender, EventArgs e)
        {
            String searchValue = txtReservationSearch_value.Text;
            String comboChoice = comboReservationSearch_FindBy.SelectedItem.ToString();
            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
            List<reservation> reservationFound = new List<reservation>();

            switch (comboChoice)
            {
                case "reservationID":
                    reservationFound = locationController.ReservationsServices.FindBy(searchValue, findByParameter.reservationID.ToString());
                    break;
                case "clientID":
                    reservationFound = locationController.ReservationsServices.FindBy(searchValue, findByParameter.clientID.ToString());
                    break;
                case "employeID":
                    reservationFound = locationController.ReservationsServices.FindBy(searchValue, findByParameter.employeID.ToString());
                    break;
                case "succursaleID":
                    reservationFound = locationController.ReservationsServices.FindBy(searchValue, findByParameter.succursaleID.ToString());
                    break;
                case "dateReservation":
                    String dateSearch = dateTimePicker.Value.ToShortDateString();
                    reservationFound = locationController.ReservationsServices.FindBy(dateSearch, findByParameter.dateReservation.ToString());
                    break;
            }

            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

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
                        res.clientID.ToString(),
                        res.client.prenom + " " + res.client.nom,
                        res.vehicule.fabriquant.nom_fabriquant,
                        res.vehicule.modele.nom_modele,
                        res.succursale.nom,
                        res.date_debut_reservation.ToString(),
                        res.date_fin_reservation.ToString()
                        );
                }

                dataGridView1.DataSource = table;
                btnReservationSearch_select.Enabled = true;

            }
            else
            {
                Animations.Animate(panel_message, Animations.Effect.Roll, 100, 180);
                animationTimer.Start();
                dataGridView1.DataSource = null;
                btnReservationSearch_select.Enabled = false;
            }

        }

        /// <summary>
        /// Fermer la recherche
        /// </summary>
        private void btnClientSearch_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Selection de la réservation
        /// </summary>
        private void btnReservationSearch_select_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentRow.Index;
            object selectedRowID = dataGridView1[0, selectedRow].Value;
            String reservationID = selectedRowID.ToString();

            ReservationSearchID = reservationID;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion BOUTONS

        #region COMBOBOX

        /// <summary>
        /// Affiche le datepicker si le choix du paramètre de recherche est par date de réservation
        /// </summary>
        private void comboReservationSearch_FindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboReservationSearch_FindBy.SelectedItem.Equals(findByParameter.dateReservation))
            {
                txtReservationSearch_value.Text = "";
                txtReservationSearch_value.Enabled = false;
                dateTimePicker.Show();
            }
            else
            {
                txtReservationSearch_value.Enabled = true;
                dateTimePicker.Hide();
            }
        }

        #endregion COMBOBOX

        #region UTILITAIRES

        /// <summary>
        /// Durée des animations
        /// </summary>
        private void animationTimer_tick(object sender, EventArgs e)
        {
            if (RightTimeOut < 1)
            {
                RightTimeOut++;
            }

            if (RightTimeOut == 1)
            {
                Animations.Animate(panel_message, Animations.Effect.Roll, 100, 180);
                RightTimeOut = 0;
                animationTimer.Stop();
            }

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
        
    }

}
