namespace LocationVoiture.Vues
{
    partial class EmployeForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbEmploye_succursale = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmploye_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEmploye_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmploye_fonction = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEmploye_Delete = new System.Windows.Forms.Button();
            this.lblClientCreate_clientId = new System.Windows.Forms.Label();
            this.panelClientCreate_clientId = new System.Windows.Forms.Panel();
            this.txtEmploye_empID = new System.Windows.Forms.TextBox();
            this.btnEmploye_Find = new System.Windows.Forms.Button();
            this.lblClientCreate_id = new System.Windows.Forms.Label();
            this.panelClientForm_id = new System.Windows.Forms.Panel();
            this.txtEmploye_idSearch = new System.Windows.Forms.TextBox();
            this.lblClientCreate_operation = new System.Windows.Forms.Label();
            this.lblClientCreate_phone = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtEmploye_phone = new System.Windows.Forms.TextBox();
            this.lblClientCreate_adresse = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtEmploye_adresse = new System.Windows.Forms.TextBox();
            this.lblClientCreate_email = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtEmploye_tauxHoraire = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtEmploye_nom = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lblClientCreate_nom = new System.Windows.Forms.Label();
            this.btnEmploye_cancel = new System.Windows.Forms.Button();
            this.btnEmploye_add = new System.Windows.Forms.Button();
            this.lblLoading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelClientCreate_clientId.SuspendLayout();
            this.panelClientForm_id.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblLoading);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbEmploye_succursale);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbEmploye_fonction);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnEmploye_Delete);
            this.panel1.Controls.Add(this.lblClientCreate_clientId);
            this.panel1.Controls.Add(this.panelClientCreate_clientId);
            this.panel1.Controls.Add(this.btnEmploye_Find);
            this.panel1.Controls.Add(this.lblClientCreate_id);
            this.panel1.Controls.Add(this.panelClientForm_id);
            this.panel1.Controls.Add(this.lblClientCreate_operation);
            this.panel1.Controls.Add(this.lblClientCreate_phone);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.lblClientCreate_adresse);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.lblClientCreate_email);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.lblClientCreate_nom);
            this.panel1.Controls.Add(this.btnEmploye_cancel);
            this.panel1.Controls.Add(this.btnEmploye_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 643);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(18, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 123;
            this.label4.Text = "succursale :";
            // 
            // cbEmploye_succursale
            // 
            this.cbEmploye_succursale.BackColor = System.Drawing.Color.Teal;
            this.cbEmploye_succursale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmploye_succursale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEmploye_succursale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmploye_succursale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbEmploye_succursale.FormattingEnabled = true;
            this.cbEmploye_succursale.Location = new System.Drawing.Point(144, 552);
            this.cbEmploye_succursale.Name = "cbEmploye_succursale";
            this.cbEmploye_succursale.Size = new System.Drawing.Size(287, 29);
            this.cbEmploye_succursale.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(19, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 120;
            this.label2.Text = "username :";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtEmploye_username);
            this.panel3.Location = new System.Drawing.Point(143, 459);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(287, 32);
            this.panel3.TabIndex = 119;
            // 
            // txtEmploye_username
            // 
            this.txtEmploye_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmploye_username.BackColor = System.Drawing.Color.Black;
            this.txtEmploye_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmploye_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploye_username.ForeColor = System.Drawing.Color.Silver;
            this.txtEmploye_username.Location = new System.Drawing.Point(13, 3);
            this.txtEmploye_username.Name = "txtEmploye_username";
            this.txtEmploye_username.Size = new System.Drawing.Size(259, 22);
            this.txtEmploye_username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(22, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 121;
            this.label3.Text = "password :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtEmploye_password);
            this.panel4.Location = new System.Drawing.Point(143, 503);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel4.Size = new System.Drawing.Size(287, 32);
            this.panel4.TabIndex = 118;
            // 
            // txtEmploye_password
            // 
            this.txtEmploye_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmploye_password.BackColor = System.Drawing.Color.Black;
            this.txtEmploye_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmploye_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploye_password.ForeColor = System.Drawing.Color.Silver;
            this.txtEmploye_password.Location = new System.Drawing.Point(13, 3);
            this.txtEmploye_password.Name = "txtEmploye_password";
            this.txtEmploye_password.Size = new System.Drawing.Size(259, 22);
            this.txtEmploye_password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(32, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 117;
            this.label1.Text = "fonction :";
            // 
            // cbEmploye_fonction
            // 
            this.cbEmploye_fonction.BackColor = System.Drawing.Color.Teal;
            this.cbEmploye_fonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmploye_fonction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEmploye_fonction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmploye_fonction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbEmploye_fonction.FormattingEnabled = true;
            this.cbEmploye_fonction.Location = new System.Drawing.Point(143, 268);
            this.cbEmploye_fonction.Name = "cbEmploye_fonction";
            this.cbEmploye_fonction.Size = new System.Drawing.Size(287, 29);
            this.cbEmploye_fonction.TabIndex = 116;
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
            this.lblClientCreate_clientId.Location = new System.Drawing.Point(82, 176);
            this.lblClientCreate_clientId.Name = "lblClientCreate_clientId";
            this.lblClientCreate_clientId.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_clientId.TabIndex = 104;
            this.lblClientCreate_clientId.Text = "id :";
            // 
            // panelClientCreate_clientId
            // 
            this.panelClientCreate_clientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientCreate_clientId.Controls.Add(this.txtEmploye_empID);
            this.panelClientCreate_clientId.Location = new System.Drawing.Point(143, 172);
            this.panelClientCreate_clientId.Name = "panelClientCreate_clientId";
            this.panelClientCreate_clientId.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelClientCreate_clientId.Size = new System.Drawing.Size(170, 32);
            this.panelClientCreate_clientId.TabIndex = 103;
            // 
            // txtEmploye_empID
            // 
            this.txtEmploye_empID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmploye_empID.BackColor = System.Drawing.Color.Black;
            this.txtEmploye_empID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmploye_empID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploye_empID.ForeColor = System.Drawing.Color.Silver;
            this.txtEmploye_empID.Location = new System.Drawing.Point(13, 4);
            this.txtEmploye_empID.Name = "txtEmploye_empID";
            this.txtEmploye_empID.Size = new System.Drawing.Size(142, 22);
            this.txtEmploye_empID.TabIndex = 1;
            // 
            // btnEmploye_Find
            // 
            this.btnEmploye_Find.BackColor = System.Drawing.Color.Teal;
            this.btnEmploye_Find.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmploye_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye_Find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploye_Find.ForeColor = System.Drawing.Color.Black;
            this.btnEmploye_Find.Location = new System.Drawing.Point(318, 63);
            this.btnEmploye_Find.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmploye_Find.Name = "btnEmploye_Find";
            this.btnEmploye_Find.Size = new System.Drawing.Size(113, 32);
            this.btnEmploye_Find.TabIndex = 102;
            this.btnEmploye_Find.Text = "TROUVER";
            this.btnEmploye_Find.UseVisualStyleBackColor = false;
            this.btnEmploye_Find.Click += new System.EventHandler(this.btnEmploye_Find_Click);
            // 
            // lblClientCreate_id
            // 
            this.lblClientCreate_id.AutoSize = true;
            this.lblClientCreate_id.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_id.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_id.Location = new System.Drawing.Point(82, 67);
            this.lblClientCreate_id.Name = "lblClientCreate_id";
            this.lblClientCreate_id.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_id.TabIndex = 101;
            this.lblClientCreate_id.Text = "id :";
            // 
            // panelClientForm_id
            // 
            this.panelClientForm_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientForm_id.Controls.Add(this.txtEmploye_idSearch);
            this.panelClientForm_id.Location = new System.Drawing.Point(143, 63);
            this.panelClientForm_id.Name = "panelClientForm_id";
            this.panelClientForm_id.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelClientForm_id.Size = new System.Drawing.Size(165, 32);
            this.panelClientForm_id.TabIndex = 100;
            // 
            // txtEmploye_idSearch
            // 
            this.txtEmploye_idSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmploye_idSearch.BackColor = System.Drawing.Color.Black;
            this.txtEmploye_idSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmploye_idSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploye_idSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtEmploye_idSearch.Location = new System.Drawing.Point(9, 4);
            this.txtEmploye_idSearch.Name = "txtEmploye_idSearch";
            this.txtEmploye_idSearch.Size = new System.Drawing.Size(146, 22);
            this.txtEmploye_idSearch.TabIndex = 1;
            // 
            // lblClientCreate_operation
            // 
            this.lblClientCreate_operation.AutoSize = true;
            this.lblClientCreate_operation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_operation.ForeColor = System.Drawing.Color.Teal;
            this.lblClientCreate_operation.Location = new System.Drawing.Point(143, 14);
            this.lblClientCreate_operation.Name = "lblClientCreate_operation";
            this.lblClientCreate_operation.Size = new System.Drawing.Size(218, 32);
            this.lblClientCreate_operation.TabIndex = 4;
            this.lblClientCreate_operation.Text = "Créer un employé";
            // 
            // lblClientCreate_phone
            // 
            this.lblClientCreate_phone.AutoSize = true;
            this.lblClientCreate_phone.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_phone.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_phone.Location = new System.Drawing.Point(15, 370);
            this.lblClientCreate_phone.Name = "lblClientCreate_phone";
            this.lblClientCreate_phone.Size = new System.Drawing.Size(103, 25);
            this.lblClientCreate_phone.TabIndex = 99;
            this.lblClientCreate_phone.Text = "téléphone :";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtEmploye_phone);
            this.panel13.Location = new System.Drawing.Point(143, 366);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel13.Size = new System.Drawing.Size(287, 32);
            this.panel13.TabIndex = 45;
            // 
            // txtEmploye_phone
            // 
            this.txtEmploye_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmploye_phone.BackColor = System.Drawing.Color.Black;
            this.txtEmploye_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmploye_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploye_phone.ForeColor = System.Drawing.Color.Silver;
            this.txtEmploye_phone.Location = new System.Drawing.Point(13, 4);
            this.txtEmploye_phone.Name = "txtEmploye_phone";
            this.txtEmploye_phone.Size = new System.Drawing.Size(259, 22);
            this.txtEmploye_phone.TabIndex = 3;
            // 
            // lblClientCreate_adresse
            // 
            this.lblClientCreate_adresse.AutoSize = true;
            this.lblClientCreate_adresse.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_adresse.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_adresse.Location = new System.Drawing.Point(37, 414);
            this.lblClientCreate_adresse.Name = "lblClientCreate_adresse";
            this.lblClientCreate_adresse.Size = new System.Drawing.Size(81, 25);
            this.lblClientCreate_adresse.TabIndex = 99;
            this.lblClientCreate_adresse.Text = "adresse :";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.txtEmploye_adresse);
            this.panel12.Location = new System.Drawing.Point(143, 410);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel12.Size = new System.Drawing.Size(287, 32);
            this.panel12.TabIndex = 43;
            // 
            // txtEmploye_adresse
            // 
            this.txtEmploye_adresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmploye_adresse.BackColor = System.Drawing.Color.Black;
            this.txtEmploye_adresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmploye_adresse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploye_adresse.ForeColor = System.Drawing.Color.Silver;
            this.txtEmploye_adresse.Location = new System.Drawing.Point(13, 4);
            this.txtEmploye_adresse.Name = "txtEmploye_adresse";
            this.txtEmploye_adresse.Size = new System.Drawing.Size(259, 22);
            this.txtEmploye_adresse.TabIndex = 5;
            // 
            // lblClientCreate_email
            // 
            this.lblClientCreate_email.AutoSize = true;
            this.lblClientCreate_email.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_email.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_email.Location = new System.Drawing.Point(3, 319);
            this.lblClientCreate_email.Name = "lblClientCreate_email";
            this.lblClientCreate_email.Size = new System.Drawing.Size(115, 25);
            this.lblClientCreate_email.TabIndex = 99;
            this.lblClientCreate_email.Text = "taux horaire :";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txtEmploye_tauxHoraire);
            this.panel9.Location = new System.Drawing.Point(143, 315);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel9.Size = new System.Drawing.Size(287, 32);
            this.panel9.TabIndex = 41;
            // 
            // txtEmploye_tauxHoraire
            // 
            this.txtEmploye_tauxHoraire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmploye_tauxHoraire.BackColor = System.Drawing.Color.Black;
            this.txtEmploye_tauxHoraire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmploye_tauxHoraire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploye_tauxHoraire.ForeColor = System.Drawing.Color.Silver;
            this.txtEmploye_tauxHoraire.Location = new System.Drawing.Point(13, 4);
            this.txtEmploye_tauxHoraire.Name = "txtEmploye_tauxHoraire";
            this.txtEmploye_tauxHoraire.Size = new System.Drawing.Size(259, 22);
            this.txtEmploye_tauxHoraire.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtEmploye_nom);
            this.panel10.Location = new System.Drawing.Point(143, 220);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel10.Size = new System.Drawing.Size(287, 32);
            this.panel10.TabIndex = 16;
            // 
            // txtEmploye_nom
            // 
            this.txtEmploye_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmploye_nom.BackColor = System.Drawing.Color.Black;
            this.txtEmploye_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmploye_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploye_nom.ForeColor = System.Drawing.Color.Silver;
            this.txtEmploye_nom.Location = new System.Drawing.Point(13, 4);
            this.txtEmploye_nom.Name = "txtEmploye_nom";
            this.txtEmploye_nom.Size = new System.Drawing.Size(259, 22);
            this.txtEmploye_nom.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Gray;
            this.label32.Location = new System.Drawing.Point(143, 133);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 25);
            this.label32.TabIndex = 31;
            this.label32.Text = "Employé";
            // 
            // lblClientCreate_nom
            // 
            this.lblClientCreate_nom.AutoSize = true;
            this.lblClientCreate_nom.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_nom.ForeColor = System.Drawing.Color.Silver;
            this.lblClientCreate_nom.Location = new System.Drawing.Point(60, 224);
            this.lblClientCreate_nom.Name = "lblClientCreate_nom";
            this.lblClientCreate_nom.Size = new System.Drawing.Size(58, 25);
            this.lblClientCreate_nom.TabIndex = 99;
            this.lblClientCreate_nom.Text = "nom :";
            // 
            // btnEmploye_cancel
            // 
            this.btnEmploye_cancel.BackColor = System.Drawing.Color.Black;
            this.btnEmploye_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmploye_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploye_cancel.ForeColor = System.Drawing.Color.Teal;
            this.btnEmploye_cancel.Location = new System.Drawing.Point(316, 597);
            this.btnEmploye_cancel.Name = "btnEmploye_cancel";
            this.btnEmploye_cancel.Size = new System.Drawing.Size(113, 35);
            this.btnEmploye_cancel.TabIndex = 8;
            this.btnEmploye_cancel.Text = "Annuler";
            this.btnEmploye_cancel.UseVisualStyleBackColor = false;
            this.btnEmploye_cancel.Click += new System.EventHandler(this.txtClientCreate_cancel_Click);
            this.btnEmploye_cancel.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnEmploye_cancel.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnEmploye_add
            // 
            this.btnEmploye_add.BackColor = System.Drawing.Color.Black;
            this.btnEmploye_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmploye_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploye_add.ForeColor = System.Drawing.Color.Teal;
            this.btnEmploye_add.Location = new System.Drawing.Point(192, 597);
            this.btnEmploye_add.Name = "btnEmploye_add";
            this.btnEmploye_add.Size = new System.Drawing.Size(113, 35);
            this.btnEmploye_add.TabIndex = 7;
            this.btnEmploye_add.Text = "Ajouter";
            this.btnEmploye_add.UseVisualStyleBackColor = false;
            this.btnEmploye_add.Click += new System.EventHandler(this.btnEmploye_add_Click);
            this.btnEmploye_add.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnEmploye_add.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
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
            // EmployeForm_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(460, 643);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeForm_v2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClientCreate_operation;
        private System.Windows.Forms.Label lblClientCreate_phone;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtEmploye_phone;
        private System.Windows.Forms.Label lblClientCreate_adresse;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtEmploye_adresse;
        private System.Windows.Forms.Label lblClientCreate_email;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtEmploye_tauxHoraire;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtEmploye_nom;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblClientCreate_nom;
        private System.Windows.Forms.Button btnEmploye_cancel;
        private System.Windows.Forms.Button btnEmploye_add;
        private System.Windows.Forms.Button btnEmploye_Find;
        private System.Windows.Forms.Label lblClientCreate_id;
        private System.Windows.Forms.Panel panelClientForm_id;
        private System.Windows.Forms.TextBox txtEmploye_idSearch;
        private System.Windows.Forms.Label lblClientCreate_clientId;
        private System.Windows.Forms.Panel panelClientCreate_clientId;
        private System.Windows.Forms.TextBox txtEmploye_empID;
        private System.Windows.Forms.Button btnEmploye_Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmploye_fonction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmploye_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEmploye_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEmploye_succursale;
        private System.Windows.Forms.Label lblLoading;
    }
}