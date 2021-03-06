﻿using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LocationVoiture.Vues
{
    public partial class MainForm : Form
    {

        int RightTimeOut = 0; 

        private static string OPERATION_CREATION = "Création";
        private static string OPERATION_MODIFICATION = "Modification";

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

            // Test de connection
            //
            //using (var db = new locationvoitureEntities())
            //{
            //    try
            //    {
            //        db.Database.Connection.Open();
            //        if (db.Database.Connection.State == ConnectionState.Open)
            //        {
            //            Console.WriteLine(@"INFO: ConnectionString: " + db.Database.Connection.ConnectionString
            //                + "\n DataBase: " + db.Database.Connection.Database
            //                + "\n DataSource: " + db.Database.Connection.DataSource
            //                + "\n ServerVersion: " + db.Database.Connection.ServerVersion
            //                + "\n TimeOut: " + db.Database.Connection.ConnectionTimeout);
            //            MessageBox.Show("connected");
            //
            //            db.Database.Connection.Close();
            //
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("not connected");
            //    }
            //}

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
            ReservationForm_version2 reservationForm = new ReservationForm_version2("Création");
            reservationForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult  = reservationForm.ShowDialog();

            String messageToSend = reservationForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        private void btnReservationModify_Click(object sender, EventArgs e)
        {
            ReservationForm_version2 reservationForm = new ReservationForm_version2("Update");
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
            ClientForm clientForm = new ClientForm(MainForm.OPERATION_CREATION);
            clientForm.Owner = this;

            panelSelector(false);           

            DialogResult dialogResult = clientForm.ShowDialog();            

            String messageToSend = clientForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);

        }

        // Modification d'un client
        private void btnClientModify_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(MainForm.OPERATION_MODIFICATION);
            clientForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = clientForm.ShowDialog();            

            String messageToSend = clientForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        #endregion CLIENT

        /*******************************************************************
                            EMPLOYEE
        *******************************************************************/

        #region CLIENT

        // Création d'un employé
        private void btnEmployeCreate_Click(object sender, EventArgs e)
        {
            EmployeForm employeForm = new EmployeForm(MainForm.OPERATION_CREATION);
            employeForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = employeForm.ShowDialog();

            String messageToSend = employeForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);

        }

        // Modification d'un employé
        private void btnEmployeModify_Click(object sender, EventArgs e)
        {
            EmployeForm employeForm = new EmployeForm(MainForm.OPERATION_MODIFICATION);
            employeForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = employeForm.ShowDialog();

            String messageToSend = employeForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        #endregion CLIENT

        /*******************************************************************
                                    VEHICULES
        *******************************************************************/

        #region VEHICULE

        private void btnCarCreate_Click(object sender, EventArgs e)
        {
            VoitureForm voitureForm = new VoitureForm(MainForm.OPERATION_CREATION);
            voitureForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = voitureForm.ShowDialog();

            String messageToSend = voitureForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        private void btnCarModify_Click(object sender, EventArgs e)
        {
            VoitureForm voitureForm = new VoitureForm(MainForm.OPERATION_MODIFICATION);
            voitureForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = voitureForm.ShowDialog();

            String messageToSend = voitureForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        #endregion VEHICULE

        /*******************************************************************
                                SUCCURSALES
        *******************************************************************/

        #region SUCCURSALES

        private void btnSuccursaleCreate_Click(object sender, EventArgs e)
        {
            SuccursaleForm succursaleForm = new SuccursaleForm(MainForm.OPERATION_CREATION);
            succursaleForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = succursaleForm.ShowDialog();

            String messageToSend = succursaleForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        private void btnSuccursaleModify_Click(object sender, EventArgs e)
        {
            SuccursaleForm succursaleForm = new SuccursaleForm(MainForm.OPERATION_MODIFICATION);
            succursaleForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = succursaleForm.ShowDialog();

            String messageToSend = succursaleForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        #endregion SUCCURSALES

        /*******************************************************************
                                LOCATIONS
        *******************************************************************/

        #region LOCATIONS

        private void btnLocationCreate_Click(object sender, EventArgs e)
        {
            LocationForm locationForm = new LocationForm(MainForm.OPERATION_CREATION);
            locationForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = locationForm.ShowDialog();

            String messageToSend = locationForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        private void btnLocationModify_Click(object sender, EventArgs e)
        {
            LocationForm locationForm = new LocationForm(MainForm.OPERATION_MODIFICATION);
            locationForm.Owner = this;

            panelSelector(false);

            DialogResult dialogResult = locationForm.ShowDialog();

            String messageToSend = locationForm.messageToSend;
            toggleMessage(dialogResult, messageToSend);
        }

        #endregion LOCATIONS

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

            if (RightTimeOut < 2)
            {
                RightTimeOut++;
            }

            if (RightTimeOut == 2)
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
            //Animations.Animate(panel_operation, Animations.Effect.Roll, 200, 180);

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
                Animations.Animate(panel_operation, Animations.Effect.Roll, 80, 0);
                //panel_operation.Show();
                lblOperation.Show();
            }
            else
            {
                Animations.Animate(panel_operation, Animations.Effect.Roll, 80, 0);
                //panel_operation.Hide();
                lblOperation.Hide();
            }

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

    }
}
