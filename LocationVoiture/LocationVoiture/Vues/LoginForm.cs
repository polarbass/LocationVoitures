﻿using LocationVoiture.Controller;
using LocationVoiture.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationVoiture.Vues
{
    public partial class LoginForm : Form
    {

        // Propirétés

        public String username { get; private set; }
        private LocationController locationController { get; set; }

        // Constructeur

        public LoginForm()
        {
            InitializeComponent();

            locationController = new LocationController();

            showDate();
            timerLoginForm_clock.Tick += new EventHandler(tmr_Tick);
            timerLoginForm_clock.Start();
        }

        #region BOUTONS

        /// <summary>
        /// Vérification des informations pour faire la connection
        /// </summary>        
        private void btnLogin_login_Click(object sender, EventArgs e)
        {
            username = txtLogin_username.Text;
            String password = txtLogin_password.Text;

            //if(loginServices.loginAccepted(username, password))
            //{
            this.DialogResult = DialogResult.OK;
                this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Connection refusée");
            //}
            
        }

        /// <summary>
        /// Cancel l'authentification et ferme l'application
        /// </summary>        
        private void btnLogin_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion BOUTONS

        #region UTILITAIRES

        /// <summary>
        /// Afficher la date
        /// </summary>
        private void showDate()
        {
            String dateAffichage = "";
            DateTime jour = DateTime.Now;

            dateAffichage = jour.Day.ToString() + " " + jour.ToString("MMMM", CultureInfo.InvariantCulture) + " " + jour.Year.ToString();
            lblLoginForm_date.Text = dateAffichage;

        }

        /// <summary>
        /// Afficher l'heure
        /// </summary>
        private void tmr_Tick(object sender, EventArgs e)
        {
            lblLoginForm_time.Text = DateTime.Now.ToString("HH:mm:ss");
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
