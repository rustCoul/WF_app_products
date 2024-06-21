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

namespace WindowsFormsApp_Practice1
{
    public partial class ProductsInWarehouseForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8L3K610;Initial Catalog=Practice;Integrated Security=True");
        public ProductsInWarehouseForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            try
            {
                conn.Open();
                string MyQuery = "Select * FROM Products_In_Warehouse";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch { }
        }
        void Filter()
        {
            try
            {

                conn.Open();
                string MyQuery = "Select * FROM Products_In_Warehouse where " + Search_comboBox.SelectedItem.ToString() + "='" + input_Search.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (NullReferenceException ex)
            {
                // Log the specific null reference exception
                Console.WriteLine("NullReferenceException: " + ex.Message);
            }
        }
        void fillcategory()
        {

            try
            {
                conn.Open();

                DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, "Products_In_Warehouse", null });

                Search_comboBox.Items.Clear();
                foreach (DataRow row in schemaTable.Rows)
                {
                    Search_comboBox.Items.Add(row["COLUMN_NAME"].ToString());
                }

                if (Search_comboBox.Items.Count > 0)
                {
                    Search_comboBox.SelectedIndex = 0;
                }
                conn.Close();
            }
            catch (NullReferenceException ex)
            {
                // Log the specific null reference exception
                Console.WriteLine("NullReferenceException: " + ex.Message);
            }
        }
        private void btn_ADD_Products_in_Warehouse_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Products_In_Warehouse VALUES ('" + Products_in_warehouse_ID.Text + "','" + input_Product_id.Text + "','" + input_WarehouseID.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ProductsInWarehouseForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcategory();
        }

        private void btn_DELETE_Products_in_Warehouse_Click(object sender, EventArgs e)
        {
            if (Products_in_warehouse_ID.Text == "")
            {
                MessageBox.Show("Enter product in warehouse id to DELETE ITEM");
            }
            else
            {
                conn.Open();
                var myQuery_dl = "DELete from Products_In_Warehouse where product_in_warehouse_id ='" + Products_in_warehouse_ID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(myQuery_dl, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Products_In_Warehouse Item DELETED");
                conn.Close();
                populate();
            }
        }

        private void btn_EDIT_Products_in_Warehouse_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Products_In_Warehouse SET product_id='" + input_Product_id.Text + "',warehouse_id='" + input_WarehouseID.Text + "' where product_in_warehouse_id= '" + Products_in_warehouse_ID.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                conn.Close();
                populate();
            }
            catch
            {

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
            Filter();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
