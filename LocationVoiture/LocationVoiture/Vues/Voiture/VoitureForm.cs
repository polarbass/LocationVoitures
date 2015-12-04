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
    public partial class VoitureForm : Form
    {

        // Attributs

        private const string OPERATION_VOITURE_CREATION     = "Création";
        private const string OPERATION_VOITURE_UPDATE = "Updater";
        private const string MESSAGE_VOITURE_ADD = "Le véhicule a été ajouté";
        private const string MESSAGE_VOITURE_ADD_ERROR = "Une erreur est survenue lors de la creation du véhicule";
        private const string MESSAGE_VOITURE_UPDATE = "Le véhicule a été modifé";
        private const string MESSAGE_VOITURE_DELETE = "Le véhicule a été effacé";        

        // Propriétés

        private LocationController locationController { get; set; }
        
        public client voitureAdded { get; private set; }
        public string messageToSend { get; private set; }

        // Constructeur

        public VoitureForm(String operation)
        {
            InitializeComponent();
            locationController = new LocationController();

            fillFunctionCombo();

            lblVoiture_operation.Text = operation;
            panel2.Hide();
            lblLoading.Hide();

            // Selection de l'affichage
            if (operation.Equals(VoitureForm.OPERATION_VOITURE_CREATION))
            {
                // Création
                setFieldsVisibility(false);
            }
            else
            {
                // Update
                setFieldsVisibility(true);
                setFieldStatus(false);
                btnVoiture_add.Text = VoitureForm.OPERATION_VOITURE_UPDATE;
            }            
        }

        private void fillFunctionCombo()
        {
            List<fabriquant> fabriquants = locationController.FabricantsService.GetAllFabriquants();
            foreach(fabriquant fab in fabriquants)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = fab.nom_fabriquant;
                item.Value = fab.fabriquantID;
                cbVoiture_Fabriquant.Items.Add(item);
            }

            cbVoiture_Fabriquant.SelectedIndex = 0;

            List<succursale> succursales = locationController.SuccursalesServices.getAllSuccursale();
            foreach(succursale succ in succursales)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = succ.nom;
                item.Value = succ.succursaleID;
                cbVoiture_succursale.Items.Add(item);
            }

            cbVoiture_succursale.SelectedIndex = 0;

        }

        // Méthodes

        #region BOUTONS

        /// <summary>
        /// Création d'un nouvel employé à l'aide des informations inscrites dans les champs
        /// </summary>        
        private void btnEmploye_add_Click(object sender, EventArgs e)
        {

            int modeleID        = (int)(cbVoiture_Modele.SelectedItem as ComboboxItem).Value;
            int fabricantId     = (int)(cbVoiture_Fabriquant.SelectedItem as ComboboxItem).Value;
            int succursaleID    = (int)(cbVoiture_succursale.SelectedItem as ComboboxItem).Value;

            string plaqueNumber = txtVoiture_noPlaque.Text;

            if (!plaqueNumber.Equals("") )
            {

                // Fonction ADD 
                if (!btnVoiture_add.Text.Equals(VoitureForm.OPERATION_VOITURE_UPDATE))
                {
                    vehicule addVehicule = new vehicule();

                    addVehicule.modeleID = modeleID;
                    addVehicule.fabriquantID = fabricantId;
                    addVehicule.succursaleID = succursaleID;
                    addVehicule.plaque_num = plaqueNumber;

                    if (locationController.VehiculeServices.AddVehicule(addVehicule))
                    {
                        emptyVehiculeFormFields();
                        this.DialogResult = DialogResult.OK;
                        messageToSend = "Le véhicule a été ajouté";
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                        messageToSend = "Une erreur est survenue lors de la creation du véhicule";
                        this.Close();
                    }
                }

                // Fonction UPDATE
                else
                {
                    string idToUpdate = txtVoiture_vehiculeID.Text;

                    employe employeToUpdate = locationController.EmployesService.Find(idToUpdate);

                    if (employeToUpdate != null)
                    {
                        //employeToUpdate.nom = nom;
                        //employeToUpdate.telephone        = telephone;
                        //employeToUpdate.adresse   = adresse;
                        //employeToUpdate.fonction = fonction;
                        //employeToUpdate.salaire_horaire = float.Parse(tauxHoraire);
                        //employeToUpdate.username = username;
                        //employeToUpdate.password = password;
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

            if (txtVoiture_idSearch.Text == "")
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
                searchValue = txtVoiture_idSearch.Text;

                Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
            }

            employe employeFound = locationController.EmployesService.Find(searchValue);

            // Affichage de l'employé
            if (employeFound != null)
            {

                btnEmploye_Delete.Visible = true;
                setFieldStatus(true);
                txtVoiture_vehiculeID.Enabled = false;

                txtVoiture_vehiculeID.Text       = employeFound.employeID.ToString();
                txtVoiture_noPlaque.Text         = employeFound.nom;
                //txtVoiture_tauxHoraire.Text = employeFound.salaire_horaire.ToString();
                //txtVoiture_phone.Text       = employeFound.telephone;
                //txtVoiture_adresse.Text     = employeFound.adresse;
                //txtVoiture_username.Text    = employeFound.username;
                //txtVoiture_password.Text    = employeFound.password;
                cbVoiture_Fabriquant.SelectedIndex = cbVoiture_Fabriquant.FindStringExact(employeFound.fonction);
                cbVoiture_succursale.SelectedIndex = cbVoiture_succursale.FindStringExact(employeFound.succursale.nom);
            }
            else
            {
                btnEmploye_Delete.Visible = false;
                emptyVehiculeFormFields();
                setFieldStatus(false);
            }
        }

        /// <summary>
        /// Efface un employé
        /// Si un employé est trouvé, un panneau de confirmation est ouvert afin de confirmer l'action
        /// </summary>        
        private void btnEmploye_Delete_Click(object sender, EventArgs e)
        {
            String searchValue = txtVoiture_vehiculeID.Text;
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
            String searchValue = txtVoiture_vehiculeID.Text;
            employe employeToDelete = locationController.EmployesService.Find(searchValue);

            if (employeToDelete != null)
            {
                Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);
                btnEmploye_Delete.Show();
                locationController.EmployesService.DeleteEmploye(employeToDelete);
                this.DialogResult = DialogResult.OK;

                // DELETE RÉUSSI
                messageToSend = VoitureForm.MESSAGE_VOITURE_DELETE;
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

        private void emptyVehiculeFormFields()
        {
            txtVoiture_vehiculeID.Text              = "";
            txtVoiture_idSearch.Text                = "";
            txtVoiture_noPlaque.Text                = "";       
            cbVoiture_Fabriquant.SelectedIndex      = 0;
            cbVoiture_succursale.SelectedIndex      = 0;
            cbVoiture_Modele.SelectedIndex          = -1;
        }

        private void setFieldsVisibility(bool visibilityChoice)
        {
            panelClientCreate_clientId.Visible  = visibilityChoice;
            lblClientCreate_clientId.Visible    = visibilityChoice;   
            btnVoiture_Find.Visible             = visibilityChoice;
            btnEmploye_Delete.Visible           = visibilityChoice;
            txtVoiture_idSearch.Visible         = visibilityChoice;
            txtVoiture_vehiculeID.Visible       = visibilityChoice;
            lblClientCreate_id.Visible          = visibilityChoice;
            panelClientForm_id.Visible          = visibilityChoice;
        }

        private void setFieldStatus(bool enabledStatus)
        {
            txtVoiture_vehiculeID.Enabled        = enabledStatus;
            txtVoiture_noPlaque.Enabled          = enabledStatus;
            cbVoiture_Fabriquant.Enabled        = enabledStatus;
            cbVoiture_succursale.Enabled        = enabledStatus;
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

        private void cbVoiture_Fabriquant_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbVoiture_Modele.Items.Clear();

                string fabricantID = (cbVoiture_Fabriquant.SelectedItem as ComboboxItem).Value.ToString();

                List<modele> modeles = locationController.ModelesServices.findBy(fabricantID, "fabricantID");
                foreach (modele mod in modeles)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = mod.nom_modele;
                    item.Value = mod.modeleID;
                    cbVoiture_Modele.Items.Add(item);
                }

                if (cbVoiture_Modele.Items.Count == 0)
                {
                    cbVoiture_Modele.SelectedIndex = -1;
                }
                else
                {
                    cbVoiture_Modele.SelectedIndex = 0;
                } 
        }
    }
}
