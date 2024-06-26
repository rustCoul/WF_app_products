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
    public partial class SellersForm : Form
    {
       

        public SellersForm()
        {
            InitializeComponent();
        }
        Actions actions = new Actions("Sellers", "seller_id", "first_name", "last_name", "middle_name", "birth_date", "hire_date", "username", "password");
        private void btn_ADD_Sellers_Click(object sender, EventArgs e)
        {
          
           string[] namesOfinputs = { input_seller_id.Text, input_first_name.Text , input_last_name.Text, input_middle_name.Text , input_birth_date.Text, input_hire_date.Text, input_username.Text, input_password.Text };
            actions.ADD(SellersGridView, actions, namesOfinputs);
        }

        private void btn_DELETE_Sellers_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_seller_id.Text, input_first_name.Text, input_last_name.Text, input_middle_name.Text, input_birth_date.Text, input_hire_date.Text, input_username.Text, input_password.Text };
            actions.DELETE(SellersGridView, actions, namesOfinputs[0]);
        }

        private void btn_EDIT_Sellers_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_seller_id.Text, input_first_name.Text, input_last_name.Text, input_middle_name.Text, input_birth_date.Text, input_hire_date.Text, input_username.Text, input_password.Text };
            actions.EDIT(SellersGridView, actions, namesOfinputs);
        }

        private void SellersForm_Load(object sender, EventArgs e)
        {
            actions.populate(SellersGridView);
            actions.fillcategory(Sellers_comboBox);

        }

        private void btn_Seller_seach_Click(object sender, EventArgs e)
        {
            actions.Filter(SellersGridView, Sellers_comboBox, input_Sellers_Search);
        }

        private void btn_Reset_Sellers_Click(object sender, EventArgs e)
        {
            actions.populate(SellersGridView);
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();

        }
    }
}
