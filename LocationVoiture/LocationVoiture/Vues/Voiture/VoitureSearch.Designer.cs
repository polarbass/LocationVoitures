using System.Windows.Forms;

namespace LocationVoiture.Vues
{
    partial class VoitureSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblLoading = new System.Windows.Forms.Label();
            this.panel_message = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVehiculeSearch_select = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbVehiculeSearch = new System.Windows.Forms.ComboBox();
            this.txtVehiculeSearch_value = new System.Windows.Forms.TextBox();
            this.btnVehiculeSearch_find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboVehiculeSearch_FindBy = new System.Windows.Forms.ComboBox();
            this.btnVehiculeSearch_cancel = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_message.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblLoading);
            this.panel1.Controls.Add(this.panel_message);
            this.panel1.Controls.Add(this.btnVehiculeSearch_select);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.btnVehiculeSearch_find);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboVehiculeSearch_FindBy);
            this.panel1.Controls.Add(this.btnVehiculeSearch_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 525);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.NullValue = "-------------";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(17, 136);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 276);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Teal;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(632, 70);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(135, 17);
            this.lblLoading.TabIndex = 9;
            this.lblLoading.Text = "Recherche en cours ...";
            // 
            // panel_message
            // 
            this.panel_message.BackColor = System.Drawing.Color.Teal;
            this.panel_message.Controls.Add(this.label3);
            this.panel_message.Location = new System.Drawing.Point(296, 59);
            this.panel_message.Name = "panel_message";
            this.panel_message.Size = new System.Drawing.Size(314, 28);
            this.panel_message.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(77, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aucun véhicule trouvé";
            // 
            // btnVehiculeSearch_select
            // 
            this.btnVehiculeSearch_select.BackColor = System.Drawing.Color.Teal;
            this.btnVehiculeSearch_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculeSearch_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculeSearch_select.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVehiculeSearch_select.Location = new System.Drawing.Point(15, 422);
            this.btnVehiculeSearch_select.Name = "btnVehiculeSearch_select";
            this.btnVehiculeSearch_select.Size = new System.Drawing.Size(214, 32);
            this.btnVehiculeSearch_select.TabIndex = 3;
            this.btnVehiculeSearch_select.Text = "Selectionner";
            this.btnVehiculeSearch_select.UseVisualStyleBackColor = false;
            this.btnVehiculeSearch_select.Click += new System.EventHandler(this.btnVehiculeSearch_select_Click);
            this.btnVehiculeSearch_select.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnVehiculeSearch_select.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.cbVehiculeSearch);
            this.panel11.Controls.Add(this.txtVehiculeSearch_value);
            this.panel11.Location = new System.Drawing.Point(296, 93);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel11.Size = new System.Drawing.Size(314, 32);
            this.panel11.TabIndex = 1;
            // 
            // cbVehiculeSearch
            // 
            this.cbVehiculeSearch.BackColor = System.Drawing.Color.White;
            this.cbVehiculeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbVehiculeSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehiculeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbVehiculeSearch.FormattingEnabled = true;
            this.cbVehiculeSearch.Location = new System.Drawing.Point(0, 0);
            this.cbVehiculeSearch.Name = "cbVehiculeSearch";
            this.cbVehiculeSearch.Size = new System.Drawing.Size(314, 29);
            this.cbVehiculeSearch.TabIndex = 0;
            // 
            // txtVehiculeSearch_value
            // 
            this.txtVehiculeSearch_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtVehiculeSearch_value.BackColor = System.Drawing.Color.White;
            this.txtVehiculeSearch_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVehiculeSearch_value.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculeSearch_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVehiculeSearch_value.Location = new System.Drawing.Point(13, 3);
            this.txtVehiculeSearch_value.Name = "txtVehiculeSearch_value";
            this.txtVehiculeSearch_value.Size = new System.Drawing.Size(286, 25);
            this.txtVehiculeSearch_value.TabIndex = 1;
            // 
            // btnVehiculeSearch_find
            // 
            this.btnVehiculeSearch_find.BackColor = System.Drawing.Color.Teal;
            this.btnVehiculeSearch_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculeSearch_find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculeSearch_find.ForeColor = System.Drawing.Color.White;
            this.btnVehiculeSearch_find.Location = new System.Drawing.Point(631, 93);
            this.btnVehiculeSearch_find.Name = "btnVehiculeSearch_find";
            this.btnVehiculeSearch_find.Size = new System.Drawing.Size(151, 32);
            this.btnVehiculeSearch_find.TabIndex = 2;
            this.btnVehiculeSearch_find.Text = "Rechercher";
            this.btnVehiculeSearch_find.UseVisualStyleBackColor = false;
            this.btnVehiculeSearch_find.Click += new System.EventHandler(this.btnEmployeSearch_find_Click);
            this.btnVehiculeSearch_find.MouseEnter += new System.EventHandler(this.mouseEnterEventHandler);
            this.btnVehiculeSearch_find.MouseLeave += new System.EventHandler(this.mouseLeaveEventHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Champ recherché";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trouver un véhicule";
            // 
            // comboVehiculeSearch_FindBy
            // 
            this.comboVehiculeSearch_FindBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboVehiculeSearch_FindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehiculeSearch_FindBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehiculeSearch_FindBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVehiculeSearch_FindBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboVehiculeSearch_FindBy.FormattingEnabled = true;
            this.comboVehiculeSearch_FindBy.ItemHeight = 21;
            this.comboVehiculeSearch_FindBy.Location = new System.Drawing.Point(15, 95);
            this.comboVehiculeSearch_FindBy.Name = "comboVehiculeSearch_FindBy";
            this.comboVehiculeSearch_FindBy.Size = new System.Drawing.Size(254, 29);
            this.comboVehiculeSearch_FindBy.TabIndex = 0;
            this.comboVehiculeSearch_FindBy.SelectedIndexChanged += new System.EventHandler(this.comboVehiculeSearch_FindBy_SelectedIndexChanged);
            // 
            // btnVehiculeSearch_cancel
            // 
            this.btnVehiculeSearch_cancel.BackColor = System.Drawing.Color.White;
            this.btnVehiculeSearch_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculeSearch_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculeSearch_cancel.ForeColor = System.Drawing.Color.Teal;
            this.btnVehiculeSearch_cancel.Location = new System.Drawing.Point(15, 464);
            this.btnVehiculeSearch_cancel.Name = "btnVehiculeSearch_cancel";
            this.btnVehiculeSearch_cancel.Size = new System.Drawing.Size(214, 32);
            this.btnVehiculeSearch_cancel.TabIndex = 4;
            this.btnVehiculeSearch_cancel.Text = "Annuler";
            this.btnVehiculeSearch_cancel.UseVisualStyleBackColor = false;
            this.btnVehiculeSearch_cancel.Click += new System.EventHandler(this.btnVehiculeSearch_cancel_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1000;
            // 
            // VoitureSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1147, 525);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoitureSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_message.ResumeLayout(false);
            this.panel_message.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVehiculeSearch_cancel;
        private System.Windows.Forms.ComboBox comboVehiculeSearch_FindBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVehiculeSearch_find;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtVehiculeSearch_value;
        private System.Windows.Forms.Button btnVehiculeSearch_select;
        private Panel panel_message;
        private Label label3;
        private Timer animationTimer;
        private ComboBox cbVehiculeSearch;
        private Label lblLoading;
        private DataGridView dataGridView1;
    }
}