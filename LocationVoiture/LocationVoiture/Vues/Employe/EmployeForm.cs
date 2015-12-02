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
    public partial class EmployeForm : Form
    {

        // Attributs

        private const string OPERATION_EMPLOYE_CREATION  = "Création";
        private const string OPERATION_EMPLOYE_UPDATE    = "Updater";

        // Propriétés
        
        private LocationController locationController { get; set; }
        
        public employe EmployeAdded { get; private set; }
        public string messageToSend { get; private set; }

        // Constructeur

        public EmployeForm(String operation)
        {
            InitializeComponent();
            locationController = new LocationController();

            lblEmploye_operation.Text = operation;

            // Selection de l'affichage
            if (operation.Equals(EmployeForm.OPERATION_EMPLOYE_CREATION))
            {
                // Création
                setFieldsVisibility(false);
            }
            else
            {
                // Update
                setFieldsVisibility(true);
                setFieldStatus(false);
                btnEmploye_add.Text = EmployeForm.OPERATION_EMPLOYE_UPDATE;
            }            
        }

        // Méthodes

        #region BOUTONS

        /// <summary>
        /// Création d'un nouveau client à l'aide des informations inscrites dans les champs
        /// </summary>        
        private void btnClientCreate_add_Click(object sender, EventArgs e)
        {

            String nom          = txtEmploye_nom.Text;
            String prenom       = txtEmploye_prenom.Text;
            String tauxHoraire  = txtEmploye_salaire.Text;
            String telephone    = txtEmploye_telephone.Text;
            String adresse      = txtEmploye_adresse.Text;
            String username     = txtEmploye_username.Text;
            String password     = txtEmploye_password.Text;
            String fonction     = comboEmploye_fonction.SelectedItem.ToString();

            if (!nom.Equals("") && !prenom.Equals("") && !telephone.Equals("") && !adresse.Equals("") && !username.Equals("") && !password.Equals(""))
            {

                // Fonction ADD 
                if (!btnEmploye_add.Text.Equals(EmployeForm.OPERATION_EMPLOYE_UPDATE))
                {

                    employe addEmploye = new employe();

                    addEmploye.nom                  = prenom + " " + nom;
                    //addEmploye.phone              = telephone;
                    //addEmploye.adresse            = adresse;
                    addEmploye.fonction             = fonction;
                    addEmploye.salaire_horaire      = int.Parse(tauxHoraire);
                    addEmploye.username             = username;
                    addEmploye.password             = password;

                    if (locationController.EmployesService.AddEmploye(addEmploye))
                    {
                        emptyClientFormFields();
                        EmployeAdded = addEmploye;
                        this.DialogResult = DialogResult.OK;
                        messageToSend = "L'employé a été ajouté";
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                        messageToSend = "Une erreur est survenue lors de la creation de l'employé";
                        this.Close();
                    }
                }

                // Fonction UPDATE
                else
                {
                    string idToUpdate = txtEmploye_empId.Text;

                    employe employeToUpdate = locationController.EmployesService.Find(idToUpdate);
                    if (employeToUpdate != null)
                    {

                        employeToUpdate.nom              = prenom + " " + nom;
                        //employeToUpdate.telephone        = telephone;
                        //employeToUpdate.adresse   = adresse;

                    }

                    locationController.EmployesService.Save();
                    this.DialogResult = DialogResult.OK;
                    messageToSend = "L'employé a été modifé";
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez inscrire toutes les informations svp");
            }
        }

        /// <summary>
        /// Recherche d'un client afin de modifier ses informations.
        /// Si le champ est vide, un nouveau formulaire de recherche est lancé afin de permettre la recherche à l'aide de plus de champs
        /// Sinon, la recherche est effectué à l'aide de l'id du client.
        /// </summary>        
        private void btnClientForm_Find_Click(object sender, EventArgs e)
        {

            String searchValue = "";

            if (txtEmploye_idSearch.Text == "")
            {
                ClientSearch searchForm = new ClientSearch();
                searchForm.Owner = this;
                searchForm.ShowDialog();

                // récupération du ID sélectionner dans le searchForm
                searchValue = searchForm.clientSearchID;
            }
            else
            {                
                // le id est lu directement dans le champ
                searchValue = txtEmploye_idSearch.Text;
            }

            client clientToUpdate = locationController.ClientsServices.Find(searchValue);

            // Update du client
            if (clientToUpdate != null)
            {

                btnEmploye_Delete.Visible = true;
                setFieldStatus(true);
                txtEmploye_empId.Enabled = false;

                txtEmploye_empId.Text   = clientToUpdate.clientID.ToString();
                txtEmploye_nom.Text        = clientToUpdate.nom;
                txtEmploye_prenom.Text     = clientToUpdate.prenom;
                txtEmploye_telephone.Text      = clientToUpdate.telephone;
                txtEmploye_telephone.Text    = clientToUpdate.adresse_client;
                txtEmploye_salaire.Text      = clientToUpdate.courriel;
            }
            else
            {
                MessageBox.Show("Aucun client n'a pu etre trouvé");
                btnEmploye_Delete.Visible = false;
                emptyClientFormFields();
            }
        }

        /// <summary>
        /// Efface un client
        /// </summary>        
        private void btnClientCreate_Delete_Click(object sender, EventArgs e)
        {
            String searchValue = txtEmploye_idSearch.Text;
            client clientToDelete = locationController.ClientsServices.Find(searchValue);

            if (clientToDelete != null)
            {
                var confirmResult = MessageBox.Show("Voulez-vous vraiment effacer ce client ?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    locationController.ClientsServices.DeleteClient(clientToDelete);
                    this.DialogResult = DialogResult.OK;
                    messageToSend = "Le client a été effacé";
                    this.Close();
                }      
            }

        }

        /// <summary>
        /// Cancel la création d'un client (fermeture du formulaire)
        /// </summary>       
        private void txtClientCreate_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BOUTONS

        #region UTILITAIRES

        private void emptyClientFormFields()
        {
            txtEmploye_empId.Text   = "";
            txtEmploye_idSearch.Text   = "";
            txtEmploye_nom.Text        = "";
            txtEmploye_prenom.Text     = "";
            txtEmploye_telephone.Text      = "";
            txtEmploye_telephone.Text    = "";
            txtEmploye_salaire.Text      = "";
        }

        private void setFieldsVisibility(bool visibilityChoice)
        {
            panelClientCreate_clientId.Visible  = visibilityChoice;
            lblEmploye_empId.Visible    = visibilityChoice;   
            btnEmploye_find.Visible          = visibilityChoice;
            btnEmploye_Delete.Visible      = false;
            txtEmploye_idSearch.Visible    = visibilityChoice;
            txtEmploye_empId.Enabled    = visibilityChoice;
            lblEmploye_idFind.Visible          = visibilityChoice;
            panelClientForm_id.Visible          = visibilityChoice;
        }

        private void setFieldStatus(bool enabledStatus)
        {
            txtEmploye_empId.Enabled    = enabledStatus;
            txtEmploye_nom.Enabled         = enabledStatus;
            txtEmploye_prenom.Enabled      = enabledStatus;
            txtEmploye_telephone.Enabled       = enabledStatus;
            txtEmploye_telephone.Enabled     = enabledStatus;
            txtEmploye_salaire.Enabled       = enabledStatus;
        }

        #endregion UTILITAIRES

    }
}
