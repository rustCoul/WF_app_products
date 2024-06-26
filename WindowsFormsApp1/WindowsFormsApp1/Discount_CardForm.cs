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
    public partial class Discount_CardForm : Form
    {


        public Discount_CardForm()
        {
            InitializeComponent();
        }
       
        Actions actions = new Actions("Discount_Card","discount_card_id", "discount_percentage", "discount_amount");
        
        

        private void btn_ADD_Discount_Card_Click(object sender, EventArgs e)
        {
      
            string[] namesOfinputs = { input_discount_card_id.Text, input_discount_percentage.Text, input_discount_amount.Text };
            actions.ADD(GridView, actions, namesOfinputs);
        }
        
        private void Discount_CardForm_Load(object sender, EventArgs e)
        {
            
            actions.populate(GridView);
            actions.fillcategory(Search_comboBox);
        }

        private void btn_DELETE_Discount_Card_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_discount_card_id.Text, input_discount_percentage.Text, input_discount_amount.Text };
          
            actions.DELETE(GridView, actions, namesOfinputs[0]);
        }

        private void btn_EDIT_Discount_Card_Click(object sender, EventArgs e)
        {
          
            string[] namesOfinputs = { input_discount_card_id.Text, input_discount_percentage.Text, input_discount_amount.Text };
            actions.EDIT(GridView, actions, namesOfinputs);
        }

        private void button1_Click(object sender, EventArgs e)
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
