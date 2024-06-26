namespace WindowsFormsApp1
{
    partial class SellersForm
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
            this.input_last_name = new System.Windows.Forms.RichTextBox();
            this.Город = new System.Windows.Forms.Label();
            this.input_middle_name = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_seller_id = new System.Windows.Forms.RichTextBox();
            this.Home_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EDIT_Sellers = new System.Windows.Forms.Button();
            this.btn_DELETE_Sellers = new System.Windows.Forms.Button();
            this.btn_ADD_Sellers = new System.Windows.Forms.Button();
            this.input_first_name = new System.Windows.Forms.RichTextBox();
            this.SellersGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.input_username = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_password = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.input_birth_date = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.input_hire_date = new System.Windows.Forms.RichTextBox();
            this.Sellers_comboBox = new System.Windows.Forms.ComboBox();
            this.input_Sellers_Search = new System.Windows.Forms.RichTextBox();
            this.btn_Seller_seach = new System.Windows.Forms.Button();
            this.btn_Reset_Sellers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_username);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.input_password);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.input_birth_date);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.input_hire_date);
            this.groupBox1.Controls.Add(this.input_last_name);
            this.groupBox1.Controls.Add(this.Город);
            this.groupBox1.Controls.Add(this.input_middle_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.input_seller_id);
            this.groupBox1.Controls.Add(this.Home_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_EDIT_Sellers);
            this.groupBox1.Controls.Add(this.btn_DELETE_Sellers);
            this.groupBox1.Controls.Add(this.btn_ADD_Sellers);
            this.groupBox1.Controls.Add(this.input_first_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 656);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // input_last_name
            // 
            this.input_last_name.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_last_name.Location = new System.Drawing.Point(14, 186);
            this.input_last_name.Name = "input_last_name";
            this.input_last_name.Size = new System.Drawing.Size(253, 31);
            this.input_last_name.TabIndex = 25;
            this.input_last_name.Text = "";
            // 
            // Город
            // 
            this.Город.AutoSize = true;
            this.Город.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Город.Location = new System.Drawing.Point(12, 220);
            this.Город.Name = "Город";
            this.Город.Size = new System.Drawing.Size(134, 31);
            this.Город.TabIndex = 24;
            this.Город.Text = "Отечество";
            // 
            // input_middle_name
            // 
            this.input_middle_name.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_middle_name.Location = new System.Drawing.Point(10, 255);
            this.input_middle_name.Name = "input_middle_name";
            this.input_middle_name.Size = new System.Drawing.Size(253, 29);
            this.input_middle_name.TabIndex = 23;
            this.input_middle_name.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Номер Продавцы";
            // 
            // input_seller_id
            // 
            this.input_seller_id.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_seller_id.Location = new System.Drawing.Point(14, 52);
            this.input_seller_id.Name = "input_seller_id";
            this.input_seller_id.Size = new System.Drawing.Size(265, 29);
            this.input_seller_id.TabIndex = 20;
            this.input_seller_id.Text = "";
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(115, 612);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(86, 38);
            this.Home_btn.TabIndex = 19;
            this.Home_btn.Text = "HOME";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Имя";
            // 
            // btn_EDIT_Sellers
            // 
            this.btn_EDIT_Sellers.Location = new System.Drawing.Point(225, 568);
            this.btn_EDIT_Sellers.Name = "btn_EDIT_Sellers";
            this.btn_EDIT_Sellers.Size = new System.Drawing.Size(86, 38);
            this.btn_EDIT_Sellers.TabIndex = 3;
            this.btn_EDIT_Sellers.Text = "Edit";
            this.btn_EDIT_Sellers.UseVisualStyleBackColor = true;
            this.btn_EDIT_Sellers.Click += new System.EventHandler(this.btn_EDIT_Sellers_Click);
            // 
            // btn_DELETE_Sellers
            // 
            this.btn_DELETE_Sellers.Location = new System.Drawing.Point(115, 568);
            this.btn_DELETE_Sellers.Name = "btn_DELETE_Sellers";
            this.btn_DELETE_Sellers.Size = new System.Drawing.Size(86, 38);
            this.btn_DELETE_Sellers.TabIndex = 3;
            this.btn_DELETE_Sellers.Text = "Delete";
            this.btn_DELETE_Sellers.UseVisualStyleBackColor = true;
            this.btn_DELETE_Sellers.Click += new System.EventHandler(this.btn_DELETE_Sellers_Click);
            // 
            // btn_ADD_Sellers
            // 
            this.btn_ADD_Sellers.Location = new System.Drawing.Point(10, 568);
            this.btn_ADD_Sellers.Name = "btn_ADD_Sellers";
            this.btn_ADD_Sellers.Size = new System.Drawing.Size(86, 38);
            this.btn_ADD_Sellers.TabIndex = 2;
            this.btn_ADD_Sellers.Text = "Add";
            this.btn_ADD_Sellers.UseVisualStyleBackColor = true;
            this.btn_ADD_Sellers.Click += new System.EventHandler(this.btn_ADD_Sellers_Click);
            // 
            // input_first_name
            // 
            this.input_first_name.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_first_name.Location = new System.Drawing.Point(14, 118);
            this.input_first_name.Name = "input_first_name";
            this.input_first_name.Size = new System.Drawing.Size(253, 31);
            this.input_first_name.TabIndex = 1;
            this.input_first_name.Text = "";
            // 
            // SellersGridView
            // 
            this.SellersGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.SellersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellersGridView.Location = new System.Drawing.Point(355, 137);
            this.SellersGridView.Name = "SellersGridView";
            this.SellersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SellersGridView.RowTemplate.Height = 24;
            this.SellersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellersGridView.Size = new System.Drawing.Size(1031, 461);
            this.SellersGridView.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(648, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 68);
            this.label3.TabIndex = 27;
            this.label3.Text = "Продавцы";
            // 
            // input_username
            // 
            this.input_username.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_username.Location = new System.Drawing.Point(12, 447);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(253, 31);
            this.input_username.TabIndex = 33;
            this.input_username.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "Пароль";
            // 
            // input_password
            // 
            this.input_password.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_password.Location = new System.Drawing.Point(12, 515);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(253, 29);
            this.input_password.TabIndex = 31;
            this.input_password.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "Имя логина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 31);
            this.label7.TabIndex = 29;
            this.label7.Text = "День рождения";
            // 
            // input_birth_date
            // 
            this.input_birth_date.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_birth_date.Location = new System.Drawing.Point(12, 313);
            this.input_birth_date.Name = "input_birth_date";
            this.input_birth_date.Size = new System.Drawing.Size(253, 29);
            this.input_birth_date.TabIndex = 28;
            this.input_birth_date.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 31);
            this.label8.TabIndex = 27;
            this.label8.Text = "Дата приема";
            // 
            // input_hire_date
            // 
            this.input_hire_date.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_hire_date.Location = new System.Drawing.Point(12, 379);
            this.input_hire_date.Name = "input_hire_date";
            this.input_hire_date.Size = new System.Drawing.Size(253, 31);
            this.input_hire_date.TabIndex = 26;
            this.input_hire_date.Text = "";
            // 
            // Sellers_comboBox
            // 
            this.Sellers_comboBox.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sellers_comboBox.FormattingEnabled = true;
            this.Sellers_comboBox.Location = new System.Drawing.Point(371, 87);
            this.Sellers_comboBox.Name = "Sellers_comboBox";
            this.Sellers_comboBox.Size = new System.Drawing.Size(246, 38);
            this.Sellers_comboBox.TabIndex = 28;
            // 
            // input_Sellers_Search
            // 
            this.input_Sellers_Search.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_Sellers_Search.Location = new System.Drawing.Point(646, 87);
            this.input_Sellers_Search.Name = "input_Sellers_Search";
            this.input_Sellers_Search.Size = new System.Drawing.Size(267, 38);
            this.input_Sellers_Search.TabIndex = 34;
            this.input_Sellers_Search.Text = "";
            // 
            // btn_Seller_seach
            // 
            this.btn_Seller_seach.Location = new System.Drawing.Point(936, 87);
            this.btn_Seller_seach.Name = "btn_Seller_seach";
            this.btn_Seller_seach.Size = new System.Drawing.Size(86, 38);
            this.btn_Seller_seach.TabIndex = 34;
            this.btn_Seller_seach.Text = "SEARCH";
            this.btn_Seller_seach.UseVisualStyleBackColor = true;
            this.btn_Seller_seach.Click += new System.EventHandler(this.btn_Seller_seach_Click);
            // 
            // btn_Reset_Sellers
            // 
            this.btn_Reset_Sellers.Location = new System.Drawing.Point(1028, 89);
            this.btn_Reset_Sellers.Name = "btn_Reset_Sellers";
            this.btn_Reset_Sellers.Size = new System.Drawing.Size(86, 38);
            this.btn_Reset_Sellers.TabIndex = 35;
            this.btn_Reset_Sellers.Text = "Reset";
            this.btn_Reset_Sellers.UseVisualStyleBackColor = true;
            this.btn_Reset_Sellers.Click += new System.EventHandler(this.btn_Reset_Sellers_Click);
            // 
            // SellersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 671);
            this.Controls.Add(this.btn_Reset_Sellers);
            this.Controls.Add(this.btn_Seller_seach);
            this.Controls.Add(this.input_Sellers_Search);
            this.Controls.Add(this.Sellers_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SellersGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "SellersForm";
            this.Text = "SellersForm";
            this.Load += new System.EventHandler(this.SellersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox input_last_name;
        private System.Windows.Forms.Label Город;
        private System.Windows.Forms.RichTextBox input_middle_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox input_seller_id;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EDIT_Sellers;
        private System.Windows.Forms.Button btn_DELETE_Sellers;
        private System.Windows.Forms.Button btn_ADD_Sellers;
        private System.Windows.Forms.RichTextBox input_first_name;
        private System.Windows.Forms.DataGridView SellersGridView;
        private System.Windows.Forms.RichTextBox input_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox input_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox input_birth_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox input_hire_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Sellers_comboBox;
        private System.Windows.Forms.RichTextBox input_Sellers_Search;
        private System.Windows.Forms.Button btn_Seller_seach;
        private System.Windows.Forms.Button btn_Reset_Sellers;
    }
}