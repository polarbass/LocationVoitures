namespace LocationVoiture.Vues
{
    partial class VoitureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVoiture_Modele = new System.Windows.Forms.ComboBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVoiture_succursale = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVoiture_Fabriquant = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEmploye_Delete = new System.Windows.Forms.Button();
            this.lblClientCreate_clientId = new System.Windows.Forms.Label();
            this.panelClientCreate_clientId = new System.Windows.Forms.Panel();
            this.txtVoiture_vehiculeID = new System.Windows.Forms.TextBox();
            this.btnVoiture_Find = new System.Windows.Forms.Button();
            this.lblClientCreate_id = new System.Windows.Forms.Label();
            this.panelClientForm_id = new System.Windows.Forms.Panel();
            this.txtVoiture_idSearch = new System.Windows.Forms.TextBox();
            this.lblVoiture_operation = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtVoiture_noPlaque = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lblClientCreate_nom = new System.Windows.Forms.Label();
            this.btnVoiture_cancel = new System.Windows.Forms.Button();
            this.btnVoiture_add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelClientCreate_clientId.SuspendLayout();
            this.panelClientForm_id.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbVoiture_Modele);
            this.panel1.Controls.Add(this.lblLoading);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbVoiture_succursale);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbVoiture_Fabriquant);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnEmploye_Delete);
            this.panel1.Controls.Add(this.lblClientCreate_clientId);
            this.panel1.Controls.Add(this.panelClientCreate_clientId);
            this.panel1.Controls.Add(this.btnVoiture_Find);
            this.panel1.Controls.Add(this.lblClientCreate_id);
            this.panel1.Controls.Add(this.panelClientForm_id);
            this.panel1.Controls.Add(this.lblVoiture_operation);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.lblClientCreate_nom);
            this.panel1.Controls.Add(this.btnVoiture_cancel);
            this.panel1.Controls.Add(this.btnVoiture_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 517);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(34, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 126;
            this.label2.Text = "Modèle :";
            // 
            // cbVoiture_Modele
            // 
            this.cbVoiture_Modele.BackColor = System.Drawing.Color.Black;
            this.cbVoiture_Modele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoiture_Modele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbVoiture_Modele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVoiture_Modele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbVoiture_Modele.FormattingEnabled = true;
            this.cbVoiture_Modele.Location = new System.Drawing.Point(141, 268);
            this.cbVoiture_Modele.Name = "cbVoiture_Modele";
            this.cbVoiture_Modele.Size = new System.Drawing.Size(287, 29);
            this.cbVoiture_Modele.TabIndex = 125;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Teal;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(144, 100);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(135, 17);
            this.lblLoading.TabIndex = 124;
            this.lblLoading.Text = "Recherche en cours ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(17, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 123;
            this.label4.Text = "succursale :";
            // 
            // cbVoiture_succursale
            // 
            this.cbVoiture_succursale.BackColor = System.Drawing.Color.Black;
            this.cbVoiture_succursale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoiture_succursale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbVoiture_succursale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVoiture_succursale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbVoiture_succursale.FormattingEnabled = true;
            this.cbVoiture_succursale.Location = new System.Drawing.Point(141, 358);
            this.cbVoiture_succursale.Name = "cbVoiture_succursale";
            this.cbVoiture_succursale.Size = new System.Drawing.Size(287, 29);
            this.cbVoiture_succursale.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(25, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 117;
            this.label1.Text = "Fabricant :";
            // 
            // cbVoiture_Fabriquant
            // 
            this.cbVoiture_Fabriquant.BackColor = System.Drawing.Color.Black;
            this.cbVoiture_Fabriquant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoiture_Fabriquant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbVoiture_Fabriquant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVoiture_Fabriquant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbVoiture_Fabriquant.FormattingEnabled = true;
            this.cbVoiture_Fabriquant.Location = new System.Drawing.Point(141, 225);
            this.cbVoiture_Fabriquant.Name = "cbVoiture_Fabriquant";
            this.cbVoiture_Fabriquant.Size = new System.Drawing.Size(287, 29);
            this.cbVoiture_Fabriquant.TabIndex = 116;
            this.cbVoiture_Fabriquant.SelectedIndexChanged += new System.EventHandler(this.cbVoiture_Fabriquant_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.btnCANCEL);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(318, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 93);
            this.panel2.TabIndex = 106;
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.Black;
            this.btnCANCEL.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.Maroon;
            this.btnCANCEL.Location = new System.Drawing.Point(11, 51);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(91, 35);
            this.btnCANCEL.TabIndex = 107;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            this.btnCANCEL.MouseEnter += new System.EventHandler(this.mouseEnterEventHandlerRed);
            this.btnCANCEL.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandlerRed);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Black;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Maroon;
            this.btnOK.Location = new System.Drawing.Point(11, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 35);
            this.btnOK.TabIndex = 106;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseEnter += new System.EventHandler(this.mouseEnterEventHandlerRed);
            this.btnOK.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandlerRed);
            // 
            // btnEmploye_Delete
            // 
            this.btnEmploye_Delete.BackColor = System.Drawing.Color.Black;
            this.btnEmploye_Delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmploye_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploye_Delete.ForeColor = System.Drawing.Color.Maroon;
            this.btnEmploye_Delete.Location = new System.Drawing.Point(321, 172);
            this.btnEmploye_Delete.Name = "btnEmploye_Delete";
            this.btnEmploye_Delete.Size = new System.Drawing.Size(110, 32);
            this.btnEmploye_Delete.TabIndex = 105;
            this.btnEmploye_Delete.Text = "Effacer";
            this.btnEmploye_Delete.UseVisualStyleBackColor = false;
            this.btnEmploye_Delete.Click += new System.EventHandler(this.btnEmploye_Delete_Click);
            this.btnEmploye_Delete.MouseEnter += new System.EventHandler(this.mouseEnterEventHandlerRed);
            this.btnEmploye_Delete.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandlerRed);
            // 
            // lblClientCreate_clientId
            // 
            this.lblClientCreate_clientId.AutoSize = true;
            this.lblClientCreate_clientId.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_clientId.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_clientId.Location = new System.Drawing.Point(81, 176);
            this.lblClientCreate_clientId.Name = "lblClientCreate_clientId";
            this.lblClientCreate_clientId.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_clientId.TabIndex = 104;
            this.lblClientCreate_clientId.Text = "id :";
            // 
            // panelClientCreate_clientId
            // 
            this.panelClientCreate_clientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientCreate_clientId.Controls.Add(this.txtVoiture_vehiculeID);
            this.panelClientCreate_clientId.Location = new System.Drawing.Point(141, 172);
            this.panelClientCreate_clientId.Name = "panelClientCreate_clientId";
            this.panelClientCreate_clientId.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelClientCreate_clientId.Size = new System.Drawing.Size(170, 32);
            this.panelClientCreate_clientId.TabIndex = 103;
            // 
            // txtVoiture_vehiculeID
            // 
            this.txtVoiture_vehiculeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtVoiture_vehiculeID.BackColor = System.Drawing.Color.Black;
            this.txtVoiture_vehiculeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVoiture_vehiculeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoiture_vehiculeID.ForeColor = System.Drawing.Color.Silver;
            this.txtVoiture_vehiculeID.Location = new System.Drawing.Point(13, 4);
            this.txtVoiture_vehiculeID.Name = "txtVoiture_vehiculeID";
            this.txtVoiture_vehiculeID.Size = new System.Drawing.Size(142, 22);
            this.txtVoiture_vehiculeID.TabIndex = 1;
            // 
            // btnVoiture_Find
            // 
            this.btnVoiture_Find.BackColor = System.Drawing.Color.Teal;
            this.btnVoiture_Find.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVoiture_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoiture_Find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoiture_Find.ForeColor = System.Drawing.Color.Black;
            this.btnVoiture_Find.Location = new System.Drawing.Point(318, 63);
            this.btnVoiture_Find.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoiture_Find.Name = "btnVoiture_Find";
            this.btnVoiture_Find.Size = new System.Drawing.Size(113, 32);
            this.btnVoiture_Find.TabIndex = 102;
            this.btnVoiture_Find.Text = "TROUVER";
            this.btnVoiture_Find.UseVisualStyleBackColor = false;
            this.btnVoiture_Find.Click += new System.EventHandler(this.btnEmploye_Find_Click);
            // 
            // lblClientCreate_id
            // 
            this.lblClientCreate_id.AutoSize = true;
            this.lblClientCreate_id.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_id.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_id.Location = new System.Drawing.Point(79, 67);
            this.lblClientCreate_id.Name = "lblClientCreate_id";
            this.lblClientCreate_id.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_id.TabIndex = 101;
            this.lblClientCreate_id.Text = "id :";
            // 
            // panelClientForm_id
            // 
            this.panelClientForm_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientForm_id.Controls.Add(this.txtVoiture_idSearch);
            this.panelClientForm_id.Location = new System.Drawing.Point(141, 63);
            this.panelClientForm_id.Name = "panelClientForm_id";
            this.panelClientForm_id.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelClientForm_id.Size = new System.Drawing.Size(165, 32);
            this.panelClientForm_id.TabIndex = 100;
            // 
            // txtVoiture_idSearch
            // 
            this.txtVoiture_idSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtVoiture_idSearch.BackColor = System.Drawing.Color.Black;
            this.txtVoiture_idSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVoiture_idSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoiture_idSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtVoiture_idSearch.Location = new System.Drawing.Point(9, 4);
            this.txtVoiture_idSearch.Name = "txtVoiture_idSearch";
            this.txtVoiture_idSearch.Size = new System.Drawing.Size(146, 22);
            this.txtVoiture_idSearch.TabIndex = 1;
            // 
            // lblVoiture_operation
            // 
            this.lblVoiture_operation.AutoSize = true;
            this.lblVoiture_operation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoiture_operation.ForeColor = System.Drawing.Color.Teal;
            this.lblVoiture_operation.Location = new System.Drawing.Point(143, 14);
            this.lblVoiture_operation.Name = "lblVoiture_operation";
            this.lblVoiture_operation.Size = new System.Drawing.Size(214, 32);
            this.lblVoiture_operation.TabIndex = 4;
            this.lblVoiture_operation.Text = "Créer un véhicule";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtVoiture_noPlaque);
            this.panel10.Location = new System.Drawing.Point(141, 311);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel10.Size = new System.Drawing.Size(287, 32);
            this.panel10.TabIndex = 16;
            // 
            // txtVoiture_noPlaque
            // 
            this.txtVoiture_noPlaque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtVoiture_noPlaque.BackColor = System.Drawing.Color.Black;
            this.txtVoiture_noPlaque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVoiture_noPlaque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoiture_noPlaque.ForeColor = System.Drawing.Color.Silver;
            this.txtVoiture_noPlaque.Location = new System.Drawing.Point(13, 4);
            this.txtVoiture_noPlaque.Name = "txtVoiture_noPlaque";
            this.txtVoiture_noPlaque.Size = new System.Drawing.Size(259, 22);
            this.txtVoiture_noPlaque.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Gray;
            this.label32.Location = new System.Drawing.Point(143, 133);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(86, 25);
            this.label32.TabIndex = 31;
            this.label32.Text = "Véhicule";
            // 
            // lblClientCreate_nom
            // 
            this.lblClientCreate_nom.AutoSize = true;
            this.lblClientCreate_nom.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_nom.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_nom.Location = new System.Drawing.Point(9, 315);
            this.lblClientCreate_nom.Name = "lblClientCreate_nom";
            this.lblClientCreate_nom.Size = new System.Drawing.Size(108, 25);
            this.lblClientCreate_nom.TabIndex = 99;
            this.lblClientCreate_nom.Text = "No. Plaque :";
            // 
            // btnVoiture_cancel
            // 
            this.btnVoiture_cancel.BackColor = System.Drawing.Color.Black;
            this.btnVoiture_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVoiture_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoiture_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoiture_cancel.ForeColor = System.Drawing.Color.Teal;
            this.btnVoiture_cancel.Location = new System.Drawing.Point(316, 461);
            this.btnVoiture_cancel.Name = "btnVoiture_cancel";
            this.btnVoiture_cancel.Size = new System.Drawing.Size(113, 35);
            this.btnVoiture_cancel.TabIndex = 8;
            this.btnVoiture_cancel.Text = "Annuler";
            this.btnVoiture_cancel.UseVisualStyleBackColor = false;
            this.btnVoiture_cancel.Click += new System.EventHandler(this.txtClientCreate_cancel_Click);
            this.btnVoiture_cancel.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnVoiture_cancel.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnVoiture_add
            // 
            this.btnVoiture_add.BackColor = System.Drawing.Color.Black;
            this.btnVoiture_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVoiture_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoiture_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoiture_add.ForeColor = System.Drawing.Color.Teal;
            this.btnVoiture_add.Location = new System.Drawing.Point(192, 461);
            this.btnVoiture_add.Name = "btnVoiture_add";
            this.btnVoiture_add.Size = new System.Drawing.Size(113, 35);
            this.btnVoiture_add.TabIndex = 7;
            this.btnVoiture_add.Text = "Ajouter";
            this.btnVoiture_add.UseVisualStyleBackColor = false;
            this.btnVoiture_add.Click += new System.EventHandler(this.btnEmploye_add_Click);
            this.btnVoiture_add.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnVoiture_add.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(194, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 127;
            this.label5.Text = "image :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(263, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 128;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // VoitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(460, 517);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoitureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelClientCreate_clientId.ResumeLayout(false);
            this.panelClientCreate_clientId.PerformLayout();
            this.panelClientForm_id.ResumeLayout(false);
            this.panelClientForm_id.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVoiture_operation;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtVoiture_noPlaque;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblClientCreate_nom;
        private System.Windows.Forms.Button btnVoiture_cancel;
        private System.Windows.Forms.Button btnVoiture_add;
        private System.Windows.Forms.Button btnVoiture_Find;
        private System.Windows.Forms.Label lblClientCreate_id;
        private System.Windows.Forms.Panel panelClientForm_id;
        private System.Windows.Forms.TextBox txtVoiture_idSearch;
        private System.Windows.Forms.Label lblClientCreate_clientId;
        private System.Windows.Forms.Panel panelClientCreate_clientId;
        private System.Windows.Forms.TextBox txtVoiture_vehiculeID;
        private System.Windows.Forms.Button btnEmploye_Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVoiture_Fabriquant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVoiture_succursale;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVoiture_Modele;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}