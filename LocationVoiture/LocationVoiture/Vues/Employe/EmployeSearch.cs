using LocationVoiture.Controller;
using LocationVoiture.Model;
using LocationVoiture.Services;
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
    public partial class EmployeSearch : Form
    {

        // Propriétés

        private LocationController locationController { get; set; }
        
        public String clientSearchID { get; private set; }

        private enum findByParameter { clientID, nom, prenom, courriel, telephone };


        // Constructeur

        public EmployeSearch()
        {
            InitializeComponent();

            locationController = new LocationController();

            btnClientSearch_select.Enabled = false;

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

            // Si un ou des client o
            if (clientFound.Count > 0)
            {
                dataGridView1.DataSource = clientFound;
                btnClientSearch_select.Enabled = true;

                // hiding columns (6:password | 7:assurance | 8:permis_conduire_num | 9:num_carte_credit)
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }
            else
            {
                MessageBox.Show("Aucun client trouvé");
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
            String clientID = selectedRowID.ToString();

            clientSearchID = clientID;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
