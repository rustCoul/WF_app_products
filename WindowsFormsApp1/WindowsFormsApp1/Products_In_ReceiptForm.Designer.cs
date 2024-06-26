namespace WindowsFormsApp1
{
    partial class Products_In_ReceiptForm
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
            this.Input_groupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_OLD_Receipt_id = new System.Windows.Forms.RichTextBox();
            this.input_OLD_Products_in_warehouse_ID = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_Products_in_warehouse_ID = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EDIT_Products_in_Receipt = new System.Windows.Forms.Button();
            this.btn_DELETE_Products_in_Receipt = new System.Windows.Forms.Button();
            this.btn_ADD_Products_in_Receipt = new System.Windows.Forms.Button();
            this.input_Receipt_id = new System.Windows.Forms.RichTextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_seach = new System.Windows.Forms.Button();
            this.input_Search = new System.Windows.Forms.RichTextBox();
            this.Search_comboBox = new System.Windows.Forms.ComboBox();
            this.Input_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Input_groupBox
            // 
            this.Input_groupBox.BackColor = System.Drawing.SystemColors.Control;
            this.Input_groupBox.Controls.Add(this.label5);
            this.Input_groupBox.Controls.Add(this.label6);
            this.Input_groupBox.Controls.Add(this.label4);
            this.Input_groupBox.Controls.Add(this.input_OLD_Receipt_id);
            this.Input_groupBox.Controls.Add(this.input_OLD_Products_in_warehouse_ID);
            this.Input_groupBox.Controls.Add(this.label2);
            this.Input_groupBox.Controls.Add(this.input_Products_in_warehouse_ID);
            this.Input_groupBox.Controls.Add(this.button1);
            this.Input_groupBox.Controls.Add(this.label1);
            this.Input_groupBox.Controls.Add(this.btn_EDIT_Products_in_Receipt);
            this.Input_groupBox.Controls.Add(this.btn_DELETE_Products_in_Receipt);
            this.Input_groupBox.Controls.Add(this.btn_ADD_Products_in_Receipt);
            this.Input_groupBox.Controls.Add(this.input_Receipt_id);
            this.Input_groupBox.Location = new System.Drawing.Point(25, 12);
            this.Input_groupBox.Name = "Input_groupBox";
            this.Input_groupBox.Size = new System.Drawing.Size(805, 496);
            this.Input_groupBox.TabIndex = 4;
            this.Input_groupBox.TabStop = false;
            this.Input_groupBox.Text = "input_groupBox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(318, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Старое Номер продукта в складе";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(334, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Нужно только при использовании EDit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(318, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "Старое ID Чека";
            // 
            // input_OLD_Receipt_id
            // 
            this.input_OLD_Receipt_id.Location = new System.Drawing.Point(324, 209);
            this.input_OLD_Receipt_id.Name = "input_OLD_Receipt_id";
            this.input_OLD_Receipt_id.Size = new System.Drawing.Size(277, 31);
            this.input_OLD_Receipt_id.TabIndex = 23;
            this.input_OLD_Receipt_id.Text = "";
            // 
            // input_OLD_Products_in_warehouse_ID
            // 
            this.input_OLD_Products_in_warehouse_ID.Location = new System.Drawing.Point(324, 143);
            this.input_OLD_Products_in_warehouse_ID.Name = "input_OLD_Products_in_warehouse_ID";
            this.input_OLD_Products_in_warehouse_ID.Size = new System.Drawing.Size(277, 29);
            this.input_OLD_Products_in_warehouse_ID.TabIndex = 22;
            this.input_OLD_Products_in_warehouse_ID.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Номер продукта в складе";
            // 
            // input_Products_in_warehouse_ID
            // 
            this.input_Products_in_warehouse_ID.Location = new System.Drawing.Point(12, 143);
            this.input_Products_in_warehouse_ID.Name = "input_Products_in_warehouse_ID";
            this.input_Products_in_warehouse_ID.Size = new System.Drawing.Size(277, 29);
            this.input_Products_in_warehouse_ID.TabIndex = 20;
            this.input_Products_in_warehouse_ID.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 360);
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
            this.label1.Location = new System.Drawing.Point(6, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Чека";
            // 
            // btn_EDIT_Products_in_Receipt
            // 
            this.btn_EDIT_Products_in_Receipt.Location = new System.Drawing.Point(196, 277);
            this.btn_EDIT_Products_in_Receipt.Name = "btn_EDIT_Products_in_Receipt";
            this.btn_EDIT_Products_in_Receipt.Size = new System.Drawing.Size(86, 38);
            this.btn_EDIT_Products_in_Receipt.TabIndex = 3;
            this.btn_EDIT_Products_in_Receipt.Text = "Edit";
            this.btn_EDIT_Products_in_Receipt.UseVisualStyleBackColor = true;
            this.btn_EDIT_Products_in_Receipt.Click += new System.EventHandler(this.btn_EDIT_Products_in_Receipt_Click);
            // 
            // btn_DELETE_Products_in_Receipt
            // 
            this.btn_DELETE_Products_in_Receipt.Location = new System.Drawing.Point(104, 277);
            this.btn_DELETE_Products_in_Receipt.Name = "btn_DELETE_Products_in_Receipt";
            this.btn_DELETE_Products_in_Receipt.Size = new System.Drawing.Size(86, 38);
            this.btn_DELETE_Products_in_Receipt.TabIndex = 3;
            this.btn_DELETE_Products_in_Receipt.Text = "Delete";
            this.btn_DELETE_Products_in_Receipt.UseVisualStyleBackColor = true;
            this.btn_DELETE_Products_in_Receipt.Click += new System.EventHandler(this.btn_DELETE_Products_in_Receipt_Click);
            // 
            // btn_ADD_Products_in_Receipt
            // 
            this.btn_ADD_Products_in_Receipt.Location = new System.Drawing.Point(12, 277);
            this.btn_ADD_Products_in_Receipt.Name = "btn_ADD_Products_in_Receipt";
            this.btn_ADD_Products_in_Receipt.Size = new System.Drawing.Size(86, 38);
            this.btn_ADD_Products_in_Receipt.TabIndex = 2;
            this.btn_ADD_Products_in_Receipt.Text = "Add";
            this.btn_ADD_Products_in_Receipt.UseVisualStyleBackColor = true;
            this.btn_ADD_Products_in_Receipt.Click += new System.EventHandler(this.btn_ADD_Products_in_Receipt_Click);
            // 
            // input_Receipt_id
            // 
            this.input_Receipt_id.Location = new System.Drawing.Point(12, 209);
            this.input_Receipt_id.Name = "input_Receipt_id";
            this.input_Receipt_id.Size = new System.Drawing.Size(277, 31);
            this.input_Receipt_id.TabIndex = 1;
            this.input_Receipt_id.Text = "";
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.Snow;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(837, 187);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(566, 310);
            this.GridView.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(836, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 68);
            this.label3.TabIndex = 24;
            this.label3.Text = "Продукты в чеке";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(1236, 124);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(86, 38);
            this.btn_Reset.TabIndex = 109;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_seach
            // 
            this.btn_seach.Location = new System.Drawing.Point(1126, 124);
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
            this.input_Search.Location = new System.Drawing.Point(837, 124);
            this.input_Search.Name = "input_Search";
            this.input_Search.Size = new System.Drawing.Size(268, 38);
            this.input_Search.TabIndex = 108;
            this.input_Search.Text = "";
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(837, 70);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(268, 38);
            this.Search_comboBox.TabIndex = 106;
            // 
            // Products_In_ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1444, 546);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_seach);
            this.Controls.Add(this.input_Search);
            this.Controls.Add(this.Search_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.Input_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products_In_ReceiptForm";
            this.Text = "Products_In_ReceiptForm";
            this.Load += new System.EventHandler(this.Products_In_ReceiptForm_Load);
            this.Input_groupBox.ResumeLayout(false);
            this.Input_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Input_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox input_Products_in_warehouse_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EDIT_Products_in_Receipt;
        private System.Windows.Forms.Button btn_DELETE_Products_in_Receipt;
        private System.Windows.Forms.Button btn_ADD_Products_in_Receipt;
        private System.Windows.Forms.RichTextBox input_Receipt_id;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox input_OLD_Receipt_id;
        private System.Windows.Forms.RichTextBox input_OLD_Products_in_warehouse_ID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_seach;
        private System.Windows.Forms.RichTextBox input_Search;
        private System.Windows.Forms.ComboBox Search_comboBox;
    }
}