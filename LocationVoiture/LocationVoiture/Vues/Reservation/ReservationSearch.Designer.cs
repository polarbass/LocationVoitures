namespace LocationVoiture.Vues
{
    partial class ReservationSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_message = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReservationSearch_select = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtReservationSearch_value = new System.Windows.Forms.TextBox();
            this.btnReservationSearch_find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboReservationSearch_FindBy = new System.Windows.Forms.ComboBox();
            this.btnReservationSearch_cancel = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_message.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel_message);
            this.panel1.Controls.Add(this.btnReservationSearch_select);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.btnReservationSearch_find);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboReservationSearch_FindBy);
            this.panel1.Controls.Add(this.btnReservationSearch_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 525);
            this.panel1.TabIndex = 0;
            // 
            // panel_message
            // 
            this.panel_message.BackColor = System.Drawing.Color.Teal;
            this.panel_message.Controls.Add(this.label3);
            this.panel_message.Location = new System.Drawing.Point(296, 59);
            this.panel_message.Name = "panel_message";
            this.panel_message.Size = new System.Drawing.Size(314, 28);
            this.panel_message.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(67, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Aucune réservation trouvée";
            // 
            // btnReservationSearch_select
            // 
            this.btnReservationSearch_select.BackColor = System.Drawing.Color.Teal;
            this.btnReservationSearch_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservationSearch_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationSearch_select.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservationSearch_select.Location = new System.Drawing.Point(15, 422);
            this.btnReservationSearch_select.Name = "btnReservationSearch_select";
            this.btnReservationSearch_select.Size = new System.Drawing.Size(214, 32);
            this.btnReservationSearch_select.TabIndex = 16;
            this.btnReservationSearch_select.Text = "Selectionner";
            this.btnReservationSearch_select.UseVisualStyleBackColor = false;
            this.btnReservationSearch_select.Click += new System.EventHandler(this.btnClientSearch_select_Click);
            this.btnReservationSearch_select.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnReservationSearch_select.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.dateTimePicker);
            this.panel11.Controls.Add(this.txtReservationSearch_value);
            this.panel11.Location = new System.Drawing.Point(296, 93);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel11.Size = new System.Drawing.Size(314, 32);
            this.panel11.TabIndex = 15;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(14, 2);
            this.dateTimePicker.MinDate = new System.DateTime(2015, 11, 17, 15, 9, 37, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(286, 26);
            this.dateTimePicker.TabIndex = 37;
            this.dateTimePicker.Value = new System.DateTime(2015, 11, 17, 15, 9, 37, 0);
            // 
            // txtReservationSearch_value
            // 
            this.txtReservationSearch_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtReservationSearch_value.BackColor = System.Drawing.Color.White;
            this.txtReservationSearch_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservationSearch_value.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationSearch_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReservationSearch_value.Location = new System.Drawing.Point(13, 3);
            this.txtReservationSearch_value.Name = "txtReservationSearch_value";
            this.txtReservationSearch_value.Size = new System.Drawing.Size(286, 25);
            this.txtReservationSearch_value.TabIndex = 1;
            // 
            // btnReservationSearch_find
            // 
            this.btnReservationSearch_find.BackColor = System.Drawing.Color.Teal;
            this.btnReservationSearch_find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservationSearch_find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationSearch_find.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservationSearch_find.Location = new System.Drawing.Point(631, 93);
            this.btnReservationSearch_find.Name = "btnReservationSearch_find";
            this.btnReservationSearch_find.Size = new System.Drawing.Size(151, 32);
            this.btnReservationSearch_find.TabIndex = 6;
            this.btnReservationSearch_find.Text = "Rechercher";
            this.btnReservationSearch_find.UseVisualStyleBackColor = false;
            this.btnReservationSearch_find.Click += new System.EventHandler(this.btnClientSearch_find_Click);
            this.btnReservationSearch_find.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnReservationSearch_find.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Champ recherché";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trouver une réservation";
            // 
            // comboReservationSearch_FindBy
            // 
            this.comboReservationSearch_FindBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboReservationSearch_FindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReservationSearch_FindBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboReservationSearch_FindBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboReservationSearch_FindBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboReservationSearch_FindBy.FormattingEnabled = true;
            this.comboReservationSearch_FindBy.ItemHeight = 21;
            this.comboReservationSearch_FindBy.Location = new System.Drawing.Point(15, 95);
            this.comboReservationSearch_FindBy.Name = "comboReservationSearch_FindBy";
            this.comboReservationSearch_FindBy.Size = new System.Drawing.Size(254, 29);
            this.comboReservationSearch_FindBy.TabIndex = 1;
            this.comboReservationSearch_FindBy.SelectedIndexChanged += new System.EventHandler(this.comboReservationSearch_FindBy_SelectedIndexChanged);
            // 
            // btnReservationSearch_cancel
            // 
            this.btnReservationSearch_cancel.BackColor = System.Drawing.Color.White;
            this.btnReservationSearch_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationSearch_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationSearch_cancel.ForeColor = System.Drawing.Color.Teal;
            this.btnReservationSearch_cancel.Location = new System.Drawing.Point(15, 464);
            this.btnReservationSearch_cancel.Name = "btnReservationSearch_cancel";
            this.btnReservationSearch_cancel.Size = new System.Drawing.Size(214, 32);
            this.btnReservationSearch_cancel.TabIndex = 0;
            this.btnReservationSearch_cancel.Text = "Annuler";
            this.btnReservationSearch_cancel.UseVisualStyleBackColor = false;
            this.btnReservationSearch_cancel.Click += new System.EventHandler(this.btnClientSearch_cancel_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1000;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.NullValue = "-------------";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(17, 136);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 276);
            this.dataGridView1.TabIndex = 127;
            // 
            // ReservationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1147, 525);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_message.ResumeLayout(false);
            this.panel_message.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReservationSearch_cancel;
        private System.Windows.Forms.ComboBox comboReservationSearch_FindBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReservationSearch_find;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtReservationSearch_value;
        private System.Windows.Forms.Button btnReservationSearch_select;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}