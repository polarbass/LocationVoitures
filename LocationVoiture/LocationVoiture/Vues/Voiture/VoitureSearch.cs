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
    public partial class VoitureSearch : Form
    {

        // Propriétés

        private LocationController locationController { get; set; }
        
        public String vehiculeSearchID { get; private set; }

        private enum findByParameter { vehiculeID, fabricant, modele, plateNum, succursale };

        private enum columnName
        {
            [Description("No. véhicule")]
            vehiculeID,
            Fabriquant,
            [Description("Modèle")]
            Modele,            
            [Description("No. Plaque")]
            plate_num,            
            Succursale
        };

        private int RightTimeOut = 0;

        // Constructeur

        public VoitureSearch()
        {
            InitializeComponent();

            locationController = new LocationController();

            btnVehiculeSearch_select.Enabled = false;
            panel_message.Hide();
            cbVehiculeSearch.Hide();
            lblLoading.Hide();

            // FadeIn FadeOut pour l'affichage des messages
            animationTimer.Tick += animationTimer_tick;

            // Paramètre de recherche disponible
            foreach (findByParameter parameter in Enum.GetValues(typeof(findByParameter)))
            {
                comboVehiculeSearch_FindBy.Items.Add(parameter);
            }

            comboVehiculeSearch_FindBy.SelectedIndex = 0;

        }

        #region BOUTONS

        /// <summary>
        /// Recherche employé(s)
        /// </summary>
        private void btnEmployeSearch_find_Click(object sender, EventArgs e)
        {

            String searchValue;
            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

            if (txtVehiculeSearch_value.Text != "")
            {
                searchValue = txtVehiculeSearch_value.Text;
            }
            else
            {
                searchValue = (cbVehiculeSearch.SelectedItem as ComboboxItem).Value.ToString();
            }

            String comboChoice = comboVehiculeSearch_FindBy.SelectedItem.ToString();
            List<vehicule> vehiculeFound = new List<vehicule>();

            switch (comboChoice)
            {
                case "vehiculeID":
                    vehiculeFound = locationController.VehiculeServices.FindBy(searchValue, findByParameter.vehiculeID.ToString());
                    break;
                case "fabricant":
                    vehiculeFound = locationController.VehiculeServices.FindBy(searchValue, findByParameter.fabricant.ToString());
                    break;
                case "modele":
                    vehiculeFound = locationController.VehiculeServices.FindBy(searchValue, findByParameter.modele.ToString());
                    break;
                case "plateNum":
                    vehiculeFound = locationController.VehiculeServices.FindBy(searchValue, findByParameter.plateNum.ToString());
                    break;
                case "succursale":
                    vehiculeFound = locationController.VehiculeServices.FindBy(searchValue, findByParameter.succursale.ToString());
                    break;
            }

            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

            // Si un ou des employés sont trouvés
            if (vehiculeFound.Count > 0)
            {
                DataTable table = new DataTable();

                foreach (columnName enumValue in Enum.GetValues(typeof(columnName)))
                {
                    table.Columns.Add(EnumDescriptor.GetEnumDescription(enumValue), typeof(string));
                }

                foreach (vehicule vehicule in vehiculeFound)
                {
                    table.Rows.Add(
                            vehicule.vehiculeID.ToString(),
                            vehicule.fabriquant.nom_fabriquant.ToString(),
                            vehicule.modele.nom_modele.ToString(),
                            vehicule.plaque_num.ToString(),
                            vehicule.succursale.nom.ToString()
                        );
                }

                dataGridView1.DataSource = table;
                btnVehiculeSearch_select.Enabled = true;
            }
            else
            {
                Animations.Animate(panel_message, Animations.Effect.Roll, 100, 180);
                animationTimer.Start();
                dataGridView1.DataSource = null;
                btnVehiculeSearch_select.Enabled = false;
            }
        }

        /// <summary>
        /// Fermer la recherche
        /// </summary>
        private void btnVehiculeSearch_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Selection du client
        /// </summary>
        private void btnVehiculeSearch_select_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentRow.Index;
            object selectedRowID = dataGridView1[0, selectedRow].Value;
            String vehiculeID = selectedRowID.ToString();

            vehiculeSearchID = vehiculeID;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion BOUTONS

        #region COMBOBOX

        /// <summary>
        /// Affichange du combobox comboVehicleSearch_FindBy et remplissage selon le paramètre choisi
        /// </summary>
        private void comboVehiculeSearch_FindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Succursales
            if (comboVehiculeSearch_FindBy.SelectedItem.ToString().Equals(findByParameter.succursale.ToString()))
            {
                cbVehiculeSearch.Items.Clear();
                txtVehiculeSearch_value.Text = "";
                txtVehiculeSearch_value.Enabled = false;
                List<succursale> succursales = locationController.SuccursalesServices.getAllSuccursale();
                foreach (succursale succ in succursales)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = succ.nom;
                    item.Value = succ.succursaleID;

                    cbVehiculeSearch.Items.Add(item);
                }

                cbVehiculeSearch.SelectedIndex = 0;
                cbVehiculeSearch.Show();
            }

            // Fabriquant
            else if (comboVehiculeSearch_FindBy.SelectedItem.ToString().Equals(findByParameter.fabricant.ToString()))
            {
                cbVehiculeSearch.Items.Clear();
                txtVehiculeSearch_value.Text = "";
                txtVehiculeSearch_value.Enabled = false;
                List<fabriquant> fabricants = locationController.FabricantsService.GetAllFabriquants();
                foreach (fabriquant fab in fabricants)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = fab.nom_fabriquant;
                    item.Value = fab.fabriquantID;

                    cbVehiculeSearch.Items.Add(item);
                }

                cbVehiculeSearch.SelectedIndex = 0;
                cbVehiculeSearch.Show();
            }

            // Modele
            else if (comboVehiculeSearch_FindBy.SelectedItem.ToString().Equals(findByParameter.modele.ToString()))
            {
                cbVehiculeSearch.Items.Clear();
                txtVehiculeSearch_value.Text = "";
                txtVehiculeSearch_value.Enabled = false;
                List<modele> modeles = locationController.ModelesServices.GetAll();
                foreach (modele mod in modeles)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = mod.nom_modele;
                    item.Value = mod.modeleID;

                    cbVehiculeSearch.Items.Add(item);
                }

                cbVehiculeSearch.SelectedIndex = 0;
                cbVehiculeSearch.Show();
            }

            else
            {
                cbVehiculeSearch.Hide();
                txtVehiculeSearch_value.Enabled = true;
            }

        }

        #endregion COMBOBOX

        #region UTILITAIRES

        private void animationTimer_tick(object sender, EventArgs e)
        {
            if (RightTimeOut < 1)
            {
                RightTimeOut++;
            }

            if (RightTimeOut == 1)
            {
                Animations.Animate(panel_message, Animations.Effect.Roll, 200, 180);
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
