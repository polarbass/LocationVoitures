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

        private const string OPERATION_EMPLOYE_CREATION     = "Création";
        private const string OPERATION_EMPLOYE_UPDATE       = "Updater";
        private const string MESSAGE_EMPLOYE_ADD            = "L'employé a été ajouté";
        private const string MESSAGE_EMPLOYE_ADD_ERROR      = "Une erreur est survenue lors de la creation de l'employé";
        private const string MESSAGE_EMPLOYE_UPDATE         = "L'employé a été modifé";
        private const string MESSAGE_EMPLOYE_DELETE         = "L'employé a été effacé";        

        private enum employeFunctions { Caissier, Commis, Soutient, Administration, Administrateur }

        // Propriétés

        private LocationController locationController { get; set; }
        
        public client clientAdded { get; private set; }
        public string messageToSend { get; private set; }

        // Constructeur

        public EmployeForm(String operation)
        {
            InitializeComponent();
            locationController = new LocationController();

            fillFunctionCombo();

            lblClientCreate_operation.Text = operation;
            panel2.Hide();
            lblLoading.Hide();

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

        private void fillFunctionCombo()
        {
            // Paramètre de recherche disponible
            foreach (employeFunctions fonction in Enum.GetValues(typeof(employeFunctions)))
            {
                cbEmploye_fonction.Items.Add(fonction);
            }

            List<succursale> succursales = locationController.SuccursalesServices.getAllSuccursale();
            foreach(succursale succ in succursales)
            {
                cbEmploye_succursale.Items.Add(succ.nom);
            }

            cbEmploye_fonction.SelectedIndex = 0;
            cbEmploye_succursale.SelectedIndex = 0;
        }

        // Méthodes

        #region BOUTONS

        /// <summary>
        /// Création d'un nouvel employé à l'aide des informations inscrites dans les champs
        /// </summary>        
        private void btnEmploye_add_Click(object sender, EventArgs e)
        {

            String nom          = txtEmploye_nom.Text;
            String tauxHoraire  = txtEmploye_tauxHoraire.Text;
            String telephone    = txtEmploye_phone.Text;
            String adresse      = txtEmploye_adresse.Text;
            String username     = txtEmploye_username.Text;
            String password     = txtEmploye_password.Text;
            String fonction     = cbEmploye_fonction.SelectedItem.ToString();
            String succursaleString = cbEmploye_succursale.SelectedItem.ToString();
            int succursaleID = locationController.SuccursalesServices.FindBy(succursaleString, "nom").First().succursaleID;

            if (!nom.Equals("") && !telephone.Equals("") && !adresse.Equals("") && !username.Equals("") && !password.Equals(""))
            {

                // Fonction ADD 
                if (!btnEmploye_add.Text.Equals(EmployeForm.OPERATION_EMPLOYE_UPDATE))
                {
                    employe addEmploye = new employe();

                    addEmploye.nom = nom;
                    addEmploye.telephone = telephone;
                    addEmploye.adresse            = adresse;
                    addEmploye.fonction = fonction;
                    addEmploye.salaire_horaire = float.Parse(tauxHoraire);
                    addEmploye.username = username;
                    addEmploye.password = password;
                    addEmploye.succursaleID = succursaleID;

                    if (locationController.EmployesService.AddEmploye(addEmploye))
                    {
                        emptyEmployeFormFields();
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
                    string idToUpdate = txtEmploye_empID.Text;

                    employe employeToUpdate = locationController.EmployesService.Find(idToUpdate);

                    if (employeToUpdate != null)
                    {
                        employeToUpdate.nom = nom;
                        employeToUpdate.telephone        = telephone;
                        employeToUpdate.adresse   = adresse;
                        employeToUpdate.fonction = fonction;
                        employeToUpdate.salaire_horaire = float.Parse(tauxHoraire);
                        employeToUpdate.username = username;
                        employeToUpdate.password = password;
                        employeToUpdate.succursaleID = succursaleID;

                    }                   

                    if (locationController.EmployesService.Save())
                    {
                        this.DialogResult = DialogResult.OK;
                        messageToSend = "L'employé a été modifé";
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                        messageToSend = "Une erreur est survenu lors de la modification de l'employée";
                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Veuillez inscrire toutes les informations svp");
            }
        }

        /// <summary>
        /// Recherche d'un employé afin de modifier ses informations.
        /// Si le champ est vide, un nouveau formulaire de recherche est lancé afin de permettre la recherche à l'aide de plus de champs
        /// Sinon, la recherche est effectuée à l'aide de l'id de l'employé.
        /// </summary>        
        private void btnEmploye_Find_Click(object sender, EventArgs e)
        {
            String searchValue = "";

            if (txtEmploye_idSearch.Text == "")
            {
                this.Opacity = 0.1;

                EmployeSearch searchForm = new EmployeSearch();
                searchForm.Owner = this;
                searchForm.ShowDialog();

                // récupération du ID sélectionner dans le searchForm
                searchValue = searchForm.employeSearchID;

                this.Opacity = 1;
            }
            else
            {
                Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

                // le id est lu directement dans le champ
                searchValue = txtEmploye_idSearch.Text;

                Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
            }

            employe employeFound = locationController.EmployesService.Find(searchValue);

            // Affichage de l'employé
            if (employeFound != null)
            {

                btnEmploye_Delete.Visible = true;
                setFieldStatus(true);
                txtEmploye_empID.Enabled = false;

                txtEmploye_empID.Text       = employeFound.employeID.ToString();
                txtEmploye_nom.Text         = employeFound.nom;
                txtEmploye_tauxHoraire.Text = employeFound.salaire_horaire.ToString();
                txtEmploye_phone.Text       = employeFound.telephone;
                txtEmploye_adresse.Text     = employeFound.adresse;
                txtEmploye_username.Text    = employeFound.username;
                txtEmploye_password.Text    = employeFound.password;
                cbEmploye_fonction.SelectedIndex = cbEmploye_fonction.FindStringExact(employeFound.fonction);
                cbEmploye_succursale.SelectedIndex = cbEmploye_succursale.FindStringExact(employeFound.succursale.nom);
            }
            else
            {
                btnEmploye_Delete.Visible = false;
                emptyEmployeFormFields();
                setFieldStatus(false);
            }
        }

        /// <summary>
        /// Efface un employé
        /// Si un employé est trouvé, un panneau de confirmation est ouvert afin de confirmer l'action
        /// </summary>        
        private void btnEmploye_Delete_Click(object sender, EventArgs e)
        {
            String searchValue = txtEmploye_empID.Text;
            employe employeToDelete = locationController.EmployesService.Find(searchValue);

            if (employeToDelete != null)
            {
                btnEmploye_Delete.Hide();
                Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);   
            }
        }

        /// <summary>
        /// Confirmation du delete de l'employé
        /// </summary>        
        private void btnOK_Click(object sender, EventArgs e)
        {
            String searchValue = txtEmploye_empID.Text;
            employe employeToDelete = locationController.EmployesService.Find(searchValue);

            if (employeToDelete != null)
            {
                Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);
                btnEmploye_Delete.Show();
                locationController.EmployesService.DeleteEmploye(employeToDelete);
                this.DialogResult = DialogResult.OK;

                // DELETE RÉUSSI
                messageToSend = EmployeForm.MESSAGE_EMPLOYE_DELETE;
                this.Close();
            }
        }

        /// <summary>
        /// Cancel le delete de l'employé
        /// </summary>        
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);
            btnEmploye_Delete.Show();
        }

        /// <summary>
        /// Cancel la création d'un employé (fermeture du formulaire)
        /// </summary>       
        private void txtClientCreate_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BOUTONS

        #region UTILITAIRES

        private void emptyEmployeFormFields()
        {
            txtEmploye_empID.Text           = "";
            txtEmploye_idSearch.Text        = "";
            txtEmploye_nom.Text             = "";
            txtEmploye_phone.Text           = "";
            txtEmploye_adresse.Text         = "";
            txtEmploye_tauxHoraire.Text     = "";
            txtEmploye_password.Text        = "";
            txtEmploye_username.Text        = "";            
            cbEmploye_fonction.SelectedIndex    = 0;
            cbEmploye_succursale.SelectedIndex  = 0;
        }

        private void setFieldsVisibility(bool visibilityChoice)
        {
            panelClientCreate_clientId.Visible  = visibilityChoice;
            lblClientCreate_clientId.Visible    = visibilityChoice;   
            btnEmploye_Find.Visible             = visibilityChoice;
            btnEmploye_Delete.Visible           = visibilityChoice;
            txtEmploye_idSearch.Visible         = visibilityChoice;
            txtEmploye_empID.Visible            = visibilityChoice;
            lblClientCreate_id.Visible          = visibilityChoice;
            panelClientForm_id.Visible          = visibilityChoice;
        }

        private void setFieldStatus(bool enabledStatus)
        {
            txtEmploye_empID.Enabled        = enabledStatus;
            txtEmploye_nom.Enabled          = enabledStatus;
            txtEmploye_phone.Enabled        = enabledStatus;
            txtEmploye_adresse.Enabled      = enabledStatus;
            txtEmploye_tauxHoraire.Enabled  = enabledStatus;
            txtEmploye_password.Enabled     = enabledStatus;
            txtEmploye_username.Enabled     = enabledStatus;
            cbEmploye_fonction.Enabled      = enabledStatus;
            cbEmploye_succursale.Enabled    = enabledStatus;
        }

        private void mouseEnterEventHandler(object sender, EventArgs e)
        {
            var button          = (Button)sender;
            button.BackColor    = Color.Teal;
            button.ForeColor    = Color.Black;
        }

        private void mouseLeaveEventHandler(object sender, EventArgs e)
        {
            var button          = (Button)sender;
            button.BackColor    = Color.Black;
            button.ForeColor    = Color.Teal;
        }

        private void mouseEnterEventHandlerRed(object sender, EventArgs e)
        {
            var button          = (Button)sender;
            button.BackColor    = Color.Maroon;
            button.ForeColor    = Color.Black;
        }

        private void mouseLeaveEventHandlerRed(object sender, EventArgs e)
        {
            var button          = (Button)sender;
            button.BackColor    = Color.Black;
            button.ForeColor    = Color.Maroon;
        }

        #endregion UTILITAIRES
    }
}
