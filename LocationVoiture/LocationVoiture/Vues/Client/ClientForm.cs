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
    public partial class ClientForm : Form
    {

        // Attributs

        private const string OPERATION_CLIENT_CREATION  = "Création";
        private const string OPERATION_CLIENT_UPDATE    = "Updater";
        private const string MESSAGE_CLIENT_ADD         = "Le client a été ajouté";
        private const string MESSAGE_ERREUR_ADD         = "Une erreur est survenue lors de la creation du client";
        private const string MESSAGE_CLIENT_UPDATE      = "Le client a été modifé";
        private const string MESSAGE_CLIENT_DELETE      = "Le client a été effacé";        

        // Propriétés

        private LocationController locationController { get; set; }
        
        public client clientAdded { get; private set; }
        public string messageToSend { get; private set; }

        // Constructeur

        public ClientForm(String operation)
        {
            InitializeComponent();
            locationController = new LocationController();

            lblClientCreate_operation.Text = operation;
            panel2.Hide();

            // Selection de l'affichage
            if (operation.Equals(OPERATION_CLIENT_CREATION))
            {
                // Création
                setFieldsVisibility(false);
            }
            else
            {
                // Update
                setFieldsVisibility(true);
                setFieldStatus(false);
                btnClientCreate_add.Text = ClientForm.OPERATION_CLIENT_UPDATE;
            }            
        }

        // Méthodes

        #region BOUTONS

        /// <summary>
        /// Création d'un nouveau client à l'aide des informations inscrites dans les champs
        /// </summary>        
        private void btnClientCreate_add_Click(object sender, EventArgs e)
        {

            String nom          = txtClientCreate_nom.Text;
            String prenom       = txtClientCreate_prenom.Text;
            String telephone    = txtClientCreate_phone.Text;
            String adresse      = txtClientCreate_adresse.Text;
            String courriel     = txtClientCreate_email.Text;

            if (!nom.Equals("") && !prenom.Equals("") && !telephone.Equals("") && !adresse.Equals("") && !courriel.Equals(""))
            {

                // Fonction ADD 
                if (!btnClientCreate_add.Text.Equals(ClientForm.OPERATION_CLIENT_UPDATE))
                {

                    client addClient = new client();

                    addClient.nom               = nom;
                    addClient.prenom            = prenom;
                    addClient.telephone         = telephone;
                    addClient.adresse_client    = adresse;
                    addClient.courriel          = courriel;

                    if (locationController.ClientsServices.AddClient(addClient))
                    {
                        emptyClientFormFields();
                        clientAdded = addClient;
                        this.DialogResult = DialogResult.OK;

                        // ADD DU CLIENT RÉUSSI
                        messageToSend = ClientForm.MESSAGE_CLIENT_ADD;

                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;

                        // ERREUR DANS LE ADD CLIENT
                        messageToSend = ClientForm.MESSAGE_ERREUR_ADD;

                        this.Close();
                    }
                }

                // Fonction UPDATE
                else
                {
                    string idToUpdate = txtClientCreate_clientId.Text;

                    client clientToUpdate = locationController.ClientsServices.Find(idToUpdate);
                    if (clientToUpdate != null)
                    {

                        clientToUpdate.nom              = nom;
                        clientToUpdate.prenom           = prenom;
                        clientToUpdate.telephone        = telephone;
                        clientToUpdate.adresse_client   = adresse;
                        clientToUpdate.courriel         = courriel;
                    }

                    locationController.ClientsServices.Save();
                    this.DialogResult = DialogResult.OK;   
                             
                    // CLIENT UPDATER        
                    messageToSend = ClientForm.MESSAGE_CLIENT_UPDATE;
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

            if (txtClientCreate_idSearch.Text == "")
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
                searchValue = txtClientCreate_idSearch.Text;
            }

            client clientToUpdate = locationController.ClientsServices.Find(searchValue);

            // Update du client
            if (clientToUpdate != null)
            {

                btnClientCreate_Delete.Visible = true;
                setFieldStatus(true);
                txtClientCreate_clientId.Enabled = false;

                txtClientCreate_clientId.Text   = clientToUpdate.clientID.ToString();
                txtClientCreate_nom.Text        = clientToUpdate.nom;
                txtClientCreate_prenom.Text     = clientToUpdate.prenom;
                txtClientCreate_phone.Text      = clientToUpdate.telephone;
                txtClientCreate_adresse.Text    = clientToUpdate.adresse_client;
                txtClientCreate_email.Text      = clientToUpdate.courriel;
            }
            else
            {
                btnClientCreate_Delete.Visible = false;
                emptyClientFormFields();
            }
        }

        /// <summary>
        /// Efface un client
        /// Si un client est trouvé, un panneau de confirmation est ouvert afin de confirmer l'action
        /// </summary>        
        private void btnClientCreate_Delete_Click(object sender, EventArgs e)
        {
            String searchValue = txtClientCreate_clientId.Text;
            client clientToDelete = locationController.ClientsServices.Find(searchValue);

            if (clientToDelete != null)
            {
                btnClientCreate_Delete.Hide();
                Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);   
            }
        }

        /// <summary>
        /// Confirmation du delete du client
        /// </summary>        
        private void btnOK_Click(object sender, EventArgs e)
        {
            String searchValue = txtClientCreate_clientId.Text;
            client clientToDelete = locationController.ClientsServices.Find(searchValue);

            if (clientToDelete != null)
            {
                Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);
                btnClientCreate_Delete.Show();
                locationController.ClientsServices.DeleteClient(clientToDelete);
                this.DialogResult = DialogResult.OK;

                // DELETE RÉUSSI
                messageToSend = ClientForm.MESSAGE_CLIENT_DELETE;
                this.Close();
            }
        }

        /// <summary>
        /// Cancel le delete du client
        /// </summary>        
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Animations.Animate(panel2, Animations.Effect.Slide, 300, 360);
            btnClientCreate_Delete.Show();
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
            txtClientCreate_clientId.Text   = "";
            txtClientCreate_idSearch.Text   = "";
            txtClientCreate_nom.Text        = "";
            txtClientCreate_prenom.Text     = "";
            txtClientCreate_phone.Text      = "";
            txtClientCreate_adresse.Text    = "";
            txtClientCreate_email.Text      = "";
        }

        private void setFieldsVisibility(bool visibilityChoice)
        {
            panelClientCreate_clientId.Visible  = visibilityChoice;
            lblClientCreate_clientId.Visible    = visibilityChoice;   
            btnClientForm_Find.Visible          = visibilityChoice;
            btnClientCreate_Delete.Visible      = false;
            txtClientCreate_idSearch.Visible    = visibilityChoice;
            txtClientCreate_clientId.Enabled    = visibilityChoice;
            lblClientCreate_id.Visible          = visibilityChoice;
            panelClientForm_id.Visible          = visibilityChoice;
        }

        private void setFieldStatus(bool enabledStatus)
        {
            txtClientCreate_clientId.Enabled    = enabledStatus;
            txtClientCreate_nom.Enabled         = enabledStatus;
            txtClientCreate_prenom.Enabled      = enabledStatus;
            txtClientCreate_phone.Enabled       = enabledStatus;
            txtClientCreate_adresse.Enabled     = enabledStatus;
            txtClientCreate_email.Enabled       = enabledStatus;
        }

        private void mouseEnterEventHandler(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Teal;
            button.ForeColor = Color.Black;
        }

        private void mouseLeaveEventHandler(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Black;
            button.ForeColor = Color.Teal;
        }

        private void mouseEnterEventHandlerRed(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Maroon;
            button.ForeColor = Color.Black;
        }

        private void mouseLeaveEventHandlerRed(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Black;
            button.ForeColor = Color.Maroon;
        }

        #endregion UTILITAIRES

    }
}
