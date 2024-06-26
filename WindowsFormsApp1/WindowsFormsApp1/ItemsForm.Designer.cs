namespace WindowsFormsApp1
{
    partial class ItemsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ProductId_tb_product = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_Delete_Products = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Items_dbtb_Time_Input = new System.Windows.Forms.RichTextBox();
            this.Items_dbtb_Price_Input = new System.Windows.Forms.RichTextBox();
            this.Items_dbtb_Name_Input = new System.Windows.Forms.RichTextBox();
            this.Items_dbtb_idNumberInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_seach = new System.Windows.Forms.Button();
            this.input_Search = new System.Windows.Forms.RichTextBox();
            this.Search_comboBox = new System.Windows.Forms.ComboBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(676, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 68);
            this.label2.TabIndex = 9;
            this.label2.Text = "Товары";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ProductId_tb_product);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_home);
            this.groupBox1.Controls.Add(this.btn_Delete_Products);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Items_dbtb_Time_Input);
            this.groupBox1.Controls.Add(this.Items_dbtb_Price_Input);
            this.groupBox1.Controls.Add(this.Items_dbtb_Name_Input);
            this.groupBox1.Controls.Add(this.Items_dbtb_idNumberInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_ADD);
            this.groupBox1.Location = new System.Drawing.Point(53, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 488);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_ProductId_tb_product
            // 
            this.btn_ProductId_tb_product.Location = new System.Drawing.Point(20, 87);
            this.btn_ProductId_tb_product.Name = "btn_ProductId_tb_product";
            this.btn_ProductId_tb_product.Size = new System.Drawing.Size(264, 24);
            this.btn_ProductId_tb_product.TabIndex = 17;
            this.btn_ProductId_tb_product.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "Номер товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Срок_гарантии";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 16F);
            this.label5.Location = new System.Drawing.Point(18, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Номер производителя";
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(103, 444);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(115, 38);
            this.btn_home.TabIndex = 9;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_Delete_Products
            // 
            this.btn_Delete_Products.Location = new System.Drawing.Point(211, 400);
            this.btn_Delete_Products.Name = "btn_Delete_Products";
            this.btn_Delete_Products.Size = new System.Drawing.Size(87, 38);
            this.btn_Delete_Products.TabIndex = 8;
            this.btn_Delete_Products.Text = "Edit";
            this.btn_Delete_Products.UseVisualStyleBackColor = true;
            this.btn_Delete_Products.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Items_dbtb_Time_Input
            // 
            this.Items_dbtb_Time_Input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Items_dbtb_Time_Input.Location = new System.Drawing.Point(23, 360);
            this.Items_dbtb_Time_Input.Name = "Items_dbtb_Time_Input";
            this.Items_dbtb_Time_Input.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Items_dbtb_Time_Input.Size = new System.Drawing.Size(264, 24);
            this.Items_dbtb_Time_Input.TabIndex = 6;
            this.Items_dbtb_Time_Input.Text = "";
            this.Items_dbtb_Time_Input.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // Items_dbtb_Price_Input
            // 
            this.Items_dbtb_Price_Input.Location = new System.Drawing.Point(23, 299);
            this.Items_dbtb_Price_Input.Name = "Items_dbtb_Price_Input";
            this.Items_dbtb_Price_Input.Size = new System.Drawing.Size(264, 24);
            this.Items_dbtb_Price_Input.TabIndex = 5;
            this.Items_dbtb_Price_Input.Text = "";
            // 
            // Items_dbtb_Name_Input
            // 
            this.Items_dbtb_Name_Input.Location = new System.Drawing.Point(20, 230);
            this.Items_dbtb_Name_Input.Name = "Items_dbtb_Name_Input";
            this.Items_dbtb_Name_Input.Size = new System.Drawing.Size(264, 24);
            this.Items_dbtb_Name_Input.TabIndex = 4;
            this.Items_dbtb_Name_Input.Text = "";
            // 
            // Items_dbtb_idNumberInput
            // 
            this.Items_dbtb_idNumberInput.Location = new System.Drawing.Point(20, 160);
            this.Items_dbtb_idNumberInput.Name = "Items_dbtb_idNumberInput";
            this.Items_dbtb_idNumberInput.Size = new System.Drawing.Size(264, 24);
            this.Items_dbtb_idNumberInput.TabIndex = 3;
            this.Items_dbtb_idNumberInput.Text = "";
            this.Items_dbtb_idNumberInput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert";
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(20, 400);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(86, 38);
            this.btn_ADD.TabIndex = 0;
            this.btn_ADD.Text = "Add";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(1068, 93);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(86, 38);
            this.btn_Reset.TabIndex = 100;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_seach
            // 
            this.btn_seach.Location = new System.Drawing.Point(976, 91);
            this.btn_seach.Name = "btn_seach";
            this.btn_seach.Size = new System.Drawing.Size(86, 38);
            this.btn_seach.TabIndex = 98;
            this.btn_seach.Text = "SEARCH";
            this.btn_seach.UseVisualStyleBackColor = true;
            this.btn_seach.Click += new System.EventHandler(this.btn_seach_Click);
            // 
            // input_Search
            // 
            this.input_Search.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_Search.Location = new System.Drawing.Point(703, 91);
            this.input_Search.Name = "input_Search";
            this.input_Search.Size = new System.Drawing.Size(267, 38);
            this.input_Search.TabIndex = 99;
            this.input_Search.Text = "";
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(436, 91);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(246, 38);
            this.Search_comboBox.TabIndex = 97;
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.Snow;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(448, 153);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(706, 341);
            this.GridView.TabIndex = 96;
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 547);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_seach);
            this.Controls.Add(this.input_Search);
            this.Controls.Add(this.Search_comboBox);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_Delete_Products;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Items_dbtb_Time_Input;
        private System.Windows.Forms.RichTextBox Items_dbtb_Price_Input;
        private System.Windows.Forms.RichTextBox Items_dbtb_Name_Input;
        private System.Windows.Forms.RichTextBox Items_dbtb_idNumberInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox btn_ProductId_tb_product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_seach;
        private System.Windows.Forms.RichTextBox input_Search;
        private System.Windows.Forms.ComboBox Search_comboBox;
        private System.Windows.Forms.DataGridView GridView;
    }
}