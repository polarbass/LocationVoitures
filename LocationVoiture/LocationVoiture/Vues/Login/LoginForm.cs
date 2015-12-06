using LocationVoiture.Controller;
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

        private int RightTimeOut = 0;

        // Constructeur

        public LoginForm()
        {
            InitializeComponent();

            lblLoading.Hide();

            locationController = new LocationController();

            showDate();
            timerLoginForm_clock.Tick += new EventHandler(tmr_Tick);
            timerLoginForm_clock.Start();

            // FadeIn FadeOut pour l'affichage des messages
            animationTimer.Tick += animationTimer_tick;
        }

        #region BOUTONS

        /// <summary>
        /// Vérification des informations pour faire la connection
        /// </summary>        
        private void btnLogin_login_Click(object sender, EventArgs e)
        {
            username = txtLogin_username.Text;
            String password = txtLogin_password.Text;

            if (password.Equals("123456"))
            {
            this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
                animationTimer.Start();
                txtLogin_password.Text = "";                
            }
            
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

        private void animationTimer_tick(object sender, EventArgs e)
        {
            if (RightTimeOut < 1)
            {
                RightTimeOut++;
            }

            if (RightTimeOut == 1)
            {
                Animations.Animate(lblLoading, Animations.Effect.Roll, 100, 180);
                RightTimeOut = 0;
                animationTimer.Stop();
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

        private void txtLogin_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
