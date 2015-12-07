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
    public partial class EmployeSearch : Form
    {

        // Propriétés

        private LocationController locationController { get; set; }
        
        public String employeSearchID { get; private set; }

        private enum findByParameter { employeID, nom, prenom, fonction, succursale, telephone };

        private enum employeFunctions { Caissier, Commis, Soutient, Administration, Administrateur }

        private enum columnName
        {
            [Description("No. Employé")]
            employeID,
            Nom,
            Fonction,
            Succursale,
            [Description("Téléphone")]
            Phone
        };

        private int RightTimeOut = 0;

        // Constructeur

        public EmployeSearch()
        {
            InitializeComponent();

            locationController = new LocationController();

            btnEmployeSearch_select.Enabled = false;
            panel_message.Hide();
            cbEmployeSearch.Hide();
            lblLoading.Hide();

            // FadeIn FadeOut pour l'affichage des messages
            animationTimer.Tick += animationTimer_tick;

            // Paramètre de recherche disponible
            foreach (findByParameter parameter in Enum.GetValues(typeof(findByParameter)))
            {
                comboEmployeSearch_FindBy.Items.Add(parameter);
            }

            comboEmployeSearch_FindBy.SelectedIndex = 0;

        }

        /// <summary>
        /// SEARCH
        /// </summary>
        private void btnEmployeSearch_find_Click(object sender, EventArgs e)
        {

            String searchValue = "";
            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

            if (txtEmployeSearch_value.Text != "")
            {
                searchValue = txtEmployeSearch_value.Text;
            }
            else
            {
                if(cbEmployeSearch.Items.Count > 0)
                {
                    searchValue = (cbEmployeSearch.SelectedItem as ComboboxItem).Value.ToString();
                }                
            }       

            String comboChoice = comboEmployeSearch_FindBy.SelectedItem.ToString();
            List<employe> employeFound = new List<employe>();

            switch (comboChoice)
            {
                case "employeID":
                    employeFound = locationController.EmployesService.FindBy(searchValue, findByParameter.employeID.ToString());
                    break;
                case "nom":
                    employeFound = locationController.EmployesService.FindBy(searchValue, findByParameter.nom.ToString());
                    break;
                case "prenom":
                    employeFound = locationController.EmployesService.FindBy(searchValue, findByParameter.prenom.ToString());
                    break;
                case "fonction":
                    employeFound = locationController.EmployesService.FindBy(searchValue, findByParameter.fonction.ToString());
                    break;
                case "succursale":
                    employeFound = locationController.EmployesService.FindBy(searchValue, findByParameter.succursale.ToString());
                    break;
                case "telephone":
                    employeFound = locationController.EmployesService.FindBy(searchValue, findByParameter.telephone.ToString());
                    break;
            }

            Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

            // Si un ou des employés sont trouvés
            if (employeFound.Count > 0)
            {
                DataTable table = new DataTable();

                foreach (columnName enumValue in Enum.GetValues(typeof(columnName)))
                {
                    table.Columns.Add(EnumDescriptor.GetEnumDescription(enumValue), typeof(string));
                }

                foreach (employe employe in employeFound)
                {
                    table.Rows.Add(
                            employe.employeID.ToString(),
                            employe.nom.ToString(),
                            employe.fonction.ToString(),
                            employe.succursale.nom.ToString(),
                            employe.telephone.ToString()
                        );
                }

                dataGridView1.DataSource = table;
                btnEmployeSearch_select.Enabled = true;
            }
            else
            {
                Animations.Animate(panel_message, Animations.Effect.Roll, 200, 180);
                animationTimer.Start();
                dataGridView1.DataSource = null;
                btnEmployeSearch_select.Enabled = false;
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
        private void btnEmployeSearch_select_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentRow.Index;
            object selectedRowID = dataGridView1[0, selectedRow].Value;
            String employeID = selectedRowID.ToString();

            employeSearchID = employeID;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region UTILITAIRES

        private void animationTimer_tick(object sender, EventArgs e)
        {
            if (RightTimeOut < 2)
            {
                RightTimeOut++;
            }

            if (RightTimeOut == 2)
            {
                Animations.Animate(panel_message, Animations.Effect.Roll, 200, 180);
                RightTimeOut = 0;
                animationTimer.Stop();
            }
        }

        #endregion UTILITAIRES

        private void comboEmployeSearch_FindBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboEmployeSearch_FindBy.SelectedItem.ToString().Equals(findByParameter.succursale.ToString()))
            {
                cbEmployeSearch.Items.Clear();
                txtEmployeSearch_value.Text = "";
                List<succursale> succursales = locationController.SuccursalesServices.getAllSuccursale();
                foreach (succursale succ in succursales)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = succ.nom;
                    item.Value = succ.succursaleID;

                    cbEmployeSearch.Items.Add(item);
                }
                
                cbEmployeSearch.SelectedIndex = 0;
                cbEmployeSearch.Show();
            }

            else if (comboEmployeSearch_FindBy.SelectedItem.ToString().Equals(findByParameter.fonction.ToString()))
            {
                cbEmployeSearch.Items.Clear();
                txtEmployeSearch_value.Text = "";
                foreach (employeFunctions fonction in Enum.GetValues(typeof(employeFunctions)))
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Value = fonction.ToString();
                    item.Text = fonction.ToString();
                    cbEmployeSearch.Items.Add(item);
                }
                cbEmployeSearch.SelectedIndex = 0;
                cbEmployeSearch.Show();
            }
            else
            {
                cbEmployeSearch.Hide();
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
