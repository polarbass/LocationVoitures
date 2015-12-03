﻿    using LocationVoiture.Model;
    using LocationVoiture.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace LocationVoiture.Vues
    {
    public partial class MainForm : Form
    {

        // push test
        int RightTimeOut = 0;

        private VehiculeServices vehiculeServices { get; set; }

        private static string OPERATION_CLIENT_CREATION = "Création";
        private static string OPERATION_CLIENT_MODIFICATION = "Modification";

        public MainForm()
        {
            InitializeComponent();
            showDate();

            // Affichage de l'heure
            timerMainForm_clock.Tick += new EventHandler(tmr_Tick);
            timerMainForm_clock.Start();

            // FadeIn FadeOut pour l'affichage des messages
            timerMainForm_MessagesAnimations.Tick += new EventHandler(tmr2_Tick);

            // Loading du Form de Login
            loadLogin();

            panel_Messages.Hide();    

        }

        private void loadLogin()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Owner = this;

            DialogResult dialogResult = loginForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                panel_DefaultOperations.Hide();
                panel_LeftRow.Show();
                panel_operation.Show();
                lblMainForm_activeUser.Text = loginForm.username;
            }
            else
            {
                panel_DefaultOperations.Show();
                panel_operation.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loadLogin();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*******************************************************************
                                    RESERVATIONS
        *******************************************************************/

        #region RESERVATION

        // Création d'une réservation
        private void btnReservationCreate_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm("Création");
            reservationForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult  = reservationForm.ShowDialog();

            String messageToSend = reservationForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        private void btnReservationModify_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm("Update");
            reservationForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = reservationForm.ShowDialog();

            String messageToSend = reservationForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        #endregion RESERVATION


        /*******************************************************************
                                    CLIENTS
        *******************************************************************/

        #region CLIENT

        // Création d'un client
        private void btnClientCreate_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(MainForm.OPERATION_CLIENT_CREATION);
            clientForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = clientForm.ShowDialog();

            String messageToSend = clientForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);

        }

        // Modification d'un client
        private void btnClientModify_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(MainForm.OPERATION_CLIENT_MODIFICATION);
            clientForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = clientForm.ShowDialog();            

            String messageToSend = clientForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        #endregion CLIENT

        /*******************************************************************
                                    VEHICULES
        *******************************************************************/

        #region VEHICULE

        private void btnCarCreate_Click(object sender, EventArgs e)
        {
        }

        private void btnCarModify_Click(object sender, EventArgs e)
        {
        }

        #endregion VEHICULE

        /*******************************************************************
                                    UTILITAIRES
        *******************************************************************/

        #region UTILITAIRES   

        private void tmr_Tick(object sender, EventArgs e)
        {
            lblMainForm_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {

            if (RightTimeOut < 5)
            {
                RightTimeOut++;
            }

            if (RightTimeOut == 5)
            {
                Animations.Animate(panel_Messages, Animations.Effect.Roll, 300, 180);
                RightTimeOut = 0;
                timerMainForm_MessagesAnimations.Stop();
            }

        }

        private void showDate()
        {
            String dateAffichage = "";
            DateTime jour = DateTime.Now;

            dateAffichage = jour.Day.ToString() + " " + jour.ToString("MMMM", CultureInfo.InvariantCulture) + " " + jour.Year.ToString();
            lblMainForm_date.Text = dateAffichage;

        }

        public void toggleMessage(DialogResult dialogResult, String message)
        {
            panelSelector(true);

            if (dialogResult == DialogResult.OK)
            {
                lblMainForm_Messages.Text = message;
                panel_Messages.BackColor = Color.DarkCyan;
                Animations.Animate(panel_Messages, Animations.Effect.Roll, 300, 180);
                timerMainForm_MessagesAnimations.Start();
            }
            else if(dialogResult == DialogResult.No)
            {
                lblMainForm_Messages.Text = message;
                panel_Messages.BackColor = Color.DarkRed;
                Animations.Animate(panel_Messages, Animations.Effect.Roll, 300, 180);
                timerMainForm_MessagesAnimations.Start();
            }
        }

        private void panelSelector(bool v)
        {
            if (v)
            {
                panel_operation.Show();
                lblOperation.Show();
            }
            else
            {
                panel_operation.Hide();
                lblOperation.Hide();
            }

        }

        private void mouseEnterEventHandler(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Teal;
            button.ForeColor = Color.Black;
        }

        private void mouseLeaveEventHandler(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Black;
            button.ForeColor = Color.Teal;
        }

        #endregion UTILITAIRES

    }
}
