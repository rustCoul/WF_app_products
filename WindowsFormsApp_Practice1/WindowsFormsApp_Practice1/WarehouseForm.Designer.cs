namespace WindowsFormsApp_Practice1
{
    partial class WarehouseForm
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
            this.input_WarehouseID = new System.Windows.Forms.RichTextBox();
            this.input_WarehouseAdress = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_EDIT_Warehouse = new System.Windows.Forms.Button();
            this.btn_DELETE_Warehouse = new System.Windows.Forms.Button();
            this.btn_ADD_Warehouse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_seach = new System.Windows.Forms.Button();
            this.input_Search = new System.Windows.Forms.RichTextBox();
            this.Search_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // input_WarehouseID
            // 
            this.input_WarehouseID.Location = new System.Drawing.Point(18, 71);
            this.input_WarehouseID.Name = "input_WarehouseID";
            this.input_WarehouseID.Size = new System.Drawing.Size(253, 29);
            this.input_WarehouseID.TabIndex = 0;
            this.input_WarehouseID.Text = "";
            // 
            // input_WarehouseAdress
            // 
            this.input_WarehouseAdress.Location = new System.Drawing.Point(18, 155);
            this.input_WarehouseAdress.Name = "input_WarehouseAdress";
            this.input_WarehouseAdress.Size = new System.Drawing.Size(253, 31);
            this.input_WarehouseAdress.TabIndex = 1;
            this.input_WarehouseAdress.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_EDIT_Warehouse);
            this.groupBox1.Controls.Add(this.btn_DELETE_Warehouse);
            this.groupBox1.Controls.Add(this.btn_ADD_Warehouse);
            this.groupBox1.Controls.Add(this.input_WarehouseAdress);
            this.groupBox1.Controls.Add(this.input_WarehouseID);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 386);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Адрес склада";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Номер склада";
            // 
            // btn_EDIT_Warehouse
            // 
            this.btn_EDIT_Warehouse.Location = new System.Drawing.Point(202, 214);
            this.btn_EDIT_Warehouse.Name = "btn_EDIT_Warehouse";
            this.btn_EDIT_Warehouse.Size = new System.Drawing.Size(86, 38);
            this.btn_EDIT_Warehouse.TabIndex = 3;
            this.btn_EDIT_Warehouse.Text = "Edit";
            this.btn_EDIT_Warehouse.UseVisualStyleBackColor = true;
            this.btn_EDIT_Warehouse.Click += new System.EventHandler(this.btn_EDIT_Warehouse_Click);
            // 
            // btn_DELETE_Warehouse
            // 
            this.btn_DELETE_Warehouse.Location = new System.Drawing.Point(110, 214);
            this.btn_DELETE_Warehouse.Name = "btn_DELETE_Warehouse";
            this.btn_DELETE_Warehouse.Size = new System.Drawing.Size(86, 38);
            this.btn_DELETE_Warehouse.TabIndex = 3;
            this.btn_DELETE_Warehouse.Text = "Delete";
            this.btn_DELETE_Warehouse.UseVisualStyleBackColor = true;
            this.btn_DELETE_Warehouse.Click += new System.EventHandler(this.btn_DELETE_Warehouse_Click);
            // 
            // btn_ADD_Warehouse
            // 
            this.btn_ADD_Warehouse.Location = new System.Drawing.Point(18, 214);
            this.btn_ADD_Warehouse.Name = "btn_ADD_Warehouse";
            this.btn_ADD_Warehouse.Size = new System.Drawing.Size(86, 38);
            this.btn_ADD_Warehouse.TabIndex = 2;
            this.btn_ADD_Warehouse.Text = "Add";
            this.btn_ADD_Warehouse.UseVisualStyleBackColor = true;
            this.btn_ADD_Warehouse.Click += new System.EventHandler(this.btn_ADD_Warehouse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(468, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 68);
            this.label3.TabIndex = 20;
            this.label3.Text = "Склад";
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.Snow;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(327, 140);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(548, 301);
            this.GridView.TabIndex = 21;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarehouseGridView_CellContentClick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(871, 86);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(86, 38);
            this.btn_Reset.TabIndex = 109;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_seach
            // 
            this.btn_seach.Location = new System.Drawing.Point(779, 86);
            this.btn_seach.Name = "btn_seach";
            this.btn_seach.Size = new System.Drawing.Size(86, 38);
            this.btn_seach.TabIndex = 107;
            this.btn_seach.Text = "SEARCH";
            this.btn_seach.UseVisualStyleBackColor = true;
            this.btn_seach.Click += new System.EventHandler(this.btn_seach_Click);
            // 
            // input_Search
            // 
            this.input_Search.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_Search.Location = new System.Drawing.Point(566, 86);
            this.input_Search.Name = "input_Search";
            this.input_Search.Size = new System.Drawing.Size(207, 38);
            this.input_Search.TabIndex = 108;
            this.input_Search.Text = "";
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(314, 86);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(246, 38);
            this.Search_comboBox.TabIndex = 106;
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 466);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.btn_seach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_Search);
            this.Controls.Add(this.Search_comboBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_WarehouseID;
        private System.Windows.Forms.RichTextBox input_WarehouseAdress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_EDIT_Warehouse;
        private System.Windows.Forms.Button btn_DELETE_Warehouse;
        private System.Windows.Forms.Button btn_ADD_Warehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_seach;
        private System.Windows.Forms.RichTextBox input_Search;
        private System.Windows.Forms.ComboBox Search_comboBox;
    }
}