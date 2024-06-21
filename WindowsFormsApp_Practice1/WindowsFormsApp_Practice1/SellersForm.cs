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
    public partial class SellersForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8L3K610;Initial Catalog=Practice;Integrated Security=True");

        public SellersForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            try
            {
                conn.Open();
                string MyQuery = "Select * FROM Sellers";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                SellersGridView.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch { }
        }
        void Filter()
        {
            try
            {

                conn.Open();
                string MyQuery = "Select * FROM Sellers where " + Sellers_comboBox.SelectedItem.ToString() + "='" + input_Sellers_Search.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                SellersGridView.DataSource = ds.Tables[0];
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

                DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, "Sellers", null });

                Sellers_comboBox.Items.Clear();
                foreach (DataRow row in schemaTable.Rows)
                {
                    Sellers_comboBox.Items.Add(row["COLUMN_NAME"].ToString());
                }

                if (Sellers_comboBox.Items.Count > 0)
                {
                    Sellers_comboBox.SelectedIndex = 0;
                }
                conn.Close();
            }
            catch (NullReferenceException ex)
            {
                // Log the specific null reference exception
                Console.WriteLine("NullReferenceException: " + ex.Message);
            }
        }
        private void btn_ADD_Sellers_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Sellers VALUES ('" + input_seller_id.Text + "','" + input_first_name.Text + "','" + input_last_name.Text + "','" + input_middle_name.Text + "','" + input_birth_date.Text + "','" + input_hire_date.Text + "','" + input_username.Text + "','" + input_password.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added");
                conn.Close();
                populate();
            }
            catch
            {


            }
        }

        private void btn_DELETE_Sellers_Click(object sender, EventArgs e)
        {
            if (input_seller_id.Text == "")
            {
                MessageBox.Show("Enter input_seller_id to DELETE ITEM");
            }
            else
            {
                conn.Open();
                var myQuery_dl = "DELete from Sellers where seller_id ='" + input_seller_id.Text + "'";
                SqlCommand cmd2 = new SqlCommand(myQuery_dl, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Sellers Item DELETED");
                conn.Close();
                populate();
            }
        }

        private void btn_EDIT_Sellers_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Sellers SET first_name='" + input_first_name.Text + "',last_name='" + input_last_name.Text + "',middle_name='" + input_middle_name.Text + "',birth_date='" + input_birth_date.Text + "',hire_date='" + input_hire_date.Text + "',username='" + input_username.Text + "',password='" + input_password.Text + "' where seller_id= '" + input_seller_id.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void SellersForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcategory();

        }

        private void btn_Seller_seach_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btn_Reset_Sellers_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();

        }
    }
}
