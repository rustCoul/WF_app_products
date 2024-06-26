using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class ItemsForm : Form
    {  
        public ItemsForm()
        {
            InitializeComponent();
        }
        Actions actions= new Actions("Products", "product_id", "manufacturer_id", "product_name", "price", "warranty_period");
       
        private void btn_ADD_Click(object sender, EventArgs e)
        {


            string[] namesOfinputs = { btn_ProductId_tb_product.Text , Items_dbtb_idNumberInput.Text, Items_dbtb_Name_Input.Text, Items_dbtb_Price_Input.Text, Items_dbtb_Time_Input.Text };
            actions.ADD(GridView, actions, namesOfinputs);
        }
      
        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            actions.populate(GridView);
            actions.fillcategory(Search_comboBox);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { btn_ProductId_tb_product.Text, Items_dbtb_idNumberInput.Text, Items_dbtb_Name_Input.Text, Items_dbtb_Price_Input.Text, Items_dbtb_Time_Input.Text };
            actions.EDIT(GridView, actions, namesOfinputs);
        }
        private void button1_Click(object sender, EventArgs e)
        {
        
            string[] namesOfinputs = { btn_ProductId_tb_product.Text, Items_dbtb_idNumberInput.Text, Items_dbtb_Name_Input.Text, Items_dbtb_Price_Input.Text, Items_dbtb_Time_Input.Text };
            actions.DELETE(GridView, actions, namesOfinputs[0]);
        }

        private void btn_home_Click(object sender, EventArgs e)
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
    }

        
 }


