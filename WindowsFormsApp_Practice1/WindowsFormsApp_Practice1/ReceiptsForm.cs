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
    public partial class ReceiptsForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8L3K610;Initial Catalog=Practice;Integrated Security=True");

        public ReceiptsForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            try
            {
                conn.Open();
                string MyQuery = "Select * FROM Receipts";
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
                string MyQuery = "Select * FROM Receipts where " + Search_comboBox.SelectedItem.ToString() + "='" + input_Search.Text + "'";
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

                DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, "Receipts", null });

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
        private void btn_ADD_Receipts_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Receipts VALUES ('" + input_receipt_id.Text + "','" + input_seller_id.Text + "','" + input_discount_card_id.Text + "','" + input_sale_date.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void btn_DELETE_Receipts_Click(object sender, EventArgs e)
        {
            if (input_receipt_id.Text == "")
            {
                MessageBox.Show("Enter input_receipt_id to DELETE ITEM");
            }
            else
            {
                conn.Open();
                var myQuery_dl = "DELete from Receipts where receipt_id ='" + input_receipt_id.Text + "'";
                SqlCommand cmd2 = new SqlCommand(myQuery_dl, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Receipts Item DELETED");
                conn.Close();
                populate();
            }
        }

        private void btn_EDIT_Receipts_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Receipts SET seller_id='" + input_seller_id.Text + "',discount_card_id='" + input_discount_card_id.Text + "',sale_date='" + input_sale_date.Text + "' where receipt_id= '" + input_receipt_id.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ReceiptsForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcategory();
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
