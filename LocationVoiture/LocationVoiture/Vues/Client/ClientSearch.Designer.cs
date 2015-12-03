using System.Windows.Forms;

namespace LocationVoiture.Vues
{
    partial class ClientSearch
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
            this.btnClientSearch_select = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtClientSearch_value = new System.Windows.Forms.TextBox();
            this.btnClientSearch_find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboClientSearch_FindBy = new System.Windows.Forms.ComboBox();
            this.btnClientSearch_cancel = new System.Windows.Forms.Button();
            this.panel_message = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_message.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_message);
            this.panel1.Controls.Add(this.btnClientSearch_select);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.btnClientSearch_find);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboClientSearch_FindBy);
            this.panel1.Controls.Add(this.btnClientSearch_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 525);
            this.panel1.TabIndex = 0;
            // 
            // btnClientSearch_select
            // 
            this.btnClientSearch_select.BackColor = System.Drawing.Color.Teal;
            this.btnClientSearch_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientSearch_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSearch_select.ForeColor = System.Drawing.Color.Black;
            this.btnClientSearch_select.Location = new System.Drawing.Point(15, 422);
            this.btnClientSearch_select.Name = "btnClientSearch_select";
            this.btnClientSearch_select.Size = new System.Drawing.Size(214, 32);
            this.btnClientSearch_select.TabIndex = 16;
            this.btnClientSearch_select.Text = "Selectionner";
            this.btnClientSearch_select.UseVisualStyleBackColor = false;
            this.btnClientSearch_select.Click += new System.EventHandler(this.btnClientSearch_select_Click);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtClientSearch_value);
            this.panel11.Location = new System.Drawing.Point(296, 93);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel11.Size = new System.Drawing.Size(314, 32);
            this.panel11.TabIndex = 15;
            // 
            // txtClientSearch_value
            // 
            this.txtClientSearch_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClientSearch_value.BackColor = System.Drawing.Color.Black;
            this.txtClientSearch_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientSearch_value.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientSearch_value.ForeColor = System.Drawing.Color.Silver;
            this.txtClientSearch_value.Location = new System.Drawing.Point(13, 3);
            this.txtClientSearch_value.Name = "txtClientSearch_value";
            this.txtClientSearch_value.Size = new System.Drawing.Size(286, 25);
            this.txtClientSearch_value.TabIndex = 1;
            // 
            // btnClientSearch_find
            // 
            this.btnClientSearch_find.BackColor = System.Drawing.Color.Teal;
            this.btnClientSearch_find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientSearch_find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSearch_find.ForeColor = System.Drawing.Color.Black;
            this.btnClientSearch_find.Location = new System.Drawing.Point(631, 93);
            this.btnClientSearch_find.Name = "btnClientSearch_find";
            this.btnClientSearch_find.Size = new System.Drawing.Size(151, 32);
            this.btnClientSearch_find.TabIndex = 6;
            this.btnClientSearch_find.Text = "Rechercher";
            this.btnClientSearch_find.UseVisualStyleBackColor = false;
            this.btnClientSearch_find.Click += new System.EventHandler(this.btnClientSearch_find_Click);
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
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trouver un client";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.NullValue = "-------------";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(18, 136);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 276);
            this.dataGridView1.TabIndex = 3;
            // 
            // comboClientSearch_FindBy
            // 
            this.comboClientSearch_FindBy.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboClientSearch_FindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientSearch_FindBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboClientSearch_FindBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClientSearch_FindBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboClientSearch_FindBy.FormattingEnabled = true;
            this.comboClientSearch_FindBy.ItemHeight = 21;
            this.comboClientSearch_FindBy.Location = new System.Drawing.Point(15, 95);
            this.comboClientSearch_FindBy.Name = "comboClientSearch_FindBy";
            this.comboClientSearch_FindBy.Size = new System.Drawing.Size(254, 29);
            this.comboClientSearch_FindBy.TabIndex = 1;
            // 
            // btnClientSearch_cancel
            // 
            this.btnClientSearch_cancel.BackColor = System.Drawing.Color.Black;
            this.btnClientSearch_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientSearch_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSearch_cancel.ForeColor = System.Drawing.Color.Teal;
            this.btnClientSearch_cancel.Location = new System.Drawing.Point(15, 464);
            this.btnClientSearch_cancel.Name = "btnClientSearch_cancel";
            this.btnClientSearch_cancel.Size = new System.Drawing.Size(214, 32);
            this.btnClientSearch_cancel.TabIndex = 0;
            this.btnClientSearch_cancel.Text = "Annuler";
            this.btnClientSearch_cancel.UseVisualStyleBackColor = false;
            this.btnClientSearch_cancel.Click += new System.EventHandler(this.btnClientSearch_cancel_Click);
            // 
            // panel_message
            // 
            this.panel_message.BackColor = System.Drawing.Color.Teal;
            this.panel_message.Controls.Add(this.label3);
            this.panel_message.Location = new System.Drawing.Point(296, 59);
            this.panel_message.Name = "panel_message";
            this.panel_message.Size = new System.Drawing.Size(314, 28);
            this.panel_message.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(90, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Aucun client trouvé";
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1000;
            // 
            // ClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1147, 525);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_message.ResumeLayout(false);
            this.panel_message.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClientSearch_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboClientSearch_FindBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClientSearch_find;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtClientSearch_value;
        private System.Windows.Forms.Button btnClientSearch_select;
        private Panel panel_message;
        private Label label3;
        private Timer animationTimer;
    }
}