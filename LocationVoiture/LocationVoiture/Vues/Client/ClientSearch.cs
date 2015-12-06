using LocationVoiture.Controller;
using LocationVoiture.Model;
using LocationVoiture.Services;
using LocationVoiture.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationVoiture.Vues
{
    public partial class ClientSearch : Form
    {

        // Propriétés

        private LocationController locationController { get; set; }
        
        public String clientSearchID { get; private set; }

        private enum findByParameter { clientID, nom, prenom, courriel, telephone };

        public enum columnName
        {
            [Description("No. Client")]
            clientID,
            Nom,
            [Description("Téléphone")]
            Phone,
            Addresse,
            Courriel
        };

        private int RightTimeOut = 0;

        // Constructeur

        public ClientSearch()
        {
            InitializeComponent();

            locationController = new LocationController();

            btnClientSearch_select.Enabled = false;
            panel_message.Hide();
            lblLoading.Hide();

            // FadeIn FadeOut pour l'affichage des messages
            animationTimer.Tick += animationTimer_tick;

            // Paramètre de recherche disponible
            foreach (findByParameter parameter in Enum.GetValues(typeof(findByParameter)))
            {
                comboClientSearch_FindBy.Items.Add(parameter);
            }

            comboClientSearch_FindBy.SelectedIndex = 0;

        }

        /// <summary>
        /// SEARCH
        /// </summary>
        private void btnClientSearch_find_Click(object sender, EventArgs e)
        {
            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
            String searchValue = txtClientSearch_value.Text;
            String comboChoice = comboClientSearch_FindBy.SelectedItem.ToString();
            List<client> clientFound = new List<client>();

            switch (comboChoice)
            {
                case "clientID":
                    clientFound = locationController.ClientsServices.FindBy(searchValue, findByParameter.clientID.ToString());
                    break;
                case "nom":
                    clientFound = locationController.ClientsServices.FindBy(searchValue, findByParameter.nom.ToString());
                    break;
                case "prenom":
                    clientFound = locationController.ClientsServices.FindBy(searchValue, findByParameter.prenom.ToString());
                    break;
                case "courriel":
                    clientFound = locationController.ClientsServices.FindBy(searchValue, findByParameter.courriel.ToString());
                    break;
                case "telephone":
                    clientFound = locationController.ClientsServices.FindBy(searchValue, findByParameter.telephone.ToString());
                    break;
            }

            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

            // Si un ou des client o
            if (clientFound.Count > 0)
            {
                DataTable table = new DataTable();

                foreach (columnName enumValue in Enum.GetValues(typeof(columnName)))
                {
                    table.Columns.Add(EnumDescriptor.GetEnumDescription(enumValue), typeof(string));
                }

                foreach (client client in clientFound)
                {
                    table.Rows.Add(
                        client.clientID.ToString(),
                        client.prenom + " " + client.nom,
                        client.telephone,
                        client.adresse_client,
                        client.courriel
                        );
                }

                dataGridView1.DataSource = table;
                btnClientSearch_select.Enabled = true;
            }
            else
            {
                Animations.Animate(panel_message, Animations.Effect.Roll, 300, 180);
                animationTimer.Start();
                dataGridView1.DataSource = null;
                btnClientSearch_select.Enabled = false;
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
            String clientID = selectedRowID.ToString();

            clientSearchID = clientID;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void animationTimer_tick(object sender, EventArgs e)
        {
            if (RightTimeOut < 2)
            {
                RightTimeOut++;
            }

            if (RightTimeOut == 2)
            {
                Animations.Animate(panel_message, Animations.Effect.Roll, 300, 180);
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
    }
}
