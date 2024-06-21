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
    public partial class Discount_CardForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8L3K610;Initial Catalog=Practice;Integrated Security=True");

        public Discount_CardForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            try
            {
                conn.Open();
                string MyQuery = "Select * FROM дисконтная_карта";
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
                string MyQuery = "Select * FROM дисконтная_карта where " + Search_comboBox.SelectedItem.ToString() + "='" + input_Search.Text + "'";
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
        private void btn_ADD_Discount_Card_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO дисконтная_карта VALUES ('" + input_discount_card_id.Text + "','" + input_discount_percentage.Text + "','" + input_discount_amount.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Предмет добавлен");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }
        void fillcategory()
        {

            try
            {
                conn.Open();

                DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, "дисконтная_карта", null });

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
        private void Discount_CardForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcategory();
        }

        private void btn_DELETE_Discount_Card_Click(object sender, EventArgs e)
        {
            if (input_discount_card_id.Text == "")
            {
                MessageBox.Show("Заполните поле номер_карты для удаления");
            }
            else
            {
                conn.Open();
                var myQuery_dl = "DELete from дисконтная_карта where номер_карты ='" + input_discount_card_id.Text + "'";
                SqlCommand cmd2 = new SqlCommand(myQuery_dl, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Предмет удален");
                conn.Close();
                populate();
            }
        }

        private void btn_EDIT_Discount_Card_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE дисконтная_карта SET процент_карты='" + input_discount_percentage.Text + "',сумма_карты='" + input_discount_amount.Text + "' where номер_карты= '" + input_discount_card_id.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Предмет обновился");
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
