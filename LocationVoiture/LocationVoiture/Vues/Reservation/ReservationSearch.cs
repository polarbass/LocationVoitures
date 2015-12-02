using LocationVoiture.Controller;
using LocationVoiture.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace LocationVoiture.Vues
{
    public partial class ReservationSearch : Form
    {

        private LocationController locationController { get; set; }        
        public String ReservationSearchID { get; private set; }

        private enum findByParameter { reservationID, clientID, employeID, succursaleID, dateReservation };
        public enum columnName
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

        public ReservationSearch()
        {
            InitializeComponent();

            locationController = new LocationController();

            btnReservationSearch_select.Enabled = false;

            // Paramètre de recherche disponible
            foreach (findByParameter parameter in Enum.GetValues(typeof(findByParameter)))
            {
                comboReservationSearch_FindBy.Items.Add(parameter);
            }

            comboReservationSearch_FindBy.SelectedIndex = 0;

        }

        /// <summary>
        /// SEARCH
        /// </summary>
        private void btnClientSearch_find_Click(object sender, EventArgs e)
        {
            String searchValue = txtReservationSearch_value.Text;
            String comboChoice = comboReservationSearch_FindBy.SelectedItem.ToString();
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

            // Si une ou des réservations sont trouvées
            if (reservationFound.Count > 0)
            {

                DataTable table = new DataTable();

                foreach (columnName enumValue in Enum.GetValues(typeof(columnName)))
                {                   
                    table.Columns.Add(GetEnumDescription(enumValue), typeof(string));
                }

                    //table.Columns.Add("Reservation ID", typeof(int));
                    //table.Columns.Add("Client ID", typeof(int));
                    //table.Columns.Add("Client", typeof(string));
                    //table.Columns.Add("Fabricant", typeof(string));
                    //table.Columns.Add("Modele", typeof(string));
                    //table.Columns.Add("Location", typeof(string));
                    //table.Columns.Add("Date Début", typeof(DateTime));
                    //table.Columns.Add("Date Fin", typeof(DateTime));

                foreach(reservation res in reservationFound)
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
                MessageBox.Show("Aucune réservation n'a pu être trouvée");
                dataGridView1.DataSource = null;
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
        /// Selection du client
        /// </summary>
        private void btnClientSearch_select_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentRow.Index;
            object selectedRowID = dataGridView1[0, selectedRow].Value;
            String reservationID = selectedRowID.ToString();

            ReservationSearchID = reservationID;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboReservationSearch_FindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboReservationSearch_FindBy.SelectedItem.Equals(findByParameter.dateReservation))
            {
                dateTimePicker.Show();
            }
            else
            {
                dateTimePicker.Hide();
            }
        }

        #region UTILITAIRES

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        #endregion UTILITAIRES

    }
}
