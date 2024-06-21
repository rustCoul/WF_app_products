namespace WindowsFormsApp_Practice1
{
    partial class Menu
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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.skladeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продавцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисконтнаяКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Discount_CardForm = new System.Windows.Forms.Button();
            this.buttonItemsForm = new System.Windows.Forms.Button();
            this.buttonManufacturersForm = new System.Windows.Forms.Button();
            this.buttonProducts_In_ReceiptForm = new System.Windows.Forms.Button();
            this.buttonProductsInWarehouseForm = new System.Windows.Forms.Button();
            this.buttonReceiptsForm = new System.Windows.Forms.Button();
            this.buttonSellersForm = new System.Windows.Forms.Button();
            this.buttonWarehouseForm = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skladeToolStripMenuItem,
            this.производителиToolStripMenuItem,
            this.чекToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.товарыНаСкладеToolStripMenuItem,
            this.продавцыToolStripMenuItem,
            this.дисконтнаяКартаToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.ShowCheckMargin = true;
            this.contextMenuStrip2.Size = new System.Drawing.Size(244, 200);
            // 
            // skladeToolStripMenuItem
            // 
            this.skladeToolStripMenuItem.Name = "skladeToolStripMenuItem";
            this.skladeToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.skladeToolStripMenuItem.Text = "Склад";
            // 
            // производителиToolStripMenuItem
            // 
            this.производителиToolStripMenuItem.Name = "производителиToolStripMenuItem";
            this.производителиToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.производителиToolStripMenuItem.Text = "Производители";
            // 
            // чекToolStripMenuItem
            // 
            this.чекToolStripMenuItem.Name = "чекToolStripMenuItem";
            this.чекToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.чекToolStripMenuItem.Text = "Чек";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // товарыНаСкладеToolStripMenuItem
            // 
            this.товарыНаСкладеToolStripMenuItem.Name = "товарыНаСкладеToolStripMenuItem";
            this.товарыНаСкладеToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.товарыНаСкладеToolStripMenuItem.Text = "Товары на складе";
            // 
            // продавцыToolStripMenuItem
            // 
            this.продавцыToolStripMenuItem.Name = "продавцыToolStripMenuItem";
            this.продавцыToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.продавцыToolStripMenuItem.Text = "Продавцы";
            // 
            // дисконтнаяКартаToolStripMenuItem
            // 
            this.дисконтнаяКартаToolStripMenuItem.Name = "дисконтнаяКартаToolStripMenuItem";
            this.дисконтнаяКартаToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.дисконтнаяКартаToolStripMenuItem.Text = "Дисконтная карта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(537, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 68);
            this.label2.TabIndex = 6;
            this.label2.Text = "Меню";
            // 
            // button_Discount_CardForm
            // 
            this.button_Discount_CardForm.Location = new System.Drawing.Point(481, 137);
            this.button_Discount_CardForm.Name = "button_Discount_CardForm";
            this.button_Discount_CardForm.Size = new System.Drawing.Size(140, 56);
            this.button_Discount_CardForm.TabIndex = 7;
            this.button_Discount_CardForm.Text = "дисконтная_карта";
            this.button_Discount_CardForm.UseVisualStyleBackColor = true;
            this.button_Discount_CardForm.Click += new System.EventHandler(this.button_Discount_CardForm_Click);
            // 
            // buttonItemsForm
            // 
            this.buttonItemsForm.Location = new System.Drawing.Point(481, 214);
            this.buttonItemsForm.Name = "buttonItemsForm";
            this.buttonItemsForm.Size = new System.Drawing.Size(140, 56);
            this.buttonItemsForm.TabIndex = 8;
            this.buttonItemsForm.Text = "Товары";
            this.buttonItemsForm.UseVisualStyleBackColor = true;
            this.buttonItemsForm.Click += new System.EventHandler(this.buttonItemsForm_Click);
            // 
            // buttonManufacturersForm
            // 
            this.buttonManufacturersForm.Location = new System.Drawing.Point(481, 295);
            this.buttonManufacturersForm.Name = "buttonManufacturersForm";
            this.buttonManufacturersForm.Size = new System.Drawing.Size(140, 56);
            this.buttonManufacturersForm.TabIndex = 9;
            this.buttonManufacturersForm.Text = "Производители";
            this.buttonManufacturersForm.UseVisualStyleBackColor = true;
            this.buttonManufacturersForm.Click += new System.EventHandler(this.buttonManufacturersForm_Click);
            // 
            // buttonProducts_In_ReceiptForm
            // 
            this.buttonProducts_In_ReceiptForm.Location = new System.Drawing.Point(481, 372);
            this.buttonProducts_In_ReceiptForm.Name = "buttonProducts_In_ReceiptForm";
            this.buttonProducts_In_ReceiptForm.Size = new System.Drawing.Size(140, 56);
            this.buttonProducts_In_ReceiptForm.TabIndex = 10;
            this.buttonProducts_In_ReceiptForm.Text = "Товары_в_чеке";
            this.buttonProducts_In_ReceiptForm.UseVisualStyleBackColor = true;
            this.buttonProducts_In_ReceiptForm.Click += new System.EventHandler(this.buttonProducts_In_ReceiptForm_Click);
            // 
            // buttonProductsInWarehouseForm
            // 
            this.buttonProductsInWarehouseForm.Location = new System.Drawing.Point(670, 137);
            this.buttonProductsInWarehouseForm.Name = "buttonProductsInWarehouseForm";
            this.buttonProductsInWarehouseForm.Size = new System.Drawing.Size(140, 56);
            this.buttonProductsInWarehouseForm.TabIndex = 11;
            this.buttonProductsInWarehouseForm.Text = "Товары_на_складе";
            this.buttonProductsInWarehouseForm.UseVisualStyleBackColor = true;
            this.buttonProductsInWarehouseForm.Click += new System.EventHandler(this.buttonProductsInWarehouseForm_Click);
            // 
            // buttonReceiptsForm
            // 
            this.buttonReceiptsForm.Location = new System.Drawing.Point(670, 214);
            this.buttonReceiptsForm.Name = "buttonReceiptsForm";
            this.buttonReceiptsForm.Size = new System.Drawing.Size(140, 56);
            this.buttonReceiptsForm.TabIndex = 12;
            this.buttonReceiptsForm.Text = "чеки";
            this.buttonReceiptsForm.UseVisualStyleBackColor = true;
            this.buttonReceiptsForm.Click += new System.EventHandler(this.buttonReceiptsForm_Click);
            // 
            // buttonSellersForm
            // 
            this.buttonSellersForm.Location = new System.Drawing.Point(670, 295);
            this.buttonSellersForm.Name = "buttonSellersForm";
            this.buttonSellersForm.Size = new System.Drawing.Size(140, 56);
            this.buttonSellersForm.TabIndex = 13;
            this.buttonSellersForm.Text = "продавцы";
            this.buttonSellersForm.UseVisualStyleBackColor = true;
            this.buttonSellersForm.Click += new System.EventHandler(this.buttonSellersForm_Click);
            // 
            // buttonWarehouseForm
            // 
            this.buttonWarehouseForm.Location = new System.Drawing.Point(670, 372);
            this.buttonWarehouseForm.Name = "buttonWarehouseForm";
            this.buttonWarehouseForm.Size = new System.Drawing.Size(140, 56);
            this.buttonWarehouseForm.TabIndex = 14;
            this.buttonWarehouseForm.Text = "Склады";
            this.buttonWarehouseForm.UseVisualStyleBackColor = true;
            this.buttonWarehouseForm.Click += new System.EventHandler(this.buttonWarehouseForm_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 567);
            this.Controls.Add(this.buttonWarehouseForm);
            this.Controls.Add(this.buttonSellersForm);
            this.Controls.Add(this.buttonReceiptsForm);
            this.Controls.Add(this.buttonProductsInWarehouseForm);
            this.Controls.Add(this.buttonProducts_In_ReceiptForm);
            this.Controls.Add(this.buttonManufacturersForm);
            this.Controls.Add(this.buttonItemsForm);
            this.Controls.Add(this.button_Discount_CardForm);
            this.Controls.Add(this.label2);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem skladeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продавцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисконтнаяКартаToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Discount_CardForm;
        private System.Windows.Forms.Button buttonItemsForm;
        private System.Windows.Forms.Button buttonManufacturersForm;
        private System.Windows.Forms.Button buttonProducts_In_ReceiptForm;
        private System.Windows.Forms.Button buttonProductsInWarehouseForm;
        private System.Windows.Forms.Button buttonReceiptsForm;
        private System.Windows.Forms.Button buttonSellersForm;
        private System.Windows.Forms.Button buttonWarehouseForm;
    }
}

