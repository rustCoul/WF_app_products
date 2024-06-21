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
    public partial class ItemsForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8L3K610;Initial Catalog=Practice;Integrated Security=True");
        public ItemsForm()
        {
            InitializeComponent();
        }

        void populate()
        {
            try
            {
                conn.Open();
                string MyQuery = "Select * FROM Товары";
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
                string MyQuery = "Select * FROM Товары where " + Search_comboBox.SelectedItem.ToString() + "='" + input_Search.Text + "'";
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

                DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, "Товары", null });

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
        private void btn_ADD_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Товары VALUES ('" + btn_ProductId_tb_product.Text + "','" + Items_dbtb_idNumberInput.Text + "','" + Items_dbtb_Name_Input.Text + "','" + Items_dbtb_Price_Input.Text + "','" + Items_dbtb_Time_Input.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Предмет добавлен");
                conn.Close();
                populate();
            }
            catch
            {

            }
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcategory();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Товары SET НомерПроизводителя='" + Items_dbtb_idNumberInput.Text + "',Название='" + Items_dbtb_Name_Input.Text + "',Цена='" + Items_dbtb_Price_Input.Text + "',СрокГарантии='" + Items_dbtb_Time_Input.Text + "'where НомерТовара= '" + btn_ProductId_tb_product.Text + "'", conn);
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
            if (btn_ProductId_tb_product.Text == "")
            {
                MessageBox.Show("Заполните поле НомерТовара для удаления");
            }
            else
            {
                conn.Open();
                var myQuery_dl = "DELete from Товары where НомерТовара ='" + btn_ProductId_tb_product.Text + "'";
                SqlCommand cmd2 = new SqlCommand(myQuery_dl, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Предмет удален");
                conn.Close();
                populate();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
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


