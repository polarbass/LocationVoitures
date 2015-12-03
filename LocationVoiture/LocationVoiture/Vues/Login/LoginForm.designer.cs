namespace LocationVoiture.Vues
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLogin_password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLogin_username = new System.Windows.Forms.TextBox();
            this.lblLoginForm_time = new System.Windows.Forms.Label();
            this.btnLogin_cancel = new System.Windows.Forms.Button();
            this.btnLogin_login = new System.Windows.Forms.Button();
            this.lblLogin_vosInfos = new System.Windows.Forms.Label();
            this.lblLogin_password = new System.Windows.Forms.Label();
            this.lblLogin_username = new System.Windows.Forms.Label();
            this.lblLogin_message2 = new System.Windows.Forms.Label();
            this.lblLogin_message1 = new System.Windows.Forms.Label();
            this.lblLoginForm_date = new System.Windows.Forms.Label();
            this.lblLogin_bonjour = new System.Windows.Forms.Label();
            this.lblLogin_compagnieName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timerLoginForm_clock = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogin_cancel);
            this.panel1.Controls.Add(this.btnLogin_login);
            this.panel1.Controls.Add(this.lblLogin_vosInfos);
            this.panel1.Controls.Add(this.lblLogin_password);
            this.panel1.Controls.Add(this.lblLogin_username);
            this.panel1.Controls.Add(this.lblLogin_message2);
            this.panel1.Controls.Add(this.lblLogin_message1);
            this.panel1.Controls.Add(this.lblLogin_bonjour);
            this.panel1.Controls.Add(this.lblLogin_compagnieName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 736);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtLogin_password);
            this.panel3.Location = new System.Drawing.Point(39, 489);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(287, 35);
            this.panel3.TabIndex = 15;
            // 
            // txtLogin_password
            // 
            this.txtLogin_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtLogin_password.BackColor = System.Drawing.Color.Black;
            this.txtLogin_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin_password.ForeColor = System.Drawing.Color.Silver;
            this.txtLogin_password.Location = new System.Drawing.Point(13, 5);
            this.txtLogin_password.Name = "txtLogin_password";
            this.txtLogin_password.PasswordChar = '*';
            this.txtLogin_password.Size = new System.Drawing.Size(259, 22);
            this.txtLogin_password.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtLogin_username);
            this.panel2.Location = new System.Drawing.Point(39, 387);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel2.Size = new System.Drawing.Size(287, 35);
            this.panel2.TabIndex = 14;
            // 
            // txtLogin_username
            // 
            this.txtLogin_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtLogin_username.BackColor = System.Drawing.Color.Black;
            this.txtLogin_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin_username.ForeColor = System.Drawing.Color.Silver;
            this.txtLogin_username.Location = new System.Drawing.Point(13, 6);
            this.txtLogin_username.Name = "txtLogin_username";
            this.txtLogin_username.Size = new System.Drawing.Size(259, 22);
            this.txtLogin_username.TabIndex = 8;
            // 
            // lblLoginForm_time
            // 
            this.lblLoginForm_time.AutoSize = true;
            this.lblLoginForm_time.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginForm_time.ForeColor = System.Drawing.Color.Silver;
            this.lblLoginForm_time.Location = new System.Drawing.Point(17, 30);
            this.lblLoginForm_time.Name = "lblLoginForm_time";
            this.lblLoginForm_time.Size = new System.Drawing.Size(0, 21);
            this.lblLoginForm_time.TabIndex = 13;
            // 
            // btnLogin_cancel
            // 
            this.btnLogin_cancel.BackColor = System.Drawing.Color.Black;
            this.btnLogin_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_cancel.ForeColor = System.Drawing.Color.Teal;
            this.btnLogin_cancel.Location = new System.Drawing.Point(152, 564);
            this.btnLogin_cancel.Name = "btnLogin_cancel";
            this.btnLogin_cancel.Size = new System.Drawing.Size(106, 48);
            this.btnLogin_cancel.TabIndex = 12;
            this.btnLogin_cancel.Text = "Cancel";
            this.btnLogin_cancel.UseVisualStyleBackColor = false;
            this.btnLogin_cancel.Click += new System.EventHandler(this.btnLogin_cancel_Click);
            this.btnLogin_cancel.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnLogin_cancel.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // btnLogin_login
            // 
            this.btnLogin_login.BackColor = System.Drawing.Color.Black;
            this.btnLogin_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_login.ForeColor = System.Drawing.Color.Teal;
            this.btnLogin_login.Location = new System.Drawing.Point(39, 564);
            this.btnLogin_login.Name = "btnLogin_login";
            this.btnLogin_login.Size = new System.Drawing.Size(106, 48);
            this.btnLogin_login.TabIndex = 11;
            this.btnLogin_login.Text = "Login";
            this.btnLogin_login.UseVisualStyleBackColor = false;
            this.btnLogin_login.Click += new System.EventHandler(this.btnLogin_login_Click);
            this.btnLogin_login.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnLogin_login.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // lblLogin_vosInfos
            // 
            this.lblLogin_vosInfos.AutoSize = true;
            this.lblLogin_vosInfos.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_vosInfos.ForeColor = System.Drawing.Color.Teal;
            this.lblLogin_vosInfos.Location = new System.Drawing.Point(39, 296);
            this.lblLogin_vosInfos.Name = "lblLogin_vosInfos";
            this.lblLogin_vosInfos.Size = new System.Drawing.Size(159, 25);
            this.lblLogin_vosInfos.TabIndex = 10;
            this.lblLogin_vosInfos.Text = "Vos informations";
            // 
            // lblLogin_password
            // 
            this.lblLogin_password.AutoSize = true;
            this.lblLogin_password.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_password.ForeColor = System.Drawing.Color.Silver;
            this.lblLogin_password.Location = new System.Drawing.Point(39, 453);
            this.lblLogin_password.Name = "lblLogin_password";
            this.lblLogin_password.Size = new System.Drawing.Size(129, 25);
            this.lblLogin_password.TabIndex = 7;
            this.lblLogin_password.Text = "mot de passe :";
            // 
            // lblLogin_username
            // 
            this.lblLogin_username.AutoSize = true;
            this.lblLogin_username.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_username.ForeColor = System.Drawing.Color.Silver;
            this.lblLogin_username.Location = new System.Drawing.Point(39, 354);
            this.lblLogin_username.Name = "lblLogin_username";
            this.lblLogin_username.Size = new System.Drawing.Size(131, 25);
            this.lblLogin_username.TabIndex = 6;
            this.lblLogin_username.Text = "nom d\'usager :";
            // 
            // lblLogin_message2
            // 
            this.lblLogin_message2.AutoSize = true;
            this.lblLogin_message2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_message2.ForeColor = System.Drawing.Color.Silver;
            this.lblLogin_message2.Location = new System.Drawing.Point(39, 244);
            this.lblLogin_message2.Name = "lblLogin_message2";
            this.lblLogin_message2.Size = new System.Drawing.Size(139, 25);
            this.lblLogin_message2.TabIndex = 5;
            this.lblLogin_message2.Text = "Bonne journée !";
            // 
            // lblLogin_message1
            // 
            this.lblLogin_message1.AutoSize = true;
            this.lblLogin_message1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_message1.ForeColor = System.Drawing.Color.Silver;
            this.lblLogin_message1.Location = new System.Drawing.Point(39, 176);
            this.lblLogin_message1.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblLogin_message1.Name = "lblLogin_message1";
            this.lblLogin_message1.Size = new System.Drawing.Size(324, 50);
            this.lblLogin_message1.TabIndex = 4;
            this.lblLogin_message1.Text = "Veuillez vous identifier avec votre nom d\'usager et mot de passe";
            // 
            // lblLoginForm_date
            // 
            this.lblLoginForm_date.AutoSize = true;
            this.lblLoginForm_date.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginForm_date.ForeColor = System.Drawing.Color.Silver;
            this.lblLoginForm_date.Location = new System.Drawing.Point(17, 8);
            this.lblLoginForm_date.Name = "lblLoginForm_date";
            this.lblLoginForm_date.Size = new System.Drawing.Size(0, 21);
            this.lblLoginForm_date.TabIndex = 3;
            // 
            // lblLogin_bonjour
            // 
            this.lblLogin_bonjour.AutoSize = true;
            this.lblLogin_bonjour.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_bonjour.ForeColor = System.Drawing.Color.Silver;
            this.lblLogin_bonjour.Location = new System.Drawing.Point(25, 136);
            this.lblLogin_bonjour.Name = "lblLogin_bonjour";
            this.lblLogin_bonjour.Size = new System.Drawing.Size(93, 32);
            this.lblLogin_bonjour.TabIndex = 2;
            this.lblLogin_bonjour.Text = "Bonjour";
            // 
            // lblLogin_compagnieName
            // 
            this.lblLogin_compagnieName.AutoSize = true;
            this.lblLogin_compagnieName.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_compagnieName.ForeColor = System.Drawing.Color.Teal;
            this.lblLogin_compagnieName.Location = new System.Drawing.Point(12, 7);
            this.lblLogin_compagnieName.Name = "lblLogin_compagnieName";
            this.lblLogin_compagnieName.Size = new System.Drawing.Size(246, 54);
            this.lblLogin_compagnieName.TabIndex = 1;
            this.lblLogin_compagnieName.Text = "Locomotion";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(884, 777);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Copyright @ BouryBoisvertLavigne 2015";
            // 
            // timerLoginForm_clock
            // 
            this.timerLoginForm_clock.Interval = 1000;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblLoginForm_date);
            this.panel4.Controls.Add(this.lblLoginForm_time);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 676);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 60);
            this.panel4.TabIndex = 16;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1140, 736);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin_compagnieName;
        private System.Windows.Forms.Label lblLogin_bonjour;
        private System.Windows.Forms.Label lblLogin_message2;
        private System.Windows.Forms.Label lblLogin_message1;
        private System.Windows.Forms.Label lblLoginForm_date;
        private System.Windows.Forms.TextBox txtLogin_username;
        private System.Windows.Forms.Label lblLogin_password;
        private System.Windows.Forms.Label lblLogin_username;
        private System.Windows.Forms.Label lblLogin_vosInfos;
        private System.Windows.Forms.Button btnLogin_cancel;
        private System.Windows.Forms.Button btnLogin_login;
        private System.Windows.Forms.Label lblLoginForm_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLogin_password;
        private System.Windows.Forms.Timer timerLoginForm_clock;
        private System.Windows.Forms.Panel panel4;
    }
}

