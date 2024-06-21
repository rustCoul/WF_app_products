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
    public partial class ManufacturersForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8L3K610;Initial Catalog=Practice;Integrated Security=True");

        public ManufacturersForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            try
            {
                conn.Open();
                string MyQuery = "Select * FROM Производители";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch { }
        }
        private void btn_ADD_Manufacturers_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Производители VALUES ('" + input_manufacturer_id.Text + "','" + input_manufacturer_name.Text + "','" + input_country.Text + "','" + input_city.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Предмет добавлен");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void btn_DELETE_Manufacturers_Click(object sender, EventArgs e)
        {
            if (input_manufacturer_id.Text == "")
            {
                MessageBox.Show("Заполните поле НомерПроизводителя для удаления");
            }
            else
            {
                conn.Open();
                var myQuery_dl = "DELete from Производители where НомерПроизводителя ='" + input_manufacturer_id.Text + "'";
                SqlCommand cmd2 = new SqlCommand(myQuery_dl, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Предмет удален");
                conn.Close();
                populate();
            }
        }

        private void btn_EDIT_Manufacturers_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Производители SET НазваниеПроизводителя='" + input_manufacturer_name.Text + "',Страна='" + input_country.Text + "',Город='" + input_city.Text + "' where Производители= '" + input_manufacturer_id.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Предмет обновился");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }
        void Filter()
        {
            try
            {

                conn.Open();
                string MyQuery = "Select * FROM Производители where " + Search_comboBox.SelectedItem.ToString() + "='" + input_Search.Text + "'";
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

                DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, "Производители", null });

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
        private void ManufacturersForm_Load(object sender, EventArgs e)
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
