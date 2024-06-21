using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Practice1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_Discount_CardForm_Click(object sender, EventArgs e)
        {
            Discount_CardForm discount_CardForm = new Discount_CardForm();
            discount_CardForm.Show();
            this.Hide();
        }

        private void buttonItemsForm_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
            this.Hide();
        }

        private void buttonManufacturersForm_Click(object sender, EventArgs e)
        {
            ManufacturersForm manufacturersForm = new ManufacturersForm();
            manufacturersForm.Show();
            this.Hide();
        }

        private void buttonProducts_In_ReceiptForm_Click(object sender, EventArgs e)
        {
            Products_In_ReceiptForm products_In_ReceiptForm = new Products_In_ReceiptForm();
            products_In_ReceiptForm.Show();
            this.Hide();
        }

        private void buttonProductsInWarehouseForm_Click(object sender, EventArgs e)
        {
            ProductsInWarehouseForm productsInWarehouseForm = new ProductsInWarehouseForm();
            productsInWarehouseForm.Show();
            this.Hide();
        }

        private void buttonReceiptsForm_Click(object sender, EventArgs e)
        {
            ReceiptsForm receiptsForm = new ReceiptsForm();
            receiptsForm.Show();
            this.Hide();
        }

        private void buttonSellersForm_Click(object sender, EventArgs e)
        {
            SellersForm sellersForm = new SellersForm();
            sellersForm.Show();
            this.Hide();
        }

        private void buttonWarehouseForm_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.Show();
            this.Hide();
        }
    }
}
