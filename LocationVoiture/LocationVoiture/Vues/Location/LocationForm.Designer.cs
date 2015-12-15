﻿namespace LocationVoiture.Vues
{
    partial class LocationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_today = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_reservation = new System.Windows.Forms.DataGridView();
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
            this.cbReservationCreate_noPlaque = new System.Windows.Forms.ComboBox();
            this.cbReservationCreate_nbPassager = new System.Windows.Forms.ComboBox();
            this.cbReservationCreate_model = new System.Windows.Forms.ComboBox();
            this.cbReservationCreate_marque = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
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
            this.lblReservation_today = new System.Windows.Forms.Label();
            this.lblFacture = new System.Windows.Forms.Label();
            this.panel_Facture = new System.Windows.Forms.Panel();
            this.lblReservation_carChoice = new System.Windows.Forms.Label();
            this.txtLocation_client = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocation_voiture = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLocation_categorie = new System.Windows.Forms.TextBox();
            this.txtLocation_nbJours = new System.Windows.Forms.TextBox();
            this.txtLocation_total = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservation)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelClientForm_id.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel_Facture.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel_Facture);
            this.panel1.Controls.Add(this.lblFacture);
            this.panel1.Controls.Add(this.dateTimePicker_today);
            this.panel1.Controls.Add(this.dataGridView_reservation);
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
            this.panel1.Controls.Add(this.cbReservationCreate_noPlaque);
            this.panel1.Controls.Add(this.cbReservationCreate_nbPassager);
            this.panel1.Controls.Add(this.cbReservationCreate_model);
            this.panel1.Controls.Add(this.cbReservationCreate_marque);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label21);
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
            this.panel1.Controls.Add(this.lblReservation_today);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 562);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker_today
            // 
            this.dateTimePicker_today.Location = new System.Drawing.Point(895, 3);
            this.dateTimePicker_today.Name = "dateTimePicker_today";
            this.dateTimePicker_today.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_today.TabIndex = 43;
            this.dateTimePicker_today.Value = new System.DateTime(2015, 12, 6, 23, 33, 49, 0);
            this.dateTimePicker_today.Visible = false;
            // 
            // dataGridView_reservation
            // 
            this.dataGridView_reservation.AllowUserToAddRows = false;
            this.dataGridView_reservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_reservation.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_reservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_reservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_reservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.NullValue = "-------------";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_reservation.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_reservation.GridColor = System.Drawing.Color.Teal;
            this.dataGridView_reservation.Location = new System.Drawing.Point(895, 79);
            this.dataGridView_reservation.MultiSelect = false;
            this.dataGridView_reservation.Name = "dataGridView_reservation";
            this.dataGridView_reservation.RowTemplate.Height = 36;
            this.dataGridView_reservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_reservation.Size = new System.Drawing.Size(534, 272);
            this.dataGridView_reservation.TabIndex = 16;
            this.dataGridView_reservation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_reservation_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(890, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Réservations : ";
            // 
            // dateTimePicker_ReservationCreate_DateIN
            // 
            this.dateTimePicker_ReservationCreate_DateIN.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReservationCreate_DateIN.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker_ReservationCreate_DateIN.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker_ReservationCreate_DateIN.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker_ReservationCreate_DateIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReservationCreate_DateIN.Location = new System.Drawing.Point(571, 488);
            this.dateTimePicker_ReservationCreate_DateIN.MinDate = new System.DateTime(2015, 10, 25, 0, 0, 0, 0);
            this.dateTimePicker_ReservationCreate_DateIN.Name = "dateTimePicker_ReservationCreate_DateIN";
            this.dateTimePicker_ReservationCreate_DateIN.Size = new System.Drawing.Size(286, 29);
            this.dateTimePicker_ReservationCreate_DateIN.TabIndex = 14;
            // 
            // dateTimePicker_ReservationCreate_DateOUT
            // 
            this.dateTimePicker_ReservationCreate_DateOUT.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker_ReservationCreate_DateOUT.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker_ReservationCreate_DateOUT.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker_ReservationCreate_DateOUT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReservationCreate_DateOUT.Location = new System.Drawing.Point(571, 367);
            this.dateTimePicker_ReservationCreate_DateOUT.MinDate = new System.DateTime(2015, 10, 25, 0, 0, 0, 0);
            this.dateTimePicker_ReservationCreate_DateOUT.Name = "dateTimePicker_ReservationCreate_DateOUT";
            this.dateTimePicker_ReservationCreate_DateOUT.Size = new System.Drawing.Size(286, 29);
            this.dateTimePicker_ReservationCreate_DateOUT.TabIndex = 12;
            this.dateTimePicker_ReservationCreate_DateOUT.Value = new System.DateTime(2015, 11, 17, 15, 9, 37, 0);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Teal;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLoading.Location = new System.Drawing.Point(121, 147);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(135, 17);
            this.lblLoading.TabIndex = 23;
            this.lblLoading.Text = "Recherche en cours ...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(484, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Retour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(482, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Départ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(634, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 40;
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
            this.cbReservationCreate_HeureIN.Location = new System.Drawing.Point(705, 528);
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
            this.cbReservationCreate_Succursale.Location = new System.Drawing.Point(642, 48);
            this.cbReservationCreate_Succursale.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbReservationCreate_Succursale.Name = "cbReservationCreate_Succursale";
            this.cbReservationCreate_Succursale.Size = new System.Drawing.Size(222, 29);
            this.cbReservationCreate_Succursale.TabIndex = 7;
            this.cbReservationCreate_Succursale.SelectedIndexChanged += new System.EventHandler(this.cbReservationCreate_Succursale_SelectedIndexChanged);
            // 
            // lblReservationCreate_succursale
            // 
            this.lblReservationCreate_succursale.AutoSize = true;
            this.lblReservationCreate_succursale.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReservationCreate_succursale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReservationCreate_succursale.Location = new System.Drawing.Point(638, 21);
            this.lblReservationCreate_succursale.Name = "lblReservationCreate_succursale";
            this.lblReservationCreate_succursale.Size = new System.Drawing.Size(106, 25);
            this.lblReservationCreate_succursale.TabIndex = 31;
            this.lblReservationCreate_succursale.Text = "Succursale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(632, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 38;
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
            this.cbReservationCreate_HeureOUT.Location = new System.Drawing.Point(704, 403);
            this.cbReservationCreate_HeureOUT.Name = "cbReservationCreate_HeureOUT";
            this.cbReservationCreate_HeureOUT.Size = new System.Drawing.Size(154, 28);
            this.cbReservationCreate_HeureOUT.TabIndex = 13;
            // 
            // cbReservationCreate_noPlaque
            // 
            this.cbReservationCreate_noPlaque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbReservationCreate_noPlaque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservationCreate_noPlaque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbReservationCreate_noPlaque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReservationCreate_noPlaque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbReservationCreate_noPlaque.FormattingEnabled = true;
            this.cbReservationCreate_noPlaque.Location = new System.Drawing.Point(642, 251);
            this.cbReservationCreate_noPlaque.Name = "cbReservationCreate_noPlaque";
            this.cbReservationCreate_noPlaque.Size = new System.Drawing.Size(222, 29);
            this.cbReservationCreate_noPlaque.TabIndex = 11;
            // 
            // cbReservationCreate_nbPassager
            // 
            this.cbReservationCreate_nbPassager.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbReservationCreate_nbPassager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservationCreate_nbPassager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbReservationCreate_nbPassager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReservationCreate_nbPassager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbReservationCreate_nbPassager.FormattingEnabled = true;
            this.cbReservationCreate_nbPassager.Location = new System.Drawing.Point(642, 213);
            this.cbReservationCreate_nbPassager.Name = "cbReservationCreate_nbPassager";
            this.cbReservationCreate_nbPassager.Size = new System.Drawing.Size(222, 29);
            this.cbReservationCreate_nbPassager.TabIndex = 10;
            this.cbReservationCreate_nbPassager.SelectedIndexChanged += new System.EventHandler(this.cbReservationCreate_nbPassager_SelectedIndexChanged);
            // 
            // cbReservationCreate_model
            // 
            this.cbReservationCreate_model.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbReservationCreate_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservationCreate_model.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbReservationCreate_model.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReservationCreate_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbReservationCreate_model.FormattingEnabled = true;
            this.cbReservationCreate_model.Location = new System.Drawing.Point(642, 175);
            this.cbReservationCreate_model.Name = "cbReservationCreate_model";
            this.cbReservationCreate_model.Size = new System.Drawing.Size(222, 29);
            this.cbReservationCreate_model.TabIndex = 9;
            this.cbReservationCreate_model.SelectedIndexChanged += new System.EventHandler(this.cbReservationCreate_model_SelectedIndexChanged);
            // 
            // cbReservationCreate_marque
            // 
            this.cbReservationCreate_marque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbReservationCreate_marque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservationCreate_marque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbReservationCreate_marque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReservationCreate_marque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbReservationCreate_marque.FormattingEnabled = true;
            this.cbReservationCreate_marque.Location = new System.Drawing.Point(642, 138);
            this.cbReservationCreate_marque.Name = "cbReservationCreate_marque";
            this.cbReservationCreate_marque.Size = new System.Drawing.Size(222, 29);
            this.cbReservationCreate_marque.TabIndex = 8;
            this.cbReservationCreate_marque.SelectedIndexChanged += new System.EventHandler(this.cbReservation_marque_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label25.Location = new System.Drawing.Point(437, 213);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(189, 25);
            this.label25.TabIndex = 35;
            this.label25.Text = "Nombre de passager :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(453, 250);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(173, 25);
            this.label24.TabIndex = 36;
            this.label24.Text = "Numéro de plaque :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(553, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 25);
            this.label23.TabIndex = 34;
            this.label23.Text = "Model :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(543, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 25);
            this.label17.TabIndex = 33;
            this.label17.Text = "Marque :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(638, 102);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 25);
            this.label21.TabIndex = 32;
            this.label21.Text = "Voiture";
            // 
            // btnReservationCreate_creerClient
            // 
            this.btnReservationCreate_creerClient.BackColor = System.Drawing.Color.Teal;
            this.btnReservationCreate_creerClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReservationCreate_creerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationCreate_creerClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationCreate_creerClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservationCreate_creerClient.Location = new System.Drawing.Point(292, 147);
            this.btnReservationCreate_creerClient.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservationCreate_creerClient.Name = "btnReservationCreate_creerClient";
            this.btnReservationCreate_creerClient.Size = new System.Drawing.Size(113, 32);
            this.btnReservationCreate_creerClient.TabIndex = 20;
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
            this.lblClientCreate_clientId.Location = new System.Drawing.Point(72, 233);
            this.lblClientCreate_clientId.Name = "lblClientCreate_clientId";
            this.lblClientCreate_clientId.Size = new System.Drawing.Size(36, 25);
            this.lblClientCreate_clientId.TabIndex = 25;
            this.lblClientCreate_clientId.Text = "id :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtClientCreate_clientId);
            this.panel2.Location = new System.Drawing.Point(120, 229);
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
            this.btnClientForm_Find.Location = new System.Drawing.Point(292, 108);
            this.btnClientForm_Find.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientForm_Find.Name = "btnClientForm_Find";
            this.btnClientForm_Find.Size = new System.Drawing.Size(113, 32);
            this.btnClientForm_Find.TabIndex = 19;
            this.btnClientForm_Find.Text = "Trouver";
            this.btnClientForm_Find.UseVisualStyleBackColor = false;
            this.btnClientForm_Find.Click += new System.EventHandler(this.btnClientForm_Find_Click);
            this.btnClientForm_Find.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnClientForm_Find.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // lblClientCreate_id
            // 
            this.lblClientCreate_id.AutoSize = true;
            this.lblClientCreate_id.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_id.Location = new System.Drawing.Point(119, 79);
            this.lblClientCreate_id.Name = "lblClientCreate_id";
            this.lblClientCreate_id.Size = new System.Drawing.Size(83, 25);
            this.lblClientCreate_id.TabIndex = 22;
            this.lblClientCreate_id.Text = "client id :";
            // 
            // panelClientForm_id
            // 
            this.panelClientForm_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientForm_id.Controls.Add(this.txtClientCreate_idSearch);
            this.panelClientForm_id.Location = new System.Drawing.Point(120, 108);
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
            this.lblClientCreate_operation.Location = new System.Drawing.Point(120, 12);
            this.lblClientCreate_operation.Name = "lblClientCreate_operation";
            this.lblClientCreate_operation.Size = new System.Drawing.Size(226, 32);
            this.lblClientCreate_operation.TabIndex = 21;
            this.lblClientCreate_operation.Text = "Créer une location";
            // 
            // lblClientCreate_phone
            // 
            this.lblClientCreate_phone.AutoSize = true;
            this.lblClientCreate_phone.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_phone.Location = new System.Drawing.Point(5, 368);
            this.lblClientCreate_phone.Name = "lblClientCreate_phone";
            this.lblClientCreate_phone.Size = new System.Drawing.Size(103, 25);
            this.lblClientCreate_phone.TabIndex = 28;
            this.lblClientCreate_phone.Text = "téléphone :";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtClientCreate_phone);
            this.panel13.Location = new System.Drawing.Point(120, 364);
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
            this.lblClientCreate_adresse.Location = new System.Drawing.Point(27, 461);
            this.lblClientCreate_adresse.Name = "lblClientCreate_adresse";
            this.lblClientCreate_adresse.Size = new System.Drawing.Size(81, 25);
            this.lblClientCreate_adresse.TabIndex = 30;
            this.lblClientCreate_adresse.Text = "adresse :";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.txtClientCreate_adresse);
            this.panel12.Location = new System.Drawing.Point(120, 457);
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
            this.lblClientCreate_prenom.Location = new System.Drawing.Point(23, 279);
            this.lblClientCreate_prenom.Name = "lblClientCreate_prenom";
            this.lblClientCreate_prenom.Size = new System.Drawing.Size(85, 25);
            this.lblClientCreate_prenom.TabIndex = 26;
            this.lblClientCreate_prenom.Text = "prénom :";
            // 
            // lblClientCreate_email
            // 
            this.lblClientCreate_email.AutoSize = true;
            this.lblClientCreate_email.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_email.Location = new System.Drawing.Point(28, 414);
            this.lblClientCreate_email.Name = "lblClientCreate_email";
            this.lblClientCreate_email.Size = new System.Drawing.Size(80, 25);
            this.lblClientCreate_email.TabIndex = 29;
            this.lblClientCreate_email.Text = "courriel :";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtClientCreate_prenom);
            this.panel11.Location = new System.Drawing.Point(120, 275);
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
            this.panel9.Location = new System.Drawing.Point(120, 410);
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
            this.panel10.Location = new System.Drawing.Point(120, 319);
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
            this.label32.Location = new System.Drawing.Point(120, 191);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 25);
            this.label32.TabIndex = 24;
            this.label32.Text = "Client";
            // 
            // lblClientCreate_nom
            // 
            this.lblClientCreate_nom.AutoSize = true;
            this.lblClientCreate_nom.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCreate_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientCreate_nom.Location = new System.Drawing.Point(50, 323);
            this.lblClientCreate_nom.Name = "lblClientCreate_nom";
            this.lblClientCreate_nom.Size = new System.Drawing.Size(58, 25);
            this.lblClientCreate_nom.TabIndex = 27;
            this.lblClientCreate_nom.Text = "nom :";
            // 
            // txtClientCreate_cancel
            // 
            this.txtClientCreate_cancel.BackColor = System.Drawing.Color.Teal;
            this.txtClientCreate_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtClientCreate_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClientCreate_cancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCreate_cancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtClientCreate_cancel.Location = new System.Drawing.Point(293, 523);
            this.txtClientCreate_cancel.Name = "txtClientCreate_cancel";
            this.txtClientCreate_cancel.Size = new System.Drawing.Size(113, 35);
            this.txtClientCreate_cancel.TabIndex = 18;
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
            this.btnClientCreate_add.Location = new System.Drawing.Point(170, 523);
            this.btnClientCreate_add.Name = "btnClientCreate_add";
            this.btnClientCreate_add.Size = new System.Drawing.Size(113, 35);
            this.btnClientCreate_add.TabIndex = 17;
            this.btnClientCreate_add.Text = "Ajouter";
            this.btnClientCreate_add.UseVisualStyleBackColor = false;
            this.btnClientCreate_add.Click += new System.EventHandler(this.btnClientCreate_add_Click);
            this.btnClientCreate_add.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnClientCreate_add.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // lblReservation_today
            // 
            this.lblReservation_today.AutoSize = true;
            this.lblReservation_today.BackColor = System.Drawing.Color.White;
            this.lblReservation_today.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservation_today.ForeColor = System.Drawing.Color.Silver;
            this.lblReservation_today.Location = new System.Drawing.Point(891, 42);
            this.lblReservation_today.Name = "lblReservation_today";
            this.lblReservation_today.Size = new System.Drawing.Size(186, 21);
            this.lblReservation_today.TabIndex = 42;
            this.lblReservation_today.Text = "Lundi 7 décembre 2015";
            // 
            // lblFacture
            // 
            this.lblFacture.AutoSize = true;
            this.lblFacture.BackColor = System.Drawing.Color.White;
            this.lblFacture.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFacture.Location = new System.Drawing.Point(896, 366);
            this.lblFacture.Name = "lblFacture";
            this.lblFacture.Size = new System.Drawing.Size(92, 25);
            this.lblFacture.TabIndex = 44;
            this.lblFacture.Text = "Facture : ";
            // 
            // panel_Facture
            // 
            this.panel_Facture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Facture.Controls.Add(this.txtLocation_total);
            this.panel_Facture.Controls.Add(this.txtLocation_nbJours);
            this.panel_Facture.Controls.Add(this.txtLocation_categorie);
            this.panel_Facture.Controls.Add(this.label10);
            this.panel_Facture.Controls.Add(this.label9);
            this.panel_Facture.Controls.Add(this.label8);
            this.panel_Facture.Controls.Add(this.txtLocation_voiture);
            this.panel_Facture.Controls.Add(this.label7);
            this.panel_Facture.Controls.Add(this.lblReservation_carChoice);
            this.panel_Facture.Controls.Add(this.txtLocation_client);
            this.panel_Facture.Location = new System.Drawing.Point(895, 399);
            this.panel_Facture.Name = "panel_Facture";
            this.panel_Facture.Size = new System.Drawing.Size(534, 156);
            this.panel_Facture.TabIndex = 47;
            // 
            // lblReservation_carChoice
            // 
            this.lblReservation_carChoice.AutoSize = true;
            this.lblReservation_carChoice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservation_carChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReservation_carChoice.Location = new System.Drawing.Point(21, 8);
            this.lblReservation_carChoice.Name = "lblReservation_carChoice";
            this.lblReservation_carChoice.Size = new System.Drawing.Size(75, 25);
            this.lblReservation_carChoice.TabIndex = 45;
            this.lblReservation_carChoice.Text = "Client : ";
            this.lblReservation_carChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocation_client
            // 
            this.txtLocation_client.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLocation_client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation_client.Enabled = false;
            this.txtLocation_client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation_client.ForeColor = System.Drawing.Color.Black;
            this.txtLocation_client.Location = new System.Drawing.Point(156, 9);
            this.txtLocation_client.Name = "txtLocation_client";
            this.txtLocation_client.Size = new System.Drawing.Size(225, 22);
            this.txtLocation_client.TabIndex = 0;
            this.txtLocation_client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(21, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Voiture : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocation_voiture
            // 
            this.txtLocation_voiture.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLocation_voiture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation_voiture.Enabled = false;
            this.txtLocation_voiture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation_voiture.ForeColor = System.Drawing.Color.Black;
            this.txtLocation_voiture.Location = new System.Drawing.Point(156, 38);
            this.txtLocation_voiture.Name = "txtLocation_voiture";
            this.txtLocation_voiture.Size = new System.Drawing.Size(225, 22);
            this.txtLocation_voiture.TabIndex = 47;
            this.txtLocation_voiture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(21, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Catégorie : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(21, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Nb de jours : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(21, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Total : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocation_categorie
            // 
            this.txtLocation_categorie.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLocation_categorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation_categorie.Enabled = false;
            this.txtLocation_categorie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation_categorie.ForeColor = System.Drawing.Color.Black;
            this.txtLocation_categorie.Location = new System.Drawing.Point(156, 67);
            this.txtLocation_categorie.Name = "txtLocation_categorie";
            this.txtLocation_categorie.Size = new System.Drawing.Size(225, 22);
            this.txtLocation_categorie.TabIndex = 51;
            this.txtLocation_categorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLocation_nbJours
            // 
            this.txtLocation_nbJours.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLocation_nbJours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation_nbJours.Enabled = false;
            this.txtLocation_nbJours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation_nbJours.ForeColor = System.Drawing.Color.Black;
            this.txtLocation_nbJours.Location = new System.Drawing.Point(156, 96);
            this.txtLocation_nbJours.Name = "txtLocation_nbJours";
            this.txtLocation_nbJours.Size = new System.Drawing.Size(225, 22);
            this.txtLocation_nbJours.TabIndex = 52;
            this.txtLocation_nbJours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLocation_total
            // 
            this.txtLocation_total.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLocation_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation_total.Enabled = false;
            this.txtLocation_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation_total.ForeColor = System.Drawing.Color.Black;
            this.txtLocation_total.Location = new System.Drawing.Point(156, 125);
            this.txtLocation_total.Name = "txtLocation_total";
            this.txtLocation_total.Size = new System.Drawing.Size(225, 22);
            this.txtLocation_total.TabIndex = 53;
            this.txtLocation_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1441, 562);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(518, 228);
            this.Name = "LocationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservation)).EndInit();
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
            this.panel_Facture.ResumeLayout(false);
            this.panel_Facture.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbReservationCreate_noPlaque;
        private System.Windows.Forms.ComboBox cbReservationCreate_nbPassager;
        private System.Windows.Forms.ComboBox cbReservationCreate_model;
        private System.Windows.Forms.ComboBox cbReservationCreate_marque;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReservation_today;
        private System.Windows.Forms.DataGridView dataGridView_reservation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_today;
        private System.Windows.Forms.Label lblFacture;
        private System.Windows.Forms.Panel panel_Facture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReservation_carChoice;
        private System.Windows.Forms.TextBox txtLocation_client;
        private System.Windows.Forms.TextBox txtLocation_total;
        private System.Windows.Forms.TextBox txtLocation_nbJours;
        private System.Windows.Forms.TextBox txtLocation_categorie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLocation_voiture;
    }
}