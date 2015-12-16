namespace LocationVoiture.Vues
{
    partial class ReservationForm_version2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_CarChoice = new System.Windows.Forms.Panel();
            this.lblReservation_carChoice = new System.Windows.Forms.Label();
            this.txtReservation_plateNum = new System.Windows.Forms.TextBox();
            this.txtReservation_fabriquant = new System.Windows.Forms.TextBox();
            this.txtReservation_modele = new System.Windows.Forms.TextBox();
            this.txtReservation_carID = new System.Windows.Forms.TextBox();
            this.dataGridView_AvailableCars = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReservationCreate_Types = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_ReservationCreate_DateIN = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ReservationCreate_DateOUT = new System.Windows.Forms.DateTimePicker();
            this.lblLoading = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbReservationCreate_HeureIN = new System.Windows.Forms.ComboBox();
            this.cbReservationCreate_Succursale = new System.Windows.Forms.ComboBox();
            this.lblReservationCreate_succursale = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReservationCreate_HeureOUT = new System.Windows.Forms.ComboBox();
            this.btnReservationCreate_creerClient = new System.Windows.Forms.Button();
            this.lblClientCreate_clientId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_CarChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AvailableCars)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelClientForm_id.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel_CarChoice);
            this.panel1.Controls.Add(this.txtReservation_carID);
            this.panel1.Controls.Add(this.dataGridView_AvailableCars);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbReservationCreate_Types);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker_ReservationCreate_DateIN);
            this.panel1.Controls.Add(this.dateTimePicker_ReservationCreate_DateOUT);
            this.panel1.Controls.Add(this.lblLoading);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbReservationCreate_HeureIN);
            this.panel1.Controls.Add(this.cbReservationCreate_Succursale);
            this.panel1.Controls.Add(this.lblReservationCreate_succursale);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbReservationCreate_HeureOUT);
            this.panel1.Controls.Add(this.btnReservationCreate_creerClient);
            this.panel1.Controls.Add(this.lblClientCreate_clientId);
            this.panel1.Controls.Add(this.panel2);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 612);
            this.panel1.TabIndex = 0;
            // 
            // panel_CarChoice
            // 
            this.panel_CarChoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_CarChoice.Controls.Add(this.lblReservation_carChoice);
            this.panel_CarChoice.Controls.Add(this.txtReservation_plateNum);
            this.panel_CarChoice.Controls.Add(this.txtReservation_fabriquant);
            this.panel_CarChoice.Controls.Add(this.txtReservation_modele);
            this.panel_CarChoice.Location = new System.Drawing.Point(452, 549);
            this.panel_CarChoice.Name = "panel_CarChoice";
            this.panel_CarChoice.Size = new System.Drawing.Size(444, 43);
            this.panel_CarChoice.TabIndex = 46;
            // 
            // lblReservation_carChoice
            // 
            this.lblReservation_carChoice.AutoSize = true;
            this.lblReservation_carChoice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservation_carChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReservation_carChoice.Location = new System.Drawing.Point(9, 9);
            this.lblReservation_carChoice.Name = "lblReservation_carChoice";
            this.lblReservation_carChoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReservation_carChoice.Size = new System.Drawing.Size(138, 25);
            this.lblReservation_carChoice.TabIndex = 45;
            this.lblReservation_carChoice.Text = "Véhicule choisi";
            this.lblReservation_carChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReservation_plateNum
            // 
            this.txtReservation_plateNum.BackColor = System.Drawing.Color.Gainsboro;
            this.txtReservation_plateNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservation_plateNum.Enabled = false;
            this.txtReservation_plateNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservation_plateNum.ForeColor = System.Drawing.Color.Black;
            this.txtReservation_plateNum.Location = new System.Drawing.Point(337, 11);
            this.txtReservation_plateNum.Name = "txtReservation_plateNum";
            this.txtReservation_plateNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReservation_plateNum.Size = new System.Drawing.Size(95, 22);
            this.txtReservation_plateNum.TabIndex = 0;
            this.txtReservation_plateNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReservation_fabriquant
            // 
            this.txtReservation_fabriquant.BackColor = System.Drawing.Color.Gainsboro;
            this.txtReservation_fabriquant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservation_fabriquant.Enabled = false;
            this.txtReservation_fabriquant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservation_fabriquant.ForeColor = System.Drawing.Color.Black;
            this.txtReservation_fabriquant.Location = new System.Drawing.Point(154, 11);
            this.txtReservation_fabriquant.Name = "txtReservation_fabriquant";
            this.txtReservation_fabriquant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReservation_fabriquant.Size = new System.Drawing.Size(91, 22);
            this.txtReservation_fabriquant.TabIndex = 0;
            this.txtReservation_fabriquant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReservation_modele
            // 
            this.txtReservation_modele.BackColor = System.Drawing.Color.Gainsboro;
            this.txtReservation_modele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservation_modele.Enabled = false;
            this.txtReservation_modele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservation_modele.ForeColor = System.Drawing.Color.Black;
            this.txtReservation_modele.Location = new System.Drawing.Point(246, 11);
            this.txtReservation_modele.Name = "txtReservation_modele";
            this.txtReservation_modele.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReservation_modele.Size = new System.Drawing.Size(90, 22);
            this.txtReservation_modele.TabIndex = 0;
            this.txtReservation_modele.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReservation_carID
            // 
            this.txtReservation_carID.BackColor = System.Drawing.Color.White;
            this.txtReservation_carID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservation_carID.Enabled = false;
            this.txtReservation_carID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservation_carID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReservation_carID.Location = new System.Drawing.Point(627, 553);
            this.txtReservation_carID.Name = "txtReservation_carID";
            this.txtReservation_carID.Size = new System.Drawing.Size(119, 22);
            this.txtReservation_carID.TabIndex = 1;
            this.txtReservation_carID.Visible = false;
            // 
            // dataGridView_AvailableCars
            // 
            this.dataGridView_AvailableCars.AllowUserToAddRows = false;
            this.dataGridView_AvailableCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AvailableCars.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_AvailableCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_AvailableCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AvailableCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_AvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.NullValue = "-------------";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_AvailableCars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_AvailableCars.GridColor = System.Drawing.Color.Teal;
            this.dataGridView_AvailableCars.Location = new System.Drawing.Point(452, 348);
            this.dataGridView_AvailableCars.MultiSelect = false;
            this.dataGridView_AvailableCars.Name = "dataGridView_AvailableCars";
            this.dataGridView_AvailableCars.RowTemplate.Height = 36;
            this.dataGridView_AvailableCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_AvailableCars.Size = new System.Drawing.Size(443, 195);
            this.dataGridView_AvailableCars.TabIndex = 43;
            this.dataGridView_AvailableCars.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AvailableCars_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(695, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Véhicules disponibles";
            // 
            // cbReservationCreate_Types
            // 
            this.cbReservationCreate_Types.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbReservationCreate_Types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservationCreate_Types.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbReservationCreate_Types.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReservationCreate_Types.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbReservationCreate_Types.FormattingEnabled = true;
            this.cbReservationCreate_Types.Location = new System.Drawing.Point(674, 260);
            this.cbReservationCreate_Types.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbReservationCreate_Types.Name = "cbReservationCreate_Types";
            this.cbReservationCreate_Types.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbReservationCreate_Types.Size = new System.Drawing.Size(222, 29);
            this.cbReservationCreate_Types.TabIndex = 40;
            this.cbReservationCreate_Types.SelectedIndexChanged += new System.EventHandler(this.cbReservationCreate_Types_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(841, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Type";
            // 
            // dateTimePicker_ReservationCreate_DateIN
            // 
            this.dateTimePicker_ReservationCreate_DateIN.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReservationCreate_DateIN.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker_ReservationCreate_DateIN.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker_ReservationCreate_DateIN.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker_ReservationCreate_DateIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReservationCreate_DateIN.Location = new System.Drawing.Point(610, 154);
            this.dateTimePicker_ReservationCreate_DateIN.MinDate = new System.DateTime(2015, 10, 25, 0, 0, 0, 0);
            this.dateTimePicker_ReservationCreate_DateIN.Name = "dateTimePicker_ReservationCreate_DateIN";
            this.dateTimePicker_ReservationCreate_DateIN.Size = new System.Drawing.Size(286, 29);
            this.dateTimePicker_ReservationCreate_DateIN.TabIndex = 14;
            this.dateTimePicker_ReservationCreate_DateIN.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dateTimePicker_ReservationCreate_DateOUT
            // 
            this.dateTimePicker_ReservationCreate_DateOUT.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker_ReservationCreate_DateOUT.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker_ReservationCreate_DateOUT.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker_ReservationCreate_DateOUT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReservationCreate_DateOUT.Location = new System.Drawing.Point(610, 82);
            this.dateTimePicker_ReservationCreate_DateOUT.MinDate = new System.DateTime(2015, 10, 25, 0, 0, 0, 0);
            this.dateTimePicker_ReservationCreate_DateOUT.Name = "dateTimePicker_ReservationCreate_DateOUT";
            this.dateTimePicker_ReservationCreate_DateOUT.Size = new System.Drawing.Size(286, 29);
            this.dateTimePicker_ReservationCreate_DateOUT.TabIndex = 12;
            this.dateTimePicker_ReservationCreate_DateOUT.Value = new System.DateTime(2015, 11, 17, 15, 9, 37, 0);
            this.dateTimePicker_ReservationCreate_DateOUT.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Teal;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLoading.Location = new System.Drawing.Point(121, 203);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(135, 17);
            this.lblLoading.TabIndex = 22;
            this.lblLoading.Text = "Recherche en cours ...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(523, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Retour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(521, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Départ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(673, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Heure";
            // 
            // cbReservationCreate_HeureIN
            // 
            this.cbReservationCreate_HeureIN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbReservationCreate_HeureIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservationCreate_HeureIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbReservationCreate_HeureIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReservationCreate_HeureIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbReservationCreate_HeureIN.FormattingEnabled = true;
            this.cbReservationCreate_HeureIN.Location = new System.Drawing.Point(742, 194);
            this.cbReservationCreate_HeureIN.Name = "cbReservationCreate_HeureIN";
            this.cbReservationCreate_HeureIN.Size = new System.Drawing.Size(154, 28);
            this.cbReservationCreate_HeureIN.TabIndex = 15;
            // 
            // cbReservationCreate_Succursale
            // 
            this.cbReservationCreate_Succursale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbReservationCreate_Succursale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservationCreate_Succursale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbReservationCreate_Succursale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReservationCreate_Succursale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbReservationCreate_Succursale.FormattingEnabled = true;
            this.cbReservationCreate_Succursale.Location = new System.Drawing.Point(674, 31);
            this.cbReservationCreate_Succursale.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbReservationCreate_Succursale.Name = "cbReservationCreate_Succursale";
            this.cbReservationCreate_Succursale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbReservationCreate_Succursale.Size = new System.Drawing.Size(222, 29);
            this.cbReservationCreate_Succursale.TabIndex = 7;
            this.cbReservationCreate_Succursale.SelectedIndexChanged += new System.EventHandler(this.cbReservationCreate_Succursale_SelectedIndexChanged);
            // 
            // lblReservationCreate_succursale
            // 
            this.lblReservationCreate_succursale.AutoSize = true;
            this.lblReservationCreate_succursale.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReservationCreate_succursale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReservationCreate_succursale.Location = new System.Drawing.Point(789, 3);
            this.lblReservationCreate_succursale.Name = "lblReservationCreate_succursale";
            this.lblReservationCreate_succursale.Size = new System.Drawing.Size(106, 25);
            this.lblReservationCreate_succursale.TabIndex = 30;
            this.lblReservationCreate_succursale.Text = "Succursale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(671, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Heure";
            // 
            // cbReservationCreate_HeureOUT
            // 
            this.cbReservationCreate_HeureOUT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbReservationCreate_HeureOUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservationCreate_HeureOUT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbReservationCreate_HeureOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReservationCreate_HeureOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbReservationCreate_HeureOUT.FormattingEnabled = true;
            this.cbReservationCreate_HeureOUT.Location = new System.Drawing.Point(742, 118);
            this.cbReservationCreate_HeureOUT.Name = "cbReservationCreate_HeureOUT";
            this.cbReservationCreate_HeureOUT.Size = new System.Drawing.Size(154, 28);
            this.cbReservationCreate_HeureOUT.TabIndex = 13;
            // 
            // btnReservationCreate_creerClient
            // 
            this.btnReservationCreate_creerClient.BackColor = System.Drawing.Color.Teal;
            this.btnReservationCreate_creerClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReservationCreate_creerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationCreate_creerClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationCreate_creerClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservationCreate_creerClient.Location = new System.Drawing.Point(292, 203);
            this.btnReservationCreate_creerClient.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservationCreate_creerClient.Name = "btnReservationCreate_creerClient";
            this.btnReservationCreate_creerClient.Size = new System.Drawing.Size(113, 32);
            this.btnReservationCreate_creerClient.TabIndex = 19;
            this.btnReservationCreate_creerClient.Text = "Créer";
            this.btnReservationCreate_creerClient.UseVisualStyleBackColor = false;
            this.btnReservationCreate_creerClient.Click += new System.EventHandler(this.btnReservationCreate_creerClient_Click);
            this.btnReservationCreate_creerClient.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnReservationCreate_creerClient.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // lblClientCreate_clientId
            // 
            this.lblClientCreate_clientId.AutoSize = true;
            this.lblClientCreate_clientId.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_clientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_clientId.Location = new System.Drawing.Point(72, 289);
            this.lblClientCreate_clientId.Name = "lblClientCreate_clientId";
            this.lblClientCreate_clientId.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_clientId.TabIndex = 24;
            this.lblClientCreate_clientId.Text = "id :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtClientCreate_clientId);
            this.panel2.Location = new System.Drawing.Point(120, 285);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel2.Size = new System.Drawing.Size(165, 32);
            this.panel2.TabIndex = 1;
            // 
            // txtClientCreate_clientId
            // 
            this.txtClientCreate_clientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_clientId.BackColor = System.Drawing.Color.White;
            this.txtClientCreate_clientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_clientId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_clientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientCreate_clientId.Location = new System.Drawing.Point(10, 5);
            this.txtClientCreate_clientId.Name = "txtClientCreate_clientId";
            this.txtClientCreate_clientId.Size = new System.Drawing.Size(142, 22);
            this.txtClientCreate_clientId.TabIndex = 0;
            // 
            // btnClientForm_Find
            // 
            this.btnClientForm_Find.BackColor = System.Drawing.Color.Teal;
            this.btnClientForm_Find.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClientForm_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientForm_Find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientForm_Find.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientForm_Find.Location = new System.Drawing.Point(292, 164);
            this.btnClientForm_Find.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientForm_Find.Name = "btnClientForm_Find";
            this.btnClientForm_Find.Size = new System.Drawing.Size(113, 32);
            this.btnClientForm_Find.TabIndex = 18;
            this.btnClientForm_Find.Text = "Trouver";
            this.btnClientForm_Find.UseVisualStyleBackColor = false;
            this.btnClientForm_Find.Click += new System.EventHandler(this.btnReservationForm_Find_Click);
            this.btnClientForm_Find.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnClientForm_Find.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // lblClientCreate_id
            // 
            this.lblClientCreate_id.AutoSize = true;
            this.lblClientCreate_id.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_id.Location = new System.Drawing.Point(119, 135);
            this.lblClientCreate_id.Name = "lblClientCreate_id";
            this.lblClientCreate_id.Size = new System.Drawing.Size(83, 25);
            this.lblClientCreate_id.TabIndex = 21;
            this.lblClientCreate_id.Text = "client id :";
            // 
            // panelClientForm_id
            // 
            this.panelClientForm_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientForm_id.Controls.Add(this.txtClientCreate_idSearch);
            this.panelClientForm_id.Location = new System.Drawing.Point(120, 164);
            this.panelClientForm_id.Name = "panelClientForm_id";
            this.panelClientForm_id.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelClientForm_id.Size = new System.Drawing.Size(165, 32);
            this.panelClientForm_id.TabIndex = 0;
            // 
            // txtClientCreate_idSearch
            // 
            this.txtClientCreate_idSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_idSearch.BackColor = System.Drawing.Color.White;
            this.txtClientCreate_idSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_idSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_idSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientCreate_idSearch.Location = new System.Drawing.Point(9, 4);
            this.txtClientCreate_idSearch.Name = "txtClientCreate_idSearch";
            this.txtClientCreate_idSearch.Size = new System.Drawing.Size(146, 22);
            this.txtClientCreate_idSearch.TabIndex = 0;
            // 
            // lblClientCreate_operation
            // 
            this.lblClientCreate_operation.AutoSize = true;
            this.lblClientCreate_operation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_operation.ForeColor = System.Drawing.Color.Teal;
            this.lblClientCreate_operation.Location = new System.Drawing.Point(120, 41);
            this.lblClientCreate_operation.Name = "lblClientCreate_operation";
            this.lblClientCreate_operation.Size = new System.Drawing.Size(263, 32);
            this.lblClientCreate_operation.TabIndex = 20;
            this.lblClientCreate_operation.Text = "Créer une réservation";
            // 
            // lblClientCreate_phone
            // 
            this.lblClientCreate_phone.AutoSize = true;
            this.lblClientCreate_phone.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_phone.Location = new System.Drawing.Point(5, 424);
            this.lblClientCreate_phone.Name = "lblClientCreate_phone";
            this.lblClientCreate_phone.Size = new System.Drawing.Size(103, 25);
            this.lblClientCreate_phone.TabIndex = 27;
            this.lblClientCreate_phone.Text = "téléphone :";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtClientCreate_phone);
            this.panel13.Location = new System.Drawing.Point(120, 420);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel13.Size = new System.Drawing.Size(287, 32);
            this.panel13.TabIndex = 4;
            // 
            // txtClientCreate_phone
            // 
            this.txtClientCreate_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_phone.BackColor = System.Drawing.Color.White;
            this.txtClientCreate_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientCreate_phone.Location = new System.Drawing.Point(13, 5);
            this.txtClientCreate_phone.Name = "txtClientCreate_phone";
            this.txtClientCreate_phone.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_phone.TabIndex = 0;
            // 
            // lblClientCreate_adresse
            // 
            this.lblClientCreate_adresse.AutoSize = true;
            this.lblClientCreate_adresse.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_adresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_adresse.Location = new System.Drawing.Point(27, 517);
            this.lblClientCreate_adresse.Name = "lblClientCreate_adresse";
            this.lblClientCreate_adresse.Size = new System.Drawing.Size(81, 25);
            this.lblClientCreate_adresse.TabIndex = 29;
            this.lblClientCreate_adresse.Text = "adresse :";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.txtClientCreate_adresse);
            this.panel12.Location = new System.Drawing.Point(120, 513);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel12.Size = new System.Drawing.Size(287, 32);
            this.panel12.TabIndex = 6;
            // 
            // txtClientCreate_adresse
            // 
            this.txtClientCreate_adresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_adresse.BackColor = System.Drawing.Color.White;
            this.txtClientCreate_adresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_adresse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_adresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientCreate_adresse.Location = new System.Drawing.Point(13, 5);
            this.txtClientCreate_adresse.Name = "txtClientCreate_adresse";
            this.txtClientCreate_adresse.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_adresse.TabIndex = 0;
            // 
            // lblClientCreate_prenom
            // 
            this.lblClientCreate_prenom.AutoSize = true;
            this.lblClientCreate_prenom.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_prenom.Location = new System.Drawing.Point(23, 335);
            this.lblClientCreate_prenom.Name = "lblClientCreate_prenom";
            this.lblClientCreate_prenom.Size = new System.Drawing.Size(85, 25);
            this.lblClientCreate_prenom.TabIndex = 25;
            this.lblClientCreate_prenom.Text = "prénom :";
            // 
            // lblClientCreate_email
            // 
            this.lblClientCreate_email.AutoSize = true;
            this.lblClientCreate_email.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_email.Location = new System.Drawing.Point(28, 470);
            this.lblClientCreate_email.Name = "lblClientCreate_email";
            this.lblClientCreate_email.Size = new System.Drawing.Size(80, 25);
            this.lblClientCreate_email.TabIndex = 28;
            this.lblClientCreate_email.Text = "courriel :";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtClientCreate_prenom);
            this.panel11.Location = new System.Drawing.Point(120, 331);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel11.Size = new System.Drawing.Size(287, 32);
            this.panel11.TabIndex = 2;
            // 
            // txtClientCreate_prenom
            // 
            this.txtClientCreate_prenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_prenom.BackColor = System.Drawing.Color.White;
            this.txtClientCreate_prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_prenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientCreate_prenom.Location = new System.Drawing.Point(13, 5);
            this.txtClientCreate_prenom.Name = "txtClientCreate_prenom";
            this.txtClientCreate_prenom.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_prenom.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txtClientCreate_email);
            this.panel9.Location = new System.Drawing.Point(120, 466);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel9.Size = new System.Drawing.Size(287, 32);
            this.panel9.TabIndex = 5;
            // 
            // txtClientCreate_email
            // 
            this.txtClientCreate_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_email.BackColor = System.Drawing.Color.White;
            this.txtClientCreate_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientCreate_email.Location = new System.Drawing.Point(13, 5);
            this.txtClientCreate_email.Name = "txtClientCreate_email";
            this.txtClientCreate_email.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_email.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtClientCreate_nom);
            this.panel10.Location = new System.Drawing.Point(120, 375);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel10.Size = new System.Drawing.Size(287, 32);
            this.panel10.TabIndex = 3;
            // 
            // txtClientCreate_nom
            // 
            this.txtClientCreate_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientCreate_nom.BackColor = System.Drawing.Color.White;
            this.txtClientCreate_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCreate_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientCreate_nom.Location = new System.Drawing.Point(13, 3);
            this.txtClientCreate_nom.Name = "txtClientCreate_nom";
            this.txtClientCreate_nom.Size = new System.Drawing.Size(259, 22);
            this.txtClientCreate_nom.TabIndex = 0;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label32.Location = new System.Drawing.Point(120, 247);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 25);
            this.label32.TabIndex = 23;
            this.label32.Text = "Client";
            // 
            // lblClientCreate_nom
            // 
            this.lblClientCreate_nom.AutoSize = true;
            this.lblClientCreate_nom.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_nom.Location = new System.Drawing.Point(50, 379);
            this.lblClientCreate_nom.Name = "lblClientCreate_nom";
            this.lblClientCreate_nom.Size = new System.Drawing.Size(58, 25);
            this.lblClientCreate_nom.TabIndex = 26;
            this.lblClientCreate_nom.Text = "nom :";
            // 
            // txtClientCreate_cancel
            // 
            this.txtClientCreate_cancel.BackColor = System.Drawing.Color.Teal;
            this.txtClientCreate_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtClientCreate_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClientCreate_cancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_cancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtClientCreate_cancel.Location = new System.Drawing.Point(293, 557);
            this.txtClientCreate_cancel.Name = "txtClientCreate_cancel";
            this.txtClientCreate_cancel.Size = new System.Drawing.Size(113, 35);
            this.txtClientCreate_cancel.TabIndex = 17;
            this.txtClientCreate_cancel.Text = "Annuler";
            this.txtClientCreate_cancel.UseVisualStyleBackColor = false;
            this.txtClientCreate_cancel.Click += new System.EventHandler(this.txtClientCreate_cancel_Click);
            this.txtClientCreate_cancel.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.txtClientCreate_cancel.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnClientCreate_add
            // 
            this.btnClientCreate_add.BackColor = System.Drawing.Color.Teal;
            this.btnClientCreate_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClientCreate_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientCreate_add.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCreate_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientCreate_add.Location = new System.Drawing.Point(170, 557);
            this.btnClientCreate_add.Name = "btnClientCreate_add";
            this.btnClientCreate_add.Size = new System.Drawing.Size(113, 35);
            this.btnClientCreate_add.TabIndex = 16;
            this.btnClientCreate_add.Text = "Ajouter";
            this.btnClientCreate_add.UseVisualStyleBackColor = false;
            this.btnClientCreate_add.Click += new System.EventHandler(this.btnClientCreate_add_Click);
            this.btnClientCreate_add.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnClientCreate_add.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(565, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "Double-click pour sélectionner le véhicule";
            // 
            // ReservationForm_version2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(903, 612);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(518, 228);
            this.Name = "ReservationForm_version2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_CarChoice.ResumeLayout(false);
            this.panel_CarChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AvailableCars)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtClientCreate_clientId;
        private System.Windows.Forms.Button btnReservationCreate_creerClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReservationCreate_DateOUT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbReservationCreate_HeureOUT;
        private System.Windows.Forms.ComboBox cbReservationCreate_Succursale;
        private System.Windows.Forms.Label lblReservationCreate_succursale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbReservationCreate_HeureIN;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReservationCreate_DateIN;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbReservationCreate_Types;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_AvailableCars;
        private System.Windows.Forms.TextBox txtReservation_carID;
        private System.Windows.Forms.TextBox txtReservation_plateNum;
        private System.Windows.Forms.TextBox txtReservation_modele;
        private System.Windows.Forms.TextBox txtReservation_fabriquant;
        private System.Windows.Forms.Label lblReservation_carChoice;
        private System.Windows.Forms.Panel panel_CarChoice;
        private System.Windows.Forms.Label label7;
    }
}