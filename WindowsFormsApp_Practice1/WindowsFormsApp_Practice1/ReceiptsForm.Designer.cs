namespace WindowsFormsApp_Practice1
{
    partial class ReceiptsForm
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
            this.input_discount_card_id = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_sale_date = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_receipt_id = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EDIT_Receipts = new System.Windows.Forms.Button();
            this.btn_DELETE_Receipts = new System.Windows.Forms.Button();
            this.btn_ADD_Receipts = new System.Windows.Forms.Button();
            this.input_seller_id = new System.Windows.Forms.RichTextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_seach = new System.Windows.Forms.Button();
            this.input_Search = new System.Windows.Forms.RichTextBox();
            this.Search_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_discount_card_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.input_sale_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.input_receipt_id);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_EDIT_Receipts);
            this.groupBox1.Controls.Add(this.btn_DELETE_Receipts);
            this.groupBox1.Controls.Add(this.btn_ADD_Receipts);
            this.groupBox1.Controls.Add(this.input_seller_id);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 458);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // input_discount_card_id
            // 
            this.input_discount_card_id.Location = new System.Drawing.Point(18, 257);
            this.input_discount_card_id.Name = "input_discount_card_id";
            this.input_discount_card_id.Size = new System.Drawing.Size(253, 31);
            this.input_discount_card_id.TabIndex = 25;
            this.input_discount_card_id.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "Дата продажи";
            // 
            // input_sale_date
            // 
            this.input_sale_date.Location = new System.Drawing.Point(22, 325);
            this.input_sale_date.Name = "input_sale_date";
            this.input_sale_date.Size = new System.Drawing.Size(253, 29);
            this.input_sale_date.TabIndex = 23;
            this.input_sale_date.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Номер дисконтной карты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Номер чека";
            // 
            // input_receipt_id
            // 
            this.input_receipt_id.Location = new System.Drawing.Point(18, 74);
            this.input_receipt_id.Name = "input_receipt_id";
            this.input_receipt_id.Size = new System.Drawing.Size(253, 29);
            this.input_receipt_id.TabIndex = 20;
            this.input_receipt_id.Text = "";
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
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Номер продавца";
            // 
            // btn_EDIT_Receipts
            // 
            this.btn_EDIT_Receipts.Location = new System.Drawing.Point(193, 370);
            this.btn_EDIT_Receipts.Name = "btn_EDIT_Receipts";
            this.btn_EDIT_Receipts.Size = new System.Drawing.Size(86, 38);
            this.btn_EDIT_Receipts.TabIndex = 3;
            this.btn_EDIT_Receipts.Text = "Edit";
            this.btn_EDIT_Receipts.UseVisualStyleBackColor = true;
            this.btn_EDIT_Receipts.Click += new System.EventHandler(this.btn_EDIT_Receipts_Click);
            // 
            // btn_DELETE_Receipts
            // 
            this.btn_DELETE_Receipts.Location = new System.Drawing.Point(101, 370);
            this.btn_DELETE_Receipts.Name = "btn_DELETE_Receipts";
            this.btn_DELETE_Receipts.Size = new System.Drawing.Size(86, 38);
            this.btn_DELETE_Receipts.TabIndex = 3;
            this.btn_DELETE_Receipts.Text = "Delete";
            this.btn_DELETE_Receipts.UseVisualStyleBackColor = true;
            this.btn_DELETE_Receipts.Click += new System.EventHandler(this.btn_DELETE_Receipts_Click);
            // 
            // btn_ADD_Receipts
            // 
            this.btn_ADD_Receipts.Location = new System.Drawing.Point(9, 371);
            this.btn_ADD_Receipts.Name = "btn_ADD_Receipts";
            this.btn_ADD_Receipts.Size = new System.Drawing.Size(86, 38);
            this.btn_ADD_Receipts.TabIndex = 2;
            this.btn_ADD_Receipts.Text = "Add";
            this.btn_ADD_Receipts.UseVisualStyleBackColor = true;
            this.btn_ADD_Receipts.Click += new System.EventHandler(this.btn_ADD_Receipts_Click);
            // 
            // input_seller_id
            // 
            this.input_seller_id.Location = new System.Drawing.Point(18, 163);
            this.input_seller_id.Name = "input_seller_id";
            this.input_seller_id.Size = new System.Drawing.Size(253, 31);
            this.input_seller_id.TabIndex = 1;
            this.input_seller_id.Text = "";
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.Snow;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(392, 121);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(605, 344);
            this.GridView.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(645, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 68);
            this.label3.TabIndex = 25;
            this.label3.Text = "Чек";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(985, 77);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(86, 38);
            this.btn_Reset.TabIndex = 109;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_seach
            // 
            this.btn_seach.Location = new System.Drawing.Point(893, 75);
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
            this.input_Search.Location = new System.Drawing.Point(620, 75);
            this.input_Search.Name = "input_Search";
            this.input_Search.Size = new System.Drawing.Size(267, 38);
            this.input_Search.TabIndex = 108;
            this.input_Search.Text = "";
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(368, 75);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(246, 38);
            this.Search_comboBox.TabIndex = 106;
            // 
            // ReceiptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 490);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_seach);
            this.Controls.Add(this.input_Search);
            this.Controls.Add(this.Search_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiptsForm";
            this.Text = "ReceiptsForm";
            this.Load += new System.EventHandler(this.ReceiptsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox input_receipt_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EDIT_Receipts;
        private System.Windows.Forms.Button btn_DELETE_Receipts;
        private System.Windows.Forms.Button btn_ADD_Receipts;
        private System.Windows.Forms.RichTextBox input_seller_id;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox input_sale_date;
        private System.Windows.Forms.RichTextBox input_discount_card_id;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_seach;
        private System.Windows.Forms.RichTextBox input_Search;
        private System.Windows.Forms.ComboBox Search_comboBox;
    }
}