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
    public partial class WarehouseForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8L3K610;Initial Catalog=Practice;Integrated Security=True");
        public WarehouseForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            try
            {
                conn.Open();
                string MyQuery = "Select * FROM Warehouse";
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
                string MyQuery = "Select * FROM Warehouse where " + Search_comboBox.SelectedItem.ToString() + "='" + input_Search.Text + "'";
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

                DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, "Warehouse", null });

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
        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcategory();
        }

        private void btn_ADD_Warehouse_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Warehouse VALUES ('" + input_WarehouseID.Text + "','" + input_WarehouseAdress.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void btn_DELETE_Warehouse_Click(object sender, EventArgs e)
        {
            if (input_WarehouseID.Text == "")
            {
                MessageBox.Show("Enter Warehouse id to DELETE ITEM");
            }
            else
            {
                conn.Open();
                var myQuery_dl = "DELete from Warehouse where warehouse_id ='" + input_WarehouseID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(myQuery_dl, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Warehouse Item DELETED");
                conn.Close();
                populate();
            }
        }

        private void btn_EDIT_Warehouse_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Warehouse SET warehouse_address='" + input_WarehouseAdress.Text + "' where warehouse_id= '" + input_WarehouseID.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void WarehouseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            input_WarehouseID.Text = GridView.SelectedRows[0].Cells[0].Value.ToString();
            input_WarehouseAdress.Text = GridView.SelectedRows[0].Cells[1].Value.ToString();

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
