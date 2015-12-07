namespace LocationVoiture.Vues
{
    partial class SuccursaleForm
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
            this.lblLoading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSuccursale_courriel = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSuccursale_Delete = new System.Windows.Forms.Button();
            this.lblClientCreate_clientId = new System.Windows.Forms.Label();
            this.panelClientCreate_clientId = new System.Windows.Forms.Panel();
            this.txtSuccursale_succursaleID = new System.Windows.Forms.TextBox();
            this.btnSuccursale_Find = new System.Windows.Forms.Button();
            this.lblClientCreate_id = new System.Windows.Forms.Label();
            this.panelClientForm_id = new System.Windows.Forms.Panel();
            this.txtSuccursale_idSearch = new System.Windows.Forms.TextBox();
            this.lblSuccursale_operation = new System.Windows.Forms.Label();
            this.lblClientCreate_phone = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtSuccursale_phone = new System.Windows.Forms.TextBox();
            this.lblClientCreate_adresse = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtSuccursale_adresse = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSuccursale_nom = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lblClientCreate_nom = new System.Windows.Forms.Label();
            this.btnSuccursale_cancel = new System.Windows.Forms.Button();
            this.btnSuccursale_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelClientCreate_clientId.SuspendLayout();
            this.panelClientForm_id.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblLoading);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSuccursale_Delete);
            this.panel1.Controls.Add(this.lblClientCreate_clientId);
            this.panel1.Controls.Add(this.panelClientCreate_clientId);
            this.panel1.Controls.Add(this.btnSuccursale_Find);
            this.panel1.Controls.Add(this.lblClientCreate_id);
            this.panel1.Controls.Add(this.panelClientForm_id);
            this.panel1.Controls.Add(this.lblSuccursale_operation);
            this.panel1.Controls.Add(this.lblClientCreate_phone);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.lblClientCreate_adresse);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.lblClientCreate_nom);
            this.panel1.Controls.Add(this.btnSuccursale_cancel);
            this.panel1.Controls.Add(this.btnSuccursale_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 436);
            this.panel1.TabIndex = 0;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Teal;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(144, 100);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(135, 17);
            this.lblLoading.TabIndex = 124;
            this.lblLoading.Text = "Recherche en cours ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 121;
            this.label3.Text = "Courriel :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtSuccursale_courriel);
            this.panel4.Location = new System.Drawing.Point(144, 349);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel4.Size = new System.Drawing.Size(287, 32);
            this.panel4.TabIndex = 118;
            // 
            // txtSuccursale_courriel
            // 
            this.txtSuccursale_courriel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSuccursale_courriel.BackColor = System.Drawing.Color.White;
            this.txtSuccursale_courriel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuccursale_courriel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuccursale_courriel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuccursale_courriel.Location = new System.Drawing.Point(13, 3);
            this.txtSuccursale_courriel.Name = "txtSuccursale_courriel";
            this.txtSuccursale_courriel.Size = new System.Drawing.Size(259, 22);
            this.txtSuccursale_courriel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCANCEL);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(318, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 93);
            this.panel2.TabIndex = 106;
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.Maroon;
            this.btnCANCEL.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
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
            this.btnOK.BackColor = System.Drawing.Color.Maroon;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
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
            // btnSuccursale_Delete
            // 
            this.btnSuccursale_Delete.BackColor = System.Drawing.Color.Maroon;
            this.btnSuccursale_Delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccursale_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccursale_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccursale_Delete.ForeColor = System.Drawing.Color.White;
            this.btnSuccursale_Delete.Location = new System.Drawing.Point(321, 172);
            this.btnSuccursale_Delete.Name = "btnSuccursale_Delete";
            this.btnSuccursale_Delete.Size = new System.Drawing.Size(110, 32);
            this.btnSuccursale_Delete.TabIndex = 105;
            this.btnSuccursale_Delete.Text = "Effacer";
            this.btnSuccursale_Delete.UseVisualStyleBackColor = false;
            this.btnSuccursale_Delete.Click += new System.EventHandler(this.btnEmploye_Delete_Click);
            this.btnSuccursale_Delete.MouseEnter += new System.EventHandler(this.mouseEnterEventHandlerRed);
            this.btnSuccursale_Delete.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandlerRed);
            // 
            // lblClientCreate_clientId
            // 
            this.lblClientCreate_clientId.AutoSize = true;
            this.lblClientCreate_clientId.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_clientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_clientId.Location = new System.Drawing.Point(82, 176);
            this.lblClientCreate_clientId.Name = "lblClientCreate_clientId";
            this.lblClientCreate_clientId.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_clientId.TabIndex = 104;
            this.lblClientCreate_clientId.Text = "id :";
            // 
            // panelClientCreate_clientId
            // 
            this.panelClientCreate_clientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientCreate_clientId.Controls.Add(this.txtSuccursale_succursaleID);
            this.panelClientCreate_clientId.Location = new System.Drawing.Point(143, 172);
            this.panelClientCreate_clientId.Name = "panelClientCreate_clientId";
            this.panelClientCreate_clientId.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelClientCreate_clientId.Size = new System.Drawing.Size(170, 32);
            this.panelClientCreate_clientId.TabIndex = 103;
            // 
            // txtSuccursale_succursaleID
            // 
            this.txtSuccursale_succursaleID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSuccursale_succursaleID.BackColor = System.Drawing.Color.White;
            this.txtSuccursale_succursaleID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuccursale_succursaleID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuccursale_succursaleID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuccursale_succursaleID.Location = new System.Drawing.Point(13, 4);
            this.txtSuccursale_succursaleID.Name = "txtSuccursale_succursaleID";
            this.txtSuccursale_succursaleID.Size = new System.Drawing.Size(142, 22);
            this.txtSuccursale_succursaleID.TabIndex = 1;
            // 
            // btnSuccursale_Find
            // 
            this.btnSuccursale_Find.BackColor = System.Drawing.Color.Teal;
            this.btnSuccursale_Find.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccursale_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccursale_Find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccursale_Find.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuccursale_Find.Location = new System.Drawing.Point(318, 63);
            this.btnSuccursale_Find.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuccursale_Find.Name = "btnSuccursale_Find";
            this.btnSuccursale_Find.Size = new System.Drawing.Size(113, 32);
            this.btnSuccursale_Find.TabIndex = 102;
            this.btnSuccursale_Find.Text = "TROUVER";
            this.btnSuccursale_Find.UseVisualStyleBackColor = false;
            this.btnSuccursale_Find.Click += new System.EventHandler(this.btnSuccursale_Find_Click);
            // 
            // lblClientCreate_id
            // 
            this.lblClientCreate_id.AutoSize = true;
            this.lblClientCreate_id.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_id.Location = new System.Drawing.Point(82, 67);
            this.lblClientCreate_id.Name = "lblClientCreate_id";
            this.lblClientCreate_id.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_id.TabIndex = 101;
            this.lblClientCreate_id.Text = "id :";
            // 
            // panelClientForm_id
            // 
            this.panelClientForm_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientForm_id.Controls.Add(this.txtSuccursale_idSearch);
            this.panelClientForm_id.Location = new System.Drawing.Point(143, 63);
            this.panelClientForm_id.Name = "panelClientForm_id";
            this.panelClientForm_id.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelClientForm_id.Size = new System.Drawing.Size(165, 32);
            this.panelClientForm_id.TabIndex = 100;
            // 
            // txtSuccursale_idSearch
            // 
            this.txtSuccursale_idSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSuccursale_idSearch.BackColor = System.Drawing.Color.White;
            this.txtSuccursale_idSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuccursale_idSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuccursale_idSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuccursale_idSearch.Location = new System.Drawing.Point(9, 4);
            this.txtSuccursale_idSearch.Name = "txtSuccursale_idSearch";
            this.txtSuccursale_idSearch.Size = new System.Drawing.Size(146, 22);
            this.txtSuccursale_idSearch.TabIndex = 1;
            // 
            // lblSuccursale_operation
            // 
            this.lblSuccursale_operation.AutoSize = true;
            this.lblSuccursale_operation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccursale_operation.ForeColor = System.Drawing.Color.Teal;
            this.lblSuccursale_operation.Location = new System.Drawing.Point(143, 14);
            this.lblSuccursale_operation.Name = "lblSuccursale_operation";
            this.lblSuccursale_operation.Size = new System.Drawing.Size(252, 32);
            this.lblSuccursale_operation.TabIndex = 4;
            this.lblSuccursale_operation.Text = "Créer une succursale";
            // 
            // lblClientCreate_phone
            // 
            this.lblClientCreate_phone.AutoSize = true;
            this.lblClientCreate_phone.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_phone.Location = new System.Drawing.Point(15, 311);
            this.lblClientCreate_phone.Name = "lblClientCreate_phone";
            this.lblClientCreate_phone.Size = new System.Drawing.Size(103, 25);
            this.lblClientCreate_phone.TabIndex = 99;
            this.lblClientCreate_phone.Text = "téléphone :";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtSuccursale_phone);
            this.panel13.Location = new System.Drawing.Point(143, 307);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel13.Size = new System.Drawing.Size(287, 32);
            this.panel13.TabIndex = 45;
            // 
            // txtSuccursale_phone
            // 
            this.txtSuccursale_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSuccursale_phone.BackColor = System.Drawing.Color.White;
            this.txtSuccursale_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuccursale_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuccursale_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuccursale_phone.Location = new System.Drawing.Point(13, 4);
            this.txtSuccursale_phone.Name = "txtSuccursale_phone";
            this.txtSuccursale_phone.Size = new System.Drawing.Size(259, 22);
            this.txtSuccursale_phone.TabIndex = 3;
            // 
            // lblClientCreate_adresse
            // 
            this.lblClientCreate_adresse.AutoSize = true;
            this.lblClientCreate_adresse.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_adresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_adresse.Location = new System.Drawing.Point(37, 268);
            this.lblClientCreate_adresse.Name = "lblClientCreate_adresse";
            this.lblClientCreate_adresse.Size = new System.Drawing.Size(81, 25);
            this.lblClientCreate_adresse.TabIndex = 99;
            this.lblClientCreate_adresse.Text = "adresse :";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.txtSuccursale_adresse);
            this.panel12.Location = new System.Drawing.Point(144, 264);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel12.Size = new System.Drawing.Size(287, 32);
            this.panel12.TabIndex = 43;
            // 
            // txtSuccursale_adresse
            // 
            this.txtSuccursale_adresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSuccursale_adresse.BackColor = System.Drawing.Color.White;
            this.txtSuccursale_adresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuccursale_adresse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuccursale_adresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuccursale_adresse.Location = new System.Drawing.Point(13, 4);
            this.txtSuccursale_adresse.Name = "txtSuccursale_adresse";
            this.txtSuccursale_adresse.Size = new System.Drawing.Size(259, 22);
            this.txtSuccursale_adresse.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtSuccursale_nom);
            this.panel10.Location = new System.Drawing.Point(143, 220);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel10.Size = new System.Drawing.Size(287, 32);
            this.panel10.TabIndex = 16;
            // 
            // txtSuccursale_nom
            // 
            this.txtSuccursale_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSuccursale_nom.BackColor = System.Drawing.Color.White;
            this.txtSuccursale_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuccursale_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuccursale_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuccursale_nom.Location = new System.Drawing.Point(13, 4);
            this.txtSuccursale_nom.Name = "txtSuccursale_nom";
            this.txtSuccursale_nom.Size = new System.Drawing.Size(259, 22);
            this.txtSuccursale_nom.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label32.Location = new System.Drawing.Point(143, 133);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(106, 25);
            this.label32.TabIndex = 31;
            this.label32.Text = "Succursale";
            // 
            // lblClientCreate_nom
            // 
            this.lblClientCreate_nom.AutoSize = true;
            this.lblClientCreate_nom.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_nom.Location = new System.Drawing.Point(60, 224);
            this.lblClientCreate_nom.Name = "lblClientCreate_nom";
            this.lblClientCreate_nom.Size = new System.Drawing.Size(58, 25);
            this.lblClientCreate_nom.TabIndex = 99;
            this.lblClientCreate_nom.Text = "nom :";
            // 
            // btnSuccursale_cancel
            // 
            this.btnSuccursale_cancel.BackColor = System.Drawing.Color.Teal;
            this.btnSuccursale_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccursale_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccursale_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccursale_cancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuccursale_cancel.Location = new System.Drawing.Point(319, 389);
            this.btnSuccursale_cancel.Name = "btnSuccursale_cancel";
            this.btnSuccursale_cancel.Size = new System.Drawing.Size(113, 35);
            this.btnSuccursale_cancel.TabIndex = 8;
            this.btnSuccursale_cancel.Text = "Annuler";
            this.btnSuccursale_cancel.UseVisualStyleBackColor = false;
            this.btnSuccursale_cancel.Click += new System.EventHandler(this.txtClientCreate_cancel_Click);
            this.btnSuccursale_cancel.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnSuccursale_cancel.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnSuccursale_add
            // 
            this.btnSuccursale_add.BackColor = System.Drawing.Color.Teal;
            this.btnSuccursale_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccursale_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccursale_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccursale_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuccursale_add.Location = new System.Drawing.Point(195, 389);
            this.btnSuccursale_add.Name = "btnSuccursale_add";
            this.btnSuccursale_add.Size = new System.Drawing.Size(113, 35);
            this.btnSuccursale_add.TabIndex = 7;
            this.btnSuccursale_add.Text = "Ajouter";
            this.btnSuccursale_add.UseVisualStyleBackColor = false;
            this.btnSuccursale_add.Click += new System.EventHandler(this.btnSuccursale_add_Click);
            this.btnSuccursale_add.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnSuccursale_add.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // SuccursaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(460, 436);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccursaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelClientCreate_clientId.ResumeLayout(false);
            this.panelClientCreate_clientId.PerformLayout();
            this.panelClientForm_id.ResumeLayout(false);
            this.panelClientForm_id.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSuccursale_operation;
        private System.Windows.Forms.Label lblClientCreate_phone;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtSuccursale_phone;
        private System.Windows.Forms.Label lblClientCreate_adresse;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtSuccursale_adresse;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtSuccursale_nom;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblClientCreate_nom;
        private System.Windows.Forms.Button btnSuccursale_cancel;
        private System.Windows.Forms.Button btnSuccursale_add;
        private System.Windows.Forms.Button btnSuccursale_Find;
        private System.Windows.Forms.Label lblClientCreate_id;
        private System.Windows.Forms.Panel panelClientForm_id;
        private System.Windows.Forms.TextBox txtSuccursale_idSearch;
        private System.Windows.Forms.Label lblClientCreate_clientId;
        private System.Windows.Forms.Panel panelClientCreate_clientId;
        private System.Windows.Forms.TextBox txtSuccursale_succursaleID;
        private System.Windows.Forms.Button btnSuccursale_Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSuccursale_courriel;
        private System.Windows.Forms.Label lblLoading;
    }
}