namespace LocationVoiture.Vues
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel_DefaultOperations = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel_Operations = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLocationModify = new System.Windows.Forms.Button();
            this.btnLocationCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmployeModify = new System.Windows.Forms.Button();
            this.btnEmployeCreate = new System.Windows.Forms.Button();
            this.lblReservation = new System.Windows.Forms.Label();
            this.btnSuccursaleCreate = new System.Windows.Forms.Button();
            this.btnReservationModify = new System.Windows.Forms.Button();
            this.btnSuccursaleModify = new System.Windows.Forms.Button();
            this.btnReservationCreate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCarCreate = new System.Windows.Forms.Button();
            this.btnClientModify = new System.Windows.Forms.Button();
            this.btnCarModify = new System.Windows.Forms.Button();
            this.btnClientCreate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMainForm_time = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMainForm_activeUser = new System.Windows.Forms.Label();
            this.lblMainForm_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timerMainForm_clock = new System.Windows.Forms.Timer(this.components);
            this.panel_Messages = new System.Windows.Forms.Panel();
            this.lblMainForm_Messages = new System.Windows.Forms.Label();
            this.timerMainForm_MessagesAnimations = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.panel_DefaultOperations.SuspendLayout();
            this.panel_Operations.SuspendLayout();
            this.panel_Messages.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel_DefaultOperations);
            this.mainPanel.Controls.Add(this.panel_Operations);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.lblMainForm_time);
            this.mainPanel.Controls.Add(this.lblOperation);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.lblMainForm_activeUser);
            this.mainPanel.Controls.Add(this.lblMainForm_date);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Location = new System.Drawing.Point(188, 38);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainPanel.Size = new System.Drawing.Size(784, 691);
            this.mainPanel.TabIndex = 0;
            // 
            // panel_DefaultOperations
            // 
            this.panel_DefaultOperations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_DefaultOperations.Controls.Add(this.btnQuitter);
            this.panel_DefaultOperations.Controls.Add(this.btnLogin);
            this.panel_DefaultOperations.Location = new System.Drawing.Point(253, 166);
            this.panel_DefaultOperations.Name = "panel_DefaultOperations";
            this.panel_DefaultOperations.Size = new System.Drawing.Size(118, 94);
            this.panel_DefaultOperations.TabIndex = 31;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitter.BackColor = System.Drawing.Color.Black;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Teal;
            this.btnQuitter.Location = new System.Drawing.Point(2, 51);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(113, 38);
            this.btnQuitter.TabIndex = 31;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            this.btnQuitter.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnQuitter.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 38);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel_Operations
            // 
            this.panel_Operations.Controls.Add(this.label4);
            this.panel_Operations.Controls.Add(this.btnLocationModify);
            this.panel_Operations.Controls.Add(this.btnLocationCreate);
            this.panel_Operations.Controls.Add(this.label1);
            this.panel_Operations.Controls.Add(this.btnEmployeModify);
            this.panel_Operations.Controls.Add(this.btnEmployeCreate);
            this.panel_Operations.Controls.Add(this.lblReservation);
            this.panel_Operations.Controls.Add(this.btnSuccursaleCreate);
            this.panel_Operations.Controls.Add(this.btnReservationModify);
            this.panel_Operations.Controls.Add(this.btnSuccursaleModify);
            this.panel_Operations.Controls.Add(this.btnReservationCreate);
            this.panel_Operations.Controls.Add(this.label13);
            this.panel_Operations.Controls.Add(this.label8);
            this.panel_Operations.Controls.Add(this.btnCarCreate);
            this.panel_Operations.Controls.Add(this.btnClientModify);
            this.panel_Operations.Controls.Add(this.btnCarModify);
            this.panel_Operations.Controls.Add(this.btnClientCreate);
            this.panel_Operations.Controls.Add(this.label12);
            this.panel_Operations.Location = new System.Drawing.Point(3, 261);
            this.panel_Operations.Name = "panel_Operations";
            this.panel_Operations.Size = new System.Drawing.Size(482, 367);
            this.panel_Operations.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(111, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Location";
            // 
            // btnLocationModify
            // 
            this.btnLocationModify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLocationModify.BackColor = System.Drawing.Color.Black;
            this.btnLocationModify.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLocationModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocationModify.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationModify.ForeColor = System.Drawing.Color.Teal;
            this.btnLocationModify.Location = new System.Drawing.Point(343, 318);
            this.btnLocationModify.Name = "btnLocationModify";
            this.btnLocationModify.Size = new System.Drawing.Size(113, 35);
            this.btnLocationModify.TabIndex = 34;
            this.btnLocationModify.Text = "Modifier";
            this.btnLocationModify.UseVisualStyleBackColor = false;
            // 
            // btnLocationCreate
            // 
            this.btnLocationCreate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLocationCreate.BackColor = System.Drawing.Color.Black;
            this.btnLocationCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLocationCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocationCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationCreate.ForeColor = System.Drawing.Color.Teal;
            this.btnLocationCreate.Location = new System.Drawing.Point(220, 318);
            this.btnLocationCreate.Name = "btnLocationCreate";
            this.btnLocationCreate.Size = new System.Drawing.Size(113, 35);
            this.btnLocationCreate.TabIndex = 35;
            this.btnLocationCreate.Text = "Créer";
            this.btnLocationCreate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(112, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Employé";
            // 
            // btnEmployeModify
            // 
            this.btnEmployeModify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEmployeModify.BackColor = System.Drawing.Color.Black;
            this.btnEmployeModify.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmployeModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeModify.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeModify.ForeColor = System.Drawing.Color.Teal;
            this.btnEmployeModify.Location = new System.Drawing.Point(343, 135);
            this.btnEmployeModify.Name = "btnEmployeModify";
            this.btnEmployeModify.Size = new System.Drawing.Size(113, 35);
            this.btnEmployeModify.TabIndex = 31;
            this.btnEmployeModify.Text = "Modifier";
            this.btnEmployeModify.UseVisualStyleBackColor = false;
            this.btnEmployeModify.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnEmployeModify.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnEmployeCreate
            // 
            this.btnEmployeCreate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEmployeCreate.BackColor = System.Drawing.Color.Black;
            this.btnEmployeCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmployeCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeCreate.ForeColor = System.Drawing.Color.Teal;
            this.btnEmployeCreate.Location = new System.Drawing.Point(220, 135);
            this.btnEmployeCreate.Name = "btnEmployeCreate";
            this.btnEmployeCreate.Size = new System.Drawing.Size(113, 35);
            this.btnEmployeCreate.TabIndex = 32;
            this.btnEmployeCreate.Text = "Créer";
            this.btnEmployeCreate.UseVisualStyleBackColor = false;
            this.btnEmployeCreate.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnEmployeCreate.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // lblReservation
            // 
            this.lblReservation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservation.ForeColor = System.Drawing.Color.Gray;
            this.lblReservation.Location = new System.Drawing.Point(83, 35);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(117, 25);
            this.lblReservation.TabIndex = 18;
            this.lblReservation.Text = "Réservation";
            // 
            // btnSuccursaleCreate
            // 
            this.btnSuccursaleCreate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSuccursaleCreate.BackColor = System.Drawing.Color.Black;
            this.btnSuccursaleCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccursaleCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccursaleCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccursaleCreate.ForeColor = System.Drawing.Color.Teal;
            this.btnSuccursaleCreate.Location = new System.Drawing.Point(220, 243);
            this.btnSuccursaleCreate.Name = "btnSuccursaleCreate";
            this.btnSuccursaleCreate.Size = new System.Drawing.Size(113, 35);
            this.btnSuccursaleCreate.TabIndex = 29;
            this.btnSuccursaleCreate.Text = "Créer";
            this.btnSuccursaleCreate.UseVisualStyleBackColor = false;
            // 
            // btnReservationModify
            // 
            this.btnReservationModify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReservationModify.BackColor = System.Drawing.Color.Black;
            this.btnReservationModify.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReservationModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationModify.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationModify.ForeColor = System.Drawing.Color.Teal;
            this.btnReservationModify.Location = new System.Drawing.Point(343, 28);
            this.btnReservationModify.Name = "btnReservationModify";
            this.btnReservationModify.Size = new System.Drawing.Size(113, 35);
            this.btnReservationModify.TabIndex = 19;
            this.btnReservationModify.Text = "Modifier";
            this.btnReservationModify.UseVisualStyleBackColor = false;
            this.btnReservationModify.Click += new System.EventHandler(this.btnReservationModify_Click);
            this.btnReservationModify.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnReservationModify.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnSuccursaleModify
            // 
            this.btnSuccursaleModify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSuccursaleModify.BackColor = System.Drawing.Color.Black;
            this.btnSuccursaleModify.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccursaleModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccursaleModify.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccursaleModify.ForeColor = System.Drawing.Color.Teal;
            this.btnSuccursaleModify.Location = new System.Drawing.Point(343, 243);
            this.btnSuccursaleModify.Name = "btnSuccursaleModify";
            this.btnSuccursaleModify.Size = new System.Drawing.Size(113, 35);
            this.btnSuccursaleModify.TabIndex = 28;
            this.btnSuccursaleModify.Text = "Modifier";
            this.btnSuccursaleModify.UseVisualStyleBackColor = false;
            // 
            // btnReservationCreate
            // 
            this.btnReservationCreate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReservationCreate.BackColor = System.Drawing.Color.Black;
            this.btnReservationCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReservationCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationCreate.ForeColor = System.Drawing.Color.Teal;
            this.btnReservationCreate.Location = new System.Drawing.Point(220, 28);
            this.btnReservationCreate.Name = "btnReservationCreate";
            this.btnReservationCreate.Size = new System.Drawing.Size(113, 35);
            this.btnReservationCreate.TabIndex = 20;
            this.btnReservationCreate.Text = "Créer";
            this.btnReservationCreate.UseVisualStyleBackColor = false;
            this.btnReservationCreate.Click += new System.EventHandler(this.btnReservationCreate_Click);
            this.btnReservationCreate.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnReservationCreate.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(94, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Succursale";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(137, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Client";
            // 
            // btnCarCreate
            // 
            this.btnCarCreate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCarCreate.BackColor = System.Drawing.Color.Black;
            this.btnCarCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCarCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarCreate.ForeColor = System.Drawing.Color.Teal;
            this.btnCarCreate.Location = new System.Drawing.Point(220, 193);
            this.btnCarCreate.Name = "btnCarCreate";
            this.btnCarCreate.Size = new System.Drawing.Size(113, 35);
            this.btnCarCreate.TabIndex = 26;
            this.btnCarCreate.Text = "Créer";
            this.btnCarCreate.UseVisualStyleBackColor = false;
            this.btnCarCreate.Click += new System.EventHandler(this.btnCarCreate_Click);
            // 
            // btnClientModify
            // 
            this.btnClientModify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClientModify.BackColor = System.Drawing.Color.Black;
            this.btnClientModify.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClientModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientModify.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientModify.ForeColor = System.Drawing.Color.Teal;
            this.btnClientModify.Location = new System.Drawing.Point(343, 83);
            this.btnClientModify.Name = "btnClientModify";
            this.btnClientModify.Size = new System.Drawing.Size(113, 35);
            this.btnClientModify.TabIndex = 22;
            this.btnClientModify.Text = "Modifier";
            this.btnClientModify.UseVisualStyleBackColor = false;
            this.btnClientModify.Click += new System.EventHandler(this.btnClientModify_Click);
            this.btnClientModify.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnClientModify.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnCarModify
            // 
            this.btnCarModify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCarModify.BackColor = System.Drawing.Color.Black;
            this.btnCarModify.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCarModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarModify.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarModify.ForeColor = System.Drawing.Color.Teal;
            this.btnCarModify.Location = new System.Drawing.Point(343, 193);
            this.btnCarModify.Name = "btnCarModify";
            this.btnCarModify.Size = new System.Drawing.Size(113, 35);
            this.btnCarModify.TabIndex = 25;
            this.btnCarModify.Text = "Modifier";
            this.btnCarModify.UseVisualStyleBackColor = false;
            this.btnCarModify.Click += new System.EventHandler(this.btnCarModify_Click);
            // 
            // btnClientCreate
            // 
            this.btnClientCreate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClientCreate.BackColor = System.Drawing.Color.Black;
            this.btnClientCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClientCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCreate.ForeColor = System.Drawing.Color.Teal;
            this.btnClientCreate.Location = new System.Drawing.Point(220, 83);
            this.btnClientCreate.Name = "btnClientCreate";
            this.btnClientCreate.Size = new System.Drawing.Size(113, 35);
            this.btnClientCreate.TabIndex = 23;
            this.btnClientCreate.Text = "Créer";
            this.btnClientCreate.UseVisualStyleBackColor = false;
            this.btnClientCreate.Click += new System.EventHandler(this.btnClientCreate_Click);
            this.btnClientCreate.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnClientCreate.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(122, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "Voiture";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(95, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "administrateur";
            // 
            // lblMainForm_time
            // 
            this.lblMainForm_time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMainForm_time.AutoSize = true;
            this.lblMainForm_time.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainForm_time.ForeColor = System.Drawing.Color.Silver;
            this.lblMainForm_time.Location = new System.Drawing.Point(14, 43);
            this.lblMainForm_time.Name = "lblMainForm_time";
            this.lblMainForm_time.Size = new System.Drawing.Size(0, 21);
            this.lblMainForm_time.TabIndex = 13;
            // 
            // lblOperation
            // 
            this.lblOperation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.ForeColor = System.Drawing.Color.Teal;
            this.lblOperation.Location = new System.Drawing.Point(33, 174);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(205, 25);
            this.lblOperation.TabIndex = 10;
            this.lblOperation.Text = "Choisir une opération";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(72, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 0);
            this.button1.TabIndex = 11;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblMainForm_activeUser
            // 
            this.lblMainForm_activeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMainForm_activeUser.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainForm_activeUser.ForeColor = System.Drawing.Color.Silver;
            this.lblMainForm_activeUser.Location = new System.Drawing.Point(100, 147);
            this.lblMainForm_activeUser.Name = "lblMainForm_activeUser";
            this.lblMainForm_activeUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMainForm_activeUser.Size = new System.Drawing.Size(130, 21);
            this.lblMainForm_activeUser.TabIndex = 4;
            this.lblMainForm_activeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMainForm_date
            // 
            this.lblMainForm_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMainForm_date.AutoSize = true;
            this.lblMainForm_date.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainForm_date.ForeColor = System.Drawing.Color.Silver;
            this.lblMainForm_date.Location = new System.Drawing.Point(14, 21);
            this.lblMainForm_date.Name = "lblMainForm_date";
            this.lblMainForm_date.Size = new System.Drawing.Size(0, 21);
            this.lblMainForm_date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Locomotion";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(1185, 977);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Copyright @ BouryBoisvertLavigne 2015";
            // 
            // timerMainForm_clock
            // 
            this.timerMainForm_clock.Interval = 1000;
            // 
            // panel_Messages
            // 
            this.panel_Messages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Messages.BackColor = System.Drawing.Color.Black;
            this.panel_Messages.Controls.Add(this.lblMainForm_Messages);
            this.panel_Messages.Location = new System.Drawing.Point(188, 1);
            this.panel_Messages.Name = "panel_Messages";
            this.panel_Messages.Size = new System.Drawing.Size(1257, 46);
            this.panel_Messages.TabIndex = 30;
            // 
            // lblMainForm_Messages
            // 
            this.lblMainForm_Messages.AutoSize = true;
            this.lblMainForm_Messages.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainForm_Messages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMainForm_Messages.Location = new System.Drawing.Point(18, 9);
            this.lblMainForm_Messages.Name = "lblMainForm_Messages";
            this.lblMainForm_Messages.Size = new System.Drawing.Size(0, 25);
            this.lblMainForm_Messages.TabIndex = 0;
            // 
            // timerMainForm_MessagesAnimations
            // 
            this.timerMainForm_MessagesAnimations.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1441, 765);
            this.Controls.Add(this.panel_Messages);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel_DefaultOperations.ResumeLayout(false);
            this.panel_Operations.ResumeLayout(false);
            this.panel_Operations.PerformLayout();
            this.panel_Messages.ResumeLayout(false);
            this.panel_Messages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMainForm_activeUser;
        private System.Windows.Forms.Label lblMainForm_date;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMainForm_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Button btnReservationModify;
        private System.Windows.Forms.Button btnCarCreate;
        private System.Windows.Forms.Button btnCarModify;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClientCreate;
        private System.Windows.Forms.Button btnClientModify;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReservationCreate;
        private System.Windows.Forms.Button btnSuccursaleCreate;
        private System.Windows.Forms.Button btnSuccursaleModify;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timerMainForm_clock;
        private System.Windows.Forms.Panel panel_Messages;
        private System.Windows.Forms.Timer timerMainForm_MessagesAnimations;
        private System.Windows.Forms.Label lblMainForm_Messages;
        private System.Windows.Forms.Panel panel_Operations;
        private System.Windows.Forms.Panel panel_DefaultOperations;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmployeModify;
        private System.Windows.Forms.Button btnEmployeCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLocationModify;
        private System.Windows.Forms.Button btnLocationCreate;
    }
}

