using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductsInWarehouseForm : Form
    {
        public ProductsInWarehouseForm()
        {
            InitializeComponent();
        }
      Actions actions = new Actions("Products_In_Warehouse", "product_in_warehouse_id", "product_id", "warehouse_id");
        private void btn_ADD_Products_in_Warehouse_Click(object sender, EventArgs e)
        {
           
          string[] namesOfinputs = { Products_in_warehouse_ID.Text, input_Product_id.Text, input_WarehouseID.Text };
            actions.ADD(GridView,actions,namesOfinputs);
        }

        private void ProductsInWarehouseForm_Load(object sender, EventArgs e)
        {
            actions.populate(GridView);
            actions.fillcategory(Search_comboBox);
        }

        private void btn_DELETE_Products_in_Warehouse_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { Products_in_warehouse_ID.Text, input_Product_id.Text, input_WarehouseID.Text };
            actions.DELETE(GridView, actions, namesOfinputs[0]);
        }

        private void btn_EDIT_Products_in_Warehouse_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { Products_in_warehouse_ID.Text, input_Product_id.Text, input_WarehouseID.Text };
            actions.EDIT(GridView, actions, namesOfinputs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btn_seach_Click(object sender, EventArgs e)
        {
            actions.Filter(GridView,Search_comboBox,input_Search);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            actions.populate(GridView);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
