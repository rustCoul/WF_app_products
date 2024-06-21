namespace WindowsFormsApp_Practice1
{
    partial class ManufacturersForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.input_country = new System.Windows.Forms.RichTextBox();
            this.Город = new System.Windows.Forms.Label();
            this.input_city = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_manufacturer_id = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EDIT_Manufacturers = new System.Windows.Forms.Button();
            this.btn_DELETE_Manufacturers = new System.Windows.Forms.Button();
            this.btn_ADD_Manufacturers = new System.Windows.Forms.Button();
            this.input_manufacturer_name = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_seach = new System.Windows.Forms.Button();
            this.input_Search = new System.Windows.Forms.RichTextBox();
            this.Search_comboBox = new System.Windows.Forms.ComboBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_country);
            this.groupBox1.Controls.Add(this.Город);
            this.groupBox1.Controls.Add(this.input_city);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.input_manufacturer_id);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_EDIT_Manufacturers);
            this.groupBox1.Controls.Add(this.btn_DELETE_Manufacturers);
            this.groupBox1.Controls.Add(this.btn_ADD_Manufacturers);
            this.groupBox1.Controls.Add(this.input_manufacturer_name);
            this.groupBox1.Location = new System.Drawing.Point(21, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 458);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // input_country
            // 
            this.input_country.Location = new System.Drawing.Point(18, 257);
            this.input_country.Name = "input_country";
            this.input_country.Size = new System.Drawing.Size(253, 31);
            this.input_country.TabIndex = 25;
            this.input_country.Text = "";
            // 
            // Город
            // 
            this.Город.AutoSize = true;
            this.Город.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Город.Location = new System.Drawing.Point(16, 291);
            this.Город.Name = "Город";
            this.Город.Size = new System.Drawing.Size(84, 31);
            this.Город.TabIndex = 24;
            this.Город.Text = "Город";
            // 
            // input_city
            // 
            this.input_city.Location = new System.Drawing.Point(22, 325);
            this.input_city.Name = "input_city";
            this.input_city.Size = new System.Drawing.Size(253, 29);
            this.input_city.TabIndex = 23;
            this.input_city.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Номер прозводителя";
            // 
            // input_manufacturer_id
            // 
            this.input_manufacturer_id.Location = new System.Drawing.Point(18, 74);
            this.input_manufacturer_id.Name = "input_manufacturer_id";
            this.input_manufacturer_id.Size = new System.Drawing.Size(253, 29);
            this.input_manufacturer_id.TabIndex = 20;
            this.input_manufacturer_id.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 414);
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
            this.label1.Location = new System.Drawing.Point(16, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Имя";
            // 
            // btn_EDIT_Manufacturers
            // 
            this.btn_EDIT_Manufacturers.Location = new System.Drawing.Point(193, 370);
            this.btn_EDIT_Manufacturers.Name = "btn_EDIT_Manufacturers";
            this.btn_EDIT_Manufacturers.Size = new System.Drawing.Size(86, 38);
            this.btn_EDIT_Manufacturers.TabIndex = 3;
            this.btn_EDIT_Manufacturers.Text = "Edit";
            this.btn_EDIT_Manufacturers.UseVisualStyleBackColor = true;
            this.btn_EDIT_Manufacturers.Click += new System.EventHandler(this.btn_EDIT_Manufacturers_Click);
            // 
            // btn_DELETE_Manufacturers
            // 
            this.btn_DELETE_Manufacturers.Location = new System.Drawing.Point(101, 370);
            this.btn_DELETE_Manufacturers.Name = "btn_DELETE_Manufacturers";
            this.btn_DELETE_Manufacturers.Size = new System.Drawing.Size(86, 38);
            this.btn_DELETE_Manufacturers.TabIndex = 3;
            this.btn_DELETE_Manufacturers.Text = "Delete";
            this.btn_DELETE_Manufacturers.UseVisualStyleBackColor = true;
            this.btn_DELETE_Manufacturers.Click += new System.EventHandler(this.btn_DELETE_Manufacturers_Click);
            // 
            // btn_ADD_Manufacturers
            // 
            this.btn_ADD_Manufacturers.Location = new System.Drawing.Point(9, 371);
            this.btn_ADD_Manufacturers.Name = "btn_ADD_Manufacturers";
            this.btn_ADD_Manufacturers.Size = new System.Drawing.Size(86, 38);
            this.btn_ADD_Manufacturers.TabIndex = 2;
            this.btn_ADD_Manufacturers.Text = "Add";
            this.btn_ADD_Manufacturers.UseVisualStyleBackColor = true;
            this.btn_ADD_Manufacturers.Click += new System.EventHandler(this.btn_ADD_Manufacturers_Click);
            // 
            // input_manufacturer_name
            // 
            this.input_manufacturer_name.Location = new System.Drawing.Point(18, 163);
            this.input_manufacturer_name.Name = "input_manufacturer_name";
            this.input_manufacturer_name.Size = new System.Drawing.Size(253, 31);
            this.input_manufacturer_name.TabIndex = 1;
            this.input_manufacturer_name.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(464, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 68);
            this.label3.TabIndex = 26;
            this.label3.Text = "Производители";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(975, 79);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(86, 38);
            this.btn_Reset.TabIndex = 105;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_seach
            // 
            this.btn_seach.Location = new System.Drawing.Point(883, 77);
            this.btn_seach.Name = "btn_seach";
            this.btn_seach.Size = new System.Drawing.Size(86, 38);
            this.btn_seach.TabIndex = 103;
            this.btn_seach.Text = "SEARCH";
            this.btn_seach.UseVisualStyleBackColor = true;
            this.btn_seach.Click += new System.EventHandler(this.btn_seach_Click);
            // 
            // input_Search
            // 
            this.input_Search.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_Search.Location = new System.Drawing.Point(610, 77);
            this.input_Search.Name = "input_Search";
            this.input_Search.Size = new System.Drawing.Size(267, 38);
            this.input_Search.TabIndex = 104;
            this.input_Search.Text = "";
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(358, 77);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(246, 38);
            this.Search_comboBox.TabIndex = 102;
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.Snow;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(369, 130);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(706, 341);
            this.GridView.TabIndex = 101;
            // 
            // ManufacturersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 519);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_seach);
            this.Controls.Add(this.input_Search);
            this.Controls.Add(this.Search_comboBox);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManufacturersForm";
            this.Text = "ManufacturersForm";
            this.Load += new System.EventHandler(this.ManufacturersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox input_country;
        private System.Windows.Forms.Label Город;
        private System.Windows.Forms.RichTextBox input_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox input_manufacturer_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EDIT_Manufacturers;
        private System.Windows.Forms.Button btn_DELETE_Manufacturers;
        private System.Windows.Forms.Button btn_ADD_Manufacturers;
        private System.Windows.Forms.RichTextBox input_manufacturer_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_seach;
        private System.Windows.Forms.RichTextBox input_Search;
        private System.Windows.Forms.ComboBox Search_comboBox;
        private System.Windows.Forms.DataGridView GridView;
    }
}