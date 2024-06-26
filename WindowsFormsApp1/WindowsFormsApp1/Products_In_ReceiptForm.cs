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
    public partial class Products_In_ReceiptForm : Form
    {
        
        public Products_In_ReceiptForm()
        {
            InitializeComponent();
        }
       Actions actions = new Actions("Products_In_Receipt");
        private void btn_ADD_Products_in_Receipt_Click(object sender, EventArgs e)
        {
          
                string[] namesOfinputs = { input_Products_in_warehouse_ID.Text, input_Receipt_id.Text };
                actions.ADD(GridView, actions, namesOfinputs);
            }

        private void Products_In_ReceiptForm_Load(object sender, EventArgs e)
        {
            actions.populate(GridView);
            actions.fillcategory(Search_comboBox);
        }

        private void btn_DELETE_Products_in_Receipt_Click(object sender, EventArgs e)
        {
            if (input_Products_in_warehouse_ID.Text == "" || input_Receipt_id.Text == "" )
            {
                MessageBox.Show("Enter product in receipt id or Receipt id to DELETE ITEM");
            }
            else
            {
                Actions.conn.Open();
                var myQuery_dl = "DELete from Products_In_Receipt where product_in_warehouse_id ='" + input_Products_in_warehouse_ID.Text + "' and receipt_id='"+ input_Receipt_id .Text+ "'";
                SqlCommand cmd2 = new SqlCommand(myQuery_dl, Actions.conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Products_In_Receipt Item DELETED");
                Actions.conn.Close();
                actions.populate(GridView);
            }
        }

        private void btn_EDIT_Products_in_Receipt_Click(object sender, EventArgs e)
        {
            if (input_Products_in_warehouse_ID.Text == "" || input_Receipt_id.Text == "")
            {
                MessageBox.Show("Fill all the rows on the LEFT  to Update ITEM");
            } else if (input_OLD_Receipt_id.Text == ""|| input_OLD_Products_in_warehouse_ID.Text == "")
            {
                MessageBox.Show("Fill all the rows on the RIGHT  to Update ITEM");
            } else {
                Actions.conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Products_In_Receipt SET product_in_warehouse_id='" + input_Products_in_warehouse_ID.Text + "',receipt_id='" + input_Receipt_id.Text + "' where product_in_warehouse_id= '" + input_OLD_Products_in_warehouse_ID.Text + "'and receipt_id='" + input_OLD_Receipt_id.Text + "' ", Actions.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                Actions.conn.Close();
                actions.populate(GridView);
            }

               
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btn_seach_Click(object sender, EventArgs e)
        {
            actions.Filter(GridView,Search_comboBox, input_Search);
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
