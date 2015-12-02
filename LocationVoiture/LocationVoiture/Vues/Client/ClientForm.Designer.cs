namespace LocationVoiture.Vues
{
    partial class ClientForm
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
            this.btnClientCreate_Delete = new System.Windows.Forms.Button();
            this.lblClientCreate_clientId = new System.Windows.Forms.Label();
            this.panelClientCreate_clientId = new System.Windows.Forms.Panel();
            this.txtClientCreate_clientId = new System.Windows.Forms.TextBox();
            this.btnClientForm_Find = new System.Windows.Forms.Button();
            this.lblClientCreate_id = new System.Windows.Forms.Label();
            this.panelClientForm_id = new System.Windows.Forms.Panel();
            this.txtClientCreate_idSearch = new System.Windows.Forms.TextBox();
            this.lblClientCreate_operation = new System.Windows.Forms.Label();
            this.lblClientCreate_phone = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtClientCreate_phone = new System.Windows.Forms.TextBox();
            this.lblClientCreate_adresse = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtClientCreate_adresse = new System.Windows.Forms.TextBox();
            this.lblClientCreate_prenom = new System.Windows.Forms.Label();
            this.lblClientCreate_email = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtClientCreate_prenom = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtClientCreate_email = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtClientCreate_nom = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lblClientCreate_nom = new System.Windows.Forms.Label();
            this.txtClientCreate_cancel = new System.Windows.Forms.Button();
            this.btnClientCreate_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelClientCreate_clientId.SuspendLayout();
            this.panelClientForm_id.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnClientCreate_Delete);
            this.panel1.Controls.Add(this.lblClientCreate_clientId);
            this.panel1.Controls.Add(this.panelClientCreate_clientId);
            this.panel1.Controls.Add(this.btnClientForm_Find);
            this.panel1.Controls.Add(this.lblClientCreate_id);
            this.panel1.Controls.Add(this.panelClientForm_id);
            this.panel1.Controls.Add(this.lblClientCreate_operation);
            this.panel1.Controls.Add(this.lblClientCreate_phone);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.lblClientCreate_adresse);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.lblClientCreate_prenom);
            this.panel1.Controls.Add(this.lblClientCreate_email);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.lblClientCreate_nom);
            this.panel1.Controls.Add(this.txtClientCreate_cancel);
            this.panel1.Controls.Add(this.btnClientCreate_add);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 510);
            this.panel1.TabIndex = 0;
            // 
            // btnClientCreate_Delete
            // 
            this.btnClientCreate_Delete.BackColor = System.Drawing.Color.Black;
            this.btnClientCreate_Delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClientCreate_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientCreate_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCreate_Delete.ForeColor = System.Drawing.Color.Maroon;
            this.btnClientCreate_Delete.Location = new System.Drawing.Point(321, 172);
            this.btnClientCreate_Delete.Name = "btnClientCreate_Delete";
            this.btnClientCreate_Delete.Size = new System.Drawing.Size(110, 32);
            this.btnClientCreate_Delete.TabIndex = 105;
            this.btnClientCreate_Delete.Text = "Effacer";
            this.btnClientCreate_Delete.UseVisualStyleBackColor = false;
            this.btnClientCreate_Delete.Click += new System.EventHandler(this.btnClientCreate_Delete_Click);
            this.btnClientCreate_Delete.MouseEnter += new System.EventHandler(this.mouseEnterEventHandlerRed);
            this.btnClientCreate_Delete.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandlerRed);
            // 
            // lblClientCreate_clientId
            // 
            this.lblClientCreate_clientId.AutoSize = true;
            this.lblClientCreate_clientId.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_clientId.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_clientId.Location = new System.Drawing.Point(72, 176);
            this.lblClientCreate_clientId.Name = "lblClientCreate_clientId";
            this.lblClientCreate_clientId.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_clientId.TabIndex = 104;
            this.lblClientCreate_clientId.Text = "id :";
            // 
            // panelClientCreate_clientId
            // 
            this.panelClientCreate_clientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientCreate_clientId.Controls.Add(this.txtClientCreate_clientId);
            this.panelClientCreate_clientId.Location = new System.Drawing.Point(143, 172);
            this.panelClientCreate_clientId.Name = "panelClientCreate_clientId";
            this.panelClientCreate_clientId.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelClientCreate_clientId.Size = new System.Drawing.Size(170, 32);
            this.panelClientCreate_clientId.TabIndex = 103;
            // 
            // txtClientCreate_clientId
            // 
            this.txtClientCreate_clientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_clientId.BackColor = System.Drawing.Color.Black;
            this.txtClientCreate_clientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_clientId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_clientId.ForeColor = System.Drawing.Color.Silver;
            this.txtClientCreate_clientId.Location = new System.Drawing.Point(13, 4);
            this.txtClientCreate_clientId.Name = "txtClientCreate_clientId";
            this.txtClientCreate_clientId.Size = new System.Drawing.Size(142, 22);
            this.txtClientCreate_clientId.TabIndex = 1;
            // 
            // btnClientForm_Find
            // 
            this.btnClientForm_Find.BackColor = System.Drawing.Color.Teal;
            this.btnClientForm_Find.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClientForm_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientForm_Find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientForm_Find.ForeColor = System.Drawing.Color.Black;
            this.btnClientForm_Find.Location = new System.Drawing.Point(318, 63);
            this.btnClientForm_Find.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientForm_Find.Name = "btnClientForm_Find";
            this.btnClientForm_Find.Size = new System.Drawing.Size(113, 32);
            this.btnClientForm_Find.TabIndex = 102;
            this.btnClientForm_Find.Text = "TROUVER";
            this.btnClientForm_Find.UseVisualStyleBackColor = false;
            this.btnClientForm_Find.Click += new System.EventHandler(this.btnClientForm_Find_Click);
            // 
            // lblClientCreate_id
            // 
            this.lblClientCreate_id.AutoSize = true;
            this.lblClientCreate_id.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_id.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_id.Location = new System.Drawing.Point(72, 67);
            this.lblClientCreate_id.Name = "lblClientCreate_id";
            this.lblClientCreate_id.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_id.TabIndex = 101;
            this.lblClientCreate_id.Text = "id :";
            // 
            // panelClientForm_id
            // 
            this.panelClientForm_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientForm_id.Controls.Add(this.txtClientCreate_idSearch);
            this.panelClientForm_id.Location = new System.Drawing.Point(143, 63);
            this.panelClientForm_id.Name = "panelClientForm_id";
            this.panelClientForm_id.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelClientForm_id.Size = new System.Drawing.Size(165, 32);
            this.panelClientForm_id.TabIndex = 100;
            // 
            // txtClientCreate_idSearch
            // 
            this.txtClientCreate_idSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_idSearch.BackColor = System.Drawing.Color.Black;
            this.txtClientCreate_idSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_idSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_idSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtClientCreate_idSearch.Location = new System.Drawing.Point(9, 4);
            this.txtClientCreate_idSearch.Name = "txtClientCreate_idSearch";
            this.txtClientCreate_idSearch.Size = new System.Drawing.Size(146, 22);
            this.txtClientCreate_idSearch.TabIndex = 1;
            // 
            // lblClientCreate_operation
            // 
            this.lblClientCreate_operation.AutoSize = true;
            this.lblClientCreate_operation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_operation.ForeColor = System.Drawing.Color.Teal;
            this.lblClientCreate_operation.Location = new System.Drawing.Point(143, 14);
            this.lblClientCreate_operation.Name = "lblClientCreate_operation";
            this.lblClientCreate_operation.Size = new System.Drawing.Size(183, 32);
            this.lblClientCreate_operation.TabIndex = 4;
            this.lblClientCreate_operation.Text = "Créer un client";
            // 
            // lblClientCreate_phone
            // 
            this.lblClientCreate_phone.AutoSize = true;
            this.lblClientCreate_phone.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_phone.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_phone.Location = new System.Drawing.Point(5, 313);
            this.lblClientCreate_phone.Name = "lblClientCreate_phone";
            this.lblClientCreate_phone.Size = new System.Drawing.Size(103, 25);
            this.lblClientCreate_phone.TabIndex = 99;
            this.lblClientCreate_phone.Text = "téléphone :";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtClientCreate_phone);
            this.panel13.Location = new System.Drawing.Point(144, 309);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel13.Size = new System.Drawing.Size(287, 32);
            this.panel13.TabIndex = 45;
            // 
            // txtClientCreate_phone
            // 
            this.txtClientCreate_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_phone.BackColor = System.Drawing.Color.Black;
            this.txtClientCreate_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_phone.ForeColor = System.Drawing.Color.Silver;
            this.txtClientCreate_phone.Location = new System.Drawing.Point(13, 3);
            this.txtClientCreate_phone.Name = "txtClientCreate_phone";
            this.txtClientCreate_phone.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_phone.TabIndex = 3;
            // 
            // lblClientCreate_adresse
            // 
            this.lblClientCreate_adresse.AutoSize = true;
            this.lblClientCreate_adresse.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_adresse.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_adresse.Location = new System.Drawing.Point(27, 411);
            this.lblClientCreate_adresse.Name = "lblClientCreate_adresse";
            this.lblClientCreate_adresse.Size = new System.Drawing.Size(81, 25);
            this.lblClientCreate_adresse.TabIndex = 99;
            this.lblClientCreate_adresse.Text = "adresse :";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.txtClientCreate_adresse);
            this.panel12.Location = new System.Drawing.Point(144, 407);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel12.Size = new System.Drawing.Size(287, 32);
            this.panel12.TabIndex = 43;
            // 
            // txtClientCreate_adresse
            // 
            this.txtClientCreate_adresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_adresse.BackColor = System.Drawing.Color.Black;
            this.txtClientCreate_adresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_adresse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_adresse.ForeColor = System.Drawing.Color.Silver;
            this.txtClientCreate_adresse.Location = new System.Drawing.Point(13, 3);
            this.txtClientCreate_adresse.Name = "txtClientCreate_adresse";
            this.txtClientCreate_adresse.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_adresse.TabIndex = 5;
            // 
            // lblClientCreate_prenom
            // 
            this.lblClientCreate_prenom.AutoSize = true;
            this.lblClientCreate_prenom.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_prenom.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_prenom.Location = new System.Drawing.Point(23, 221);
            this.lblClientCreate_prenom.Name = "lblClientCreate_prenom";
            this.lblClientCreate_prenom.Size = new System.Drawing.Size(85, 25);
            this.lblClientCreate_prenom.TabIndex = 99;
            this.lblClientCreate_prenom.Text = "prénom :";
            // 
            // lblClientCreate_email
            // 
            this.lblClientCreate_email.AutoSize = true;
            this.lblClientCreate_email.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_email.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_email.Location = new System.Drawing.Point(28, 362);
            this.lblClientCreate_email.Name = "lblClientCreate_email";
            this.lblClientCreate_email.Size = new System.Drawing.Size(80, 25);
            this.lblClientCreate_email.TabIndex = 99;
            this.lblClientCreate_email.Text = "courriel :";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtClientCreate_prenom);
            this.panel11.Location = new System.Drawing.Point(144, 217);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel11.Size = new System.Drawing.Size(287, 32);
            this.panel11.TabIndex = 14;
            // 
            // txtClientCreate_prenom
            // 
            this.txtClientCreate_prenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_prenom.BackColor = System.Drawing.Color.Black;
            this.txtClientCreate_prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_prenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_prenom.ForeColor = System.Drawing.Color.Silver;
            this.txtClientCreate_prenom.Location = new System.Drawing.Point(13, 4);
            this.txtClientCreate_prenom.Name = "txtClientCreate_prenom";
            this.txtClientCreate_prenom.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_prenom.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txtClientCreate_email);
            this.panel9.Location = new System.Drawing.Point(144, 358);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel9.Size = new System.Drawing.Size(287, 32);
            this.panel9.TabIndex = 41;
            // 
            // txtClientCreate_email
            // 
            this.txtClientCreate_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_email.BackColor = System.Drawing.Color.Black;
            this.txtClientCreate_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_email.ForeColor = System.Drawing.Color.Silver;
            this.txtClientCreate_email.Location = new System.Drawing.Point(13, 3);
            this.txtClientCreate_email.Name = "txtClientCreate_email";
            this.txtClientCreate_email.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_email.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtClientCreate_nom);
            this.panel10.Location = new System.Drawing.Point(144, 262);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel10.Size = new System.Drawing.Size(287, 32);
            this.panel10.TabIndex = 16;
            // 
            // txtClientCreate_nom
            // 
            this.txtClientCreate_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_nom.BackColor = System.Drawing.Color.Black;
            this.txtClientCreate_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_nom.ForeColor = System.Drawing.Color.Silver;
            this.txtClientCreate_nom.Location = new System.Drawing.Point(13, 3);
            this.txtClientCreate_nom.Name = "txtClientCreate_nom";
            this.txtClientCreate_nom.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_nom.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Gray;
            this.label32.Location = new System.Drawing.Point(143, 133);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 25);
            this.label32.TabIndex = 31;
            this.label32.Text = "Client";
            // 
            // lblClientCreate_nom
            // 
            this.lblClientCreate_nom.AutoSize = true;
            this.lblClientCreate_nom.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_nom.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_nom.Location = new System.Drawing.Point(50, 266);
            this.lblClientCreate_nom.Name = "lblClientCreate_nom";
            this.lblClientCreate_nom.Size = new System.Drawing.Size(58, 25);
            this.lblClientCreate_nom.TabIndex = 99;
            this.lblClientCreate_nom.Text = "nom :";
            // 
            // txtClientCreate_cancel
            // 
            this.txtClientCreate_cancel.BackColor = System.Drawing.Color.Black;
            this.txtClientCreate_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtClientCreate_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClientCreate_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_cancel.ForeColor = System.Drawing.Color.Teal;
            this.txtClientCreate_cancel.Location = new System.Drawing.Point(318, 461);
            this.txtClientCreate_cancel.Name = "txtClientCreate_cancel";
            this.txtClientCreate_cancel.Size = new System.Drawing.Size(113, 35);
            this.txtClientCreate_cancel.TabIndex = 8;
            this.txtClientCreate_cancel.Text = "Annuler";
            this.txtClientCreate_cancel.UseVisualStyleBackColor = false;
            this.txtClientCreate_cancel.Click += new System.EventHandler(this.txtClientCreate_cancel_Click);
            this.txtClientCreate_cancel.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.txtClientCreate_cancel.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnClientCreate_add
            // 
            this.btnClientCreate_add.BackColor = System.Drawing.Color.Black;
            this.btnClientCreate_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClientCreate_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientCreate_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCreate_add.ForeColor = System.Drawing.Color.Teal;
            this.btnClientCreate_add.Location = new System.Drawing.Point(194, 461);
            this.btnClientCreate_add.Name = "btnClientCreate_add";
            this.btnClientCreate_add.Size = new System.Drawing.Size(113, 35);
            this.btnClientCreate_add.TabIndex = 7;
            this.btnClientCreate_add.Text = "Ajouter";
            this.btnClientCreate_add.UseVisualStyleBackColor = false;
            this.btnClientCreate_add.Click += new System.EventHandler(this.btnClientCreate_add_Click);
            this.btnClientCreate_add.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnClientCreate_add.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.btnCANCEL);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(458, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 510);
            this.panel2.TabIndex = 106;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Black;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Maroon;
            this.btnOK.Location = new System.Drawing.Point(13, 171);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 35);
            this.btnOK.TabIndex = 106;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseEnter += new System.EventHandler(this.mouseEnterEventHandlerRed);
            this.btnOK.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandlerRed);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.Black;
            this.btnCANCEL.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.Maroon;
            this.btnCANCEL.Location = new System.Drawing.Point(13, 212);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(91, 35);
            this.btnCANCEL.TabIndex = 107;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            this.btnCANCEL.MouseEnter += new System.EventHandler(this.mouseEnterEventHandlerRed);
            this.btnCANCEL.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandlerRed);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(574, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelClientCreate_clientId.ResumeLayout(false);
            this.panelClientCreate_clientId.PerformLayout();
            this.panelClientForm_id.ResumeLayout(false);
            this.panelClientForm_id.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClientCreate_operation;
        private System.Windows.Forms.Label lblClientCreate_phone;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtClientCreate_phone;
        private System.Windows.Forms.Label lblClientCreate_adresse;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtClientCreate_adresse;
        private System.Windows.Forms.Label lblClientCreate_prenom;
        private System.Windows.Forms.Label lblClientCreate_email;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtClientCreate_prenom;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtClientCreate_email;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtClientCreate_nom;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblClientCreate_nom;
        private System.Windows.Forms.Button txtClientCreate_cancel;
        private System.Windows.Forms.Button btnClientCreate_add;
        private System.Windows.Forms.Button btnClientForm_Find;
        private System.Windows.Forms.Label lblClientCreate_id;
        private System.Windows.Forms.Panel panelClientForm_id;
        private System.Windows.Forms.TextBox txtClientCreate_idSearch;
        private System.Windows.Forms.Label lblClientCreate_clientId;
        private System.Windows.Forms.Panel panelClientCreate_clientId;
        private System.Windows.Forms.TextBox txtClientCreate_clientId;
        private System.Windows.Forms.Button btnClientCreate_Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCANCEL;
    }
}