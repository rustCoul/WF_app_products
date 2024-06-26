using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public class Actions
    {
     

        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8L3K610;Initial Catalog=Practice;Integrated Security=True");
        private string table;
        string[] namesOfrows;
       
        public Actions(string table,params string[] namesOfrows)
        {
            this.table = table;
            this.namesOfrows = namesOfrows;
            
        }
       
      internal  void populate(DataGridView GridView)
        {
            try
            {
                conn.Open();
                string MyQuery = "Select * FROM "+table+"";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch { }
        }
       internal void Filter( DataGridView GridView,ComboBox Search_comboBox,RichTextBox input_Search)
        {
            try
            {

                conn.Open();
                string MyQuery = "Select * FROM  "+ table +" where " + Search_comboBox.SelectedItem.ToString() + "='" + input_Search.Text + "'";
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
       internal void fillcategory(ComboBox Search_comboBox)
        {

            try
            {
                conn.Open();

                DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, table, null });

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
        internal void ADD(DataGridView GridView,Actions action,string[] inputs)
        {
            try
            {
                conn.Open();
                string input_names="";

                foreach (var row in inputs)
                {
                    input_names += ",'" + row + "'";
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO " + table + " VALUES (" + input_names.Remove(0, 1) + ")", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added");
                conn.Close();
                action.populate(GridView);
            }
            catch
            {

            }
        }
        internal void DELETE(DataGridView GridView, Actions action,string Input_Value)
        {
            if (Input_Value == "")
            {
                MessageBox.Show("Enter "+ namesOfrows[0] + " to DELETE ITEM");
            }
            else
            {
                conn.Open();
                var myQuery_dl = "DELete from "+table+" where " + namesOfrows[0] +" ='" + Input_Value + "'";
                SqlCommand cmd2 = new SqlCommand(myQuery_dl, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Item DELETED");
                conn.Close();
                action.populate(GridView);
            }
        }
        internal void EDIT(DataGridView GridView, Actions action, string[] inputs)
        {
            try
            {
                conn.Open();
                string input_names = "";
                int i = 1;
                while(i < inputs.Length)
                {
                    input_names += "," + namesOfrows[i] +"='" + inputs[i] + "'";
                    i++;
                }
                Console.WriteLine(input_names);
                SqlCommand cmd = new SqlCommand("UPDATE "+table+" SET "+ input_names.Remove(0, 1) + " where " + namesOfrows[0] +"= '" + inputs[0] + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                conn.Close();
                action.populate(GridView);
            }
            catch
            {

            }
        }
    }
}
