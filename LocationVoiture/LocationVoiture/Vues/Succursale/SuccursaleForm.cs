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
    public partial class SuccursaleForm : Form
    {

        // Attributs

        private const string OPERATION_SUCCURSALE_CREATION      = "Création";
        private const string OPERATION_SUCCURSALE_UPDATE        = "Updater";
        private const string MESSAGE_SUCCURSALE_ADD             = "La succursale a été ajouté";
        private const string MESSAGE_SUCCURSALE_ADD_ERROR       = "Une erreur est survenue lors de la creation de la succursale";
        private const string MESSAGE_SUCCURSALE_UPDATE          = "La succursale a été modifée";
        private const string MESSAGE_SUCCURSALE_UPDATE_ERROR    = "Une erreur est survenu lors de la mise à jour de la succursale";
        private const string MESSAGE_SUCCURSALE_DELETE          = "La succursale a été effacée";        

        // Propriétés

        private LocationController locationController { get; set; }
        
        public client succursaleAdded { get; private set; }
        public string messageToSend { get; private set; }

        // Constructeur

        public SuccursaleForm(String operation)
        {
            InitializeComponent();
            locationController = new LocationController();

            lblSuccursale_operation.Text = operation;
            panel2.Hide();
            lblLoading.Hide();

            // Selection de l'affichage
            if (operation.Equals(SuccursaleForm.OPERATION_SUCCURSALE_CREATION))
            {
                // Création
                setFieldsVisibility(false);
            }
            else
            {
                // Update
                setFieldsVisibility(true);
                setFieldStatus(false);
                btnSuccursale_add.Text = SuccursaleForm.OPERATION_SUCCURSALE_UPDATE;
            }            
        }

        // Méthodes

        #region BOUTONS

        /// <summary>
        /// Création d'une nouvelle succursale à l'aide des informations inscrites dans les champs
        /// </summary>        
        private void btnSuccursale_add_Click(object sender, EventArgs e)
        {

            String nom          = txtSuccursale_nom.Text;
            String telephone    = txtSuccursale_phone.Text;
            String adresse      = txtSuccursale_adresse.Text;
            String courriel     = txtSuccursale_courriel.Text;        

            if (!nom.Equals("") && !telephone.Equals("") && !adresse.Equals("") && !courriel.Equals(""))
            {

                // Fonction ADD 
                if (!btnSuccursale_add.Text.Equals(SuccursaleForm.OPERATION_SUCCURSALE_UPDATE))
                {
                    succursale addSuccursale = new succursale();

                    addSuccursale.nom           = nom;
                    addSuccursale.telephone     = telephone;
                    addSuccursale.addresse      = adresse;
                    addSuccursale.courriel      = courriel;

                    if (locationController.SuccursalesServices.addSuccursale(addSuccursale))
                    {
                        emptySuccursaleFormFields();
                        this.DialogResult = DialogResult.OK;
                        messageToSend = SuccursaleForm.MESSAGE_SUCCURSALE_ADD;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                        messageToSend = SuccursaleForm.MESSAGE_SUCCURSALE_ADD_ERROR;
                        this.Close();
                    }
                }

                // Fonction UPDATE
                else
                {
                    string idToUpdate = txtSuccursale_succursaleID.Text;

                    succursale succursaleToUpdate = locationController.SuccursalesServices.Find(idToUpdate);

                    if (succursaleToUpdate != null)
                    {
                        succursaleToUpdate.nom          = nom;
                        succursaleToUpdate.telephone    = telephone;
                        succursaleToUpdate.addresse     = adresse;
                        succursaleToUpdate.courriel     = courriel;
                    }                   

                    if (locationController.SuccursalesServices.Save())
                    {
                        this.DialogResult = DialogResult.OK;
                        messageToSend = SuccursaleForm.MESSAGE_SUCCURSALE_UPDATE;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                        messageToSend = SuccursaleForm.MESSAGE_SUCCURSALE_UPDATE_ERROR;
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
        /// Recherche d'une succursale afin de modifier ses informations.
        /// Si le champ est vide, un nouveau formulaire de recherche est lancé afin de permettre la recherche à l'aide de plus de champs
        /// Sinon, la recherche est effectuée à l'aide de l'id de la succursale.
        /// </summary>        
        private void btnSuccursale_Find_Click(object sender, EventArgs e)
        {
            String searchValue = "";

            if (txtSuccursale_idSearch.Text == "")
            {
                this.Opacity = 0.1;

                SuccursaleSearch searchForm = new SuccursaleSearch();
                searchForm.Owner = this;
                searchForm.ShowDialog();

                // récupération du ID sélectionner dans le searchForm
                searchValue = searchForm.succursaleSearchID;

                this.Opacity = 1;
            }
            else
            {
                Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);

                // le id est lu directement dans le champ
                searchValue = txtSuccursale_idSearch.Text;

                Animations.Animate(lblLoading, Animations.Effect.Slide, 50, 360);
            }

            succursale succursaleFound = locationController.SuccursalesServices.Find(searchValue);

            // Affichage de la succursale
            if (succursaleFound != null)
            {

                btnSuccursale_Delete.Visible = true;
                setFieldStatus(true);
                txtSuccursale_succursaleID.Enabled = false;

                txtSuccursale_succursaleID.Text = succursaleFound.succursaleID.ToString();
                txtSuccursale_nom.Text          = succursaleFound.nom;
                txtSuccursale_adresse.Text      = succursaleFound.addresse;
                txtSuccursale_courriel.Text     = succursaleFound.courriel;
                txtSuccursale_phone.Text        = succursaleFound.telephone;

            }
            else
            {
                btnSuccursale_Delete.Visible = false;
                emptySuccursaleFormFields();
                setFieldStatus(false);
            }
        }

        /// <summary>
        /// Efface une succursale
        /// Si une succursales est trouvée, un panneau de confirmation est ouvert afin de confirmer l'action
        /// </summary>        
        private void btnEmploye_Delete_Click(object sender, EventArgs e)
        {
            String searchValue = txtSuccursale_succursaleID.Text;
            succursale succursaleToDelete = locationController.SuccursalesServices.Find(searchValue);

            if (succursaleToDelete != null)
            {
                btnSuccursale_Delete.Hide();
                Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);   
            }
        }

        /// <summary>
        /// Confirmation du delete de la succursale
        /// </summary>        
        private void btnOK_Click(object sender, EventArgs e)
        {
            String searchValue = txtSuccursale_succursaleID.Text;
            succursale succursaleToDelete = locationController.SuccursalesServices.Find(searchValue);
            MessageBox.Show("Deleting : " + searchValue + " - " + succursaleToDelete.nom);

            if (succursaleToDelete != null)
            {
                MessageBox.Show("ready to delete");
                Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);
                btnSuccursale_Delete.Show();
                locationController.SuccursalesServices.Delete(succursaleToDelete);
                this.DialogResult = DialogResult.OK;

                // DELETE RÉUSSI
                messageToSend = SuccursaleForm.MESSAGE_SUCCURSALE_DELETE;
                this.Close();
            }
        }

        /// <summary>
        /// Cancel le delete de la succursale
        /// </summary>        
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);
            btnSuccursale_Delete.Show();
        }

        /// <summary>
        /// Cancel la création d'une succursale (fermeture du formulaire)
        /// </summary>       
        private void txtClientCreate_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BOUTONS

        #region UTILITAIRES

        private void emptySuccursaleFormFields()
        {
            txtSuccursale_succursaleID.Text    = "";
            txtSuccursale_idSearch.Text        = "";
            txtSuccursale_nom.Text             = "";
            txtSuccursale_phone.Text           = "";
            txtSuccursale_adresse.Text         = "";
            txtSuccursale_courriel.Text        = "";
        }

        private void setFieldsVisibility(bool visibilityChoice)
        {
            panelClientCreate_clientId.Visible  = visibilityChoice;
            lblClientCreate_clientId.Visible    = visibilityChoice;   
            btnSuccursale_Find.Visible          = visibilityChoice;
            btnSuccursale_Delete.Visible        = visibilityChoice;
            txtSuccursale_idSearch.Visible      = visibilityChoice;
            txtSuccursale_succursaleID.Visible  = visibilityChoice;
            lblClientCreate_id.Visible          = visibilityChoice;
            panelClientForm_id.Visible          = visibilityChoice;
            btnSuccursale_Delete.Visible        = false;
        }

        private void setFieldStatus(bool enabledStatus)
        {
            txtSuccursale_succursaleID.Enabled = enabledStatus;
            txtSuccursale_nom.Enabled          = enabledStatus;
            txtSuccursale_phone.Enabled        = enabledStatus;
            txtSuccursale_adresse.Enabled      = enabledStatus;
            txtSuccursale_courriel.Enabled     = enabledStatus;
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

        private void mouseEnterEventHandlerRed(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.White;
            button.ForeColor = Color.Maroon;
        }

        private void mouseLeaveEventHandlerRed(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Maroon;
            button.ForeColor = Color.White;
        }

        #endregion UTILITAIRES
    }
}
