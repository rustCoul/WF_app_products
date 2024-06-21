namespace WindowsFormsApp_Practice1
{
    partial class Discount_CardForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_discount_card_id = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EDIT_Discount_Card = new System.Windows.Forms.Button();
            this.btn_DELETE_Discount_Card = new System.Windows.Forms.Button();
            this.btn_ADD_Discount_Card = new System.Windows.Forms.Button();
            this.input_discount_percentage = new System.Windows.Forms.RichTextBox();
            this.input_discount_amount = new System.Windows.Forms.RichTextBox();
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.input_discount_card_id);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_EDIT_Discount_Card);
            this.groupBox1.Controls.Add(this.btn_DELETE_Discount_Card);
            this.groupBox1.Controls.Add(this.btn_ADD_Discount_Card);
            this.groupBox1.Controls.Add(this.input_discount_percentage);
            this.groupBox1.Controls.Add(this.input_discount_amount);
            this.groupBox1.Location = new System.Drawing.Point(35, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 446);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Сумма карты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Номер дисконтной карты";
            // 
            // input_discount_card_id
            // 
            this.input_discount_card_id.Location = new System.Drawing.Point(14, 84);
            this.input_discount_card_id.Name = "input_discount_card_id";
            this.input_discount_card_id.Size = new System.Drawing.Size(253, 29);
            this.input_discount_card_id.TabIndex = 20;
            this.input_discount_card_id.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Процент скидки";
            // 
            // btn_EDIT_Discount_Card
            // 
            this.btn_EDIT_Discount_Card.Location = new System.Drawing.Point(193, 317);
            this.btn_EDIT_Discount_Card.Name = "btn_EDIT_Discount_Card";
            this.btn_EDIT_Discount_Card.Size = new System.Drawing.Size(86, 38);
            this.btn_EDIT_Discount_Card.TabIndex = 3;
            this.btn_EDIT_Discount_Card.Text = "Edit";
            this.btn_EDIT_Discount_Card.UseVisualStyleBackColor = true;
            this.btn_EDIT_Discount_Card.Click += new System.EventHandler(this.btn_EDIT_Discount_Card_Click);
            // 
            // btn_DELETE_Discount_Card
            // 
            this.btn_DELETE_Discount_Card.Location = new System.Drawing.Point(101, 317);
            this.btn_DELETE_Discount_Card.Name = "btn_DELETE_Discount_Card";
            this.btn_DELETE_Discount_Card.Size = new System.Drawing.Size(86, 38);
            this.btn_DELETE_Discount_Card.TabIndex = 3;
            this.btn_DELETE_Discount_Card.Text = "Delete";
            this.btn_DELETE_Discount_Card.UseVisualStyleBackColor = true;
            this.btn_DELETE_Discount_Card.Click += new System.EventHandler(this.btn_DELETE_Discount_Card_Click);
            // 
            // btn_ADD_Discount_Card
            // 
            this.btn_ADD_Discount_Card.Location = new System.Drawing.Point(6, 317);
            this.btn_ADD_Discount_Card.Name = "btn_ADD_Discount_Card";
            this.btn_ADD_Discount_Card.Size = new System.Drawing.Size(86, 38);
            this.btn_ADD_Discount_Card.TabIndex = 2;
            this.btn_ADD_Discount_Card.Text = "Add";
            this.btn_ADD_Discount_Card.UseVisualStyleBackColor = true;
            this.btn_ADD_Discount_Card.Click += new System.EventHandler(this.btn_ADD_Discount_Card_Click);
            // 
            // input_discount_percentage
            // 
            this.input_discount_percentage.Location = new System.Drawing.Point(18, 163);
            this.input_discount_percentage.Name = "input_discount_percentage";
            this.input_discount_percentage.Size = new System.Drawing.Size(253, 31);
            this.input_discount_percentage.TabIndex = 1;
            this.input_discount_percentage.Text = "";
            // 
            // input_discount_amount
            // 
            this.input_discount_amount.Location = new System.Drawing.Point(18, 247);
            this.input_discount_amount.Name = "input_discount_amount";
            this.input_discount_amount.Size = new System.Drawing.Size(253, 29);
            this.input_discount_amount.TabIndex = 0;
            this.input_discount_amount.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(359, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 68);
            this.label3.TabIndex = 24;
            this.label3.Text = "Дисконтная карта";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(993, 98);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(86, 38);
            this.btn_Reset.TabIndex = 95;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_seach
            // 
            this.btn_seach.Location = new System.Drawing.Point(901, 99);
            this.btn_seach.Name = "btn_seach";
            this.btn_seach.Size = new System.Drawing.Size(86, 38);
            this.btn_seach.TabIndex = 93;
            this.btn_seach.Text = "Search";
            this.btn_seach.UseVisualStyleBackColor = true;
            this.btn_seach.Click += new System.EventHandler(this.btn_seach_Click);
            // 
            // input_Search
            // 
            this.input_Search.Font = new System.Drawing.Font("Garamond", 16.2F);
            this.input_Search.Location = new System.Drawing.Point(628, 99);
            this.input_Search.Name = "input_Search";
            this.input_Search.Size = new System.Drawing.Size(267, 38);
            this.input_Search.TabIndex = 94;
            this.input_Search.Text = "";
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(361, 99);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(246, 38);
            this.Search_comboBox.TabIndex = 92;
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.Snow;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(400, 152);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(587, 310);
            this.GridView.TabIndex = 91;
            // 
            // Discount_CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 514);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_seach);
            this.Controls.Add(this.input_Search);
            this.Controls.Add(this.Search_comboBox);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Discount_CardForm";
            this.Text = "Discount_CardForm";
            this.Load += new System.EventHandler(this.Discount_CardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox input_discount_card_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EDIT_Discount_Card;
        private System.Windows.Forms.Button btn_DELETE_Discount_Card;
        private System.Windows.Forms.Button btn_ADD_Discount_Card;
        private System.Windows.Forms.RichTextBox input_discount_percentage;
        private System.Windows.Forms.RichTextBox input_discount_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_seach;
        private System.Windows.Forms.RichTextBox input_Search;
        private System.Windows.Forms.ComboBox Search_comboBox;
        private System.Windows.Forms.DataGridView GridView;
    }
}