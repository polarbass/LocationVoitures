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
    public partial class SuccursaleSearch : Form
    {

        // Propriétés

        private LocationController locationController { get; set; }
        
        public String succursaleSearchID { get; private set; }

        private enum findByParameter { succursaleID, nom, addresse, telephone, courriel};

        private enum columnName
        {
            [Description("No. Succursale")]
            succursaleID,
            Nom,
            Addresse,            
            [Description("Téléphone")]
            Telephone,
            Courriel
        };

        private int RightTimeOut = 0;

        // Constructeur

        public SuccursaleSearch()
        {
            InitializeComponent();

            locationController = new LocationController();

            btnSuccursaleSearch_select.Enabled = false;
            panel_message.Hide();            
            lblLoading.Hide();

            // FadeIn FadeOut pour l'affichage des messages
            animationTimer.Tick += animationTimer_tick;

            // Paramètres de recherches disponibles
            foreach (findByParameter parameter in Enum.GetValues(typeof(findByParameter)))
            {
                comboSuccursaleSearch_FindBy.Items.Add(parameter);
            }

            comboSuccursaleSearch_FindBy.SelectedIndex = 0;

        }

        #region BOUTONS

        /// <summary>
        /// SEARCH
        /// </summary>
        private void btnSuccursaleSearch_find_Click(object sender, EventArgs e)
        {

            String searchValue = "";
            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

            if (txtSuccursaleSearch_value.Text != "")
            {
                searchValue = txtSuccursaleSearch_value.Text;
            }  

            String comboChoice = comboSuccursaleSearch_FindBy.SelectedItem.ToString();
            List<succursale> succursaleFound = new List<succursale>();

            switch (comboChoice)
            {
                case "succursaleID":
                    succursaleFound = locationController.SuccursalesServices.FindBy(searchValue, findByParameter.succursaleID.ToString());
                    break;
                case "nom":
                    succursaleFound = locationController.SuccursalesServices.FindBy(searchValue, findByParameter.nom.ToString());
                    break;
                case "addresse":
                    succursaleFound = locationController.SuccursalesServices.FindBy(searchValue, findByParameter.addresse.ToString());
                    break;
                case "telephone":
                    succursaleFound = locationController.SuccursalesServices.FindBy(searchValue, findByParameter.telephone.ToString());
                    break;
                case "courriel":
                    succursaleFound = locationController.SuccursalesServices.FindBy(searchValue, findByParameter.courriel.ToString());
                    break;
            }

            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

            // Si un ou des succursales sont trouvés
            if (succursaleFound.Count > 0)
            {
                DataTable table = new DataTable();

                foreach (columnName enumValue in Enum.GetValues(typeof(columnName)))
                {
                    table.Columns.Add(EnumDescriptor.GetEnumDescription(enumValue), typeof(string));
                }

                foreach (succursale succursale in succursaleFound)
                {
                    table.Rows.Add(
                            succursale.succursaleID.ToString(),
                            succursale.nom.ToString(),
                            succursale.addresse.ToString(),
                            succursale.telephone.ToString(),
                            succursale.courriel.ToString()
                        );
                }

                dataGridView1.DataSource = table;
                btnSuccursaleSearch_select.Enabled = true;
            }
            else
            {
                Animations.Animate(panel_message, Animations.Effect.Roll, 100, 180);
                animationTimer.Start();
                dataGridView1.DataSource = null;
                btnSuccursaleSearch_select.Enabled = false;
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
        private void btnSuccursaleSearch_select_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentRow.Index;
            object selectedRowID = dataGridView1[0, selectedRow].Value;
            String employeID = selectedRowID.ToString();

            succursaleSearchID = employeID;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion BOUTONS

        #region UTILITAIRES

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
