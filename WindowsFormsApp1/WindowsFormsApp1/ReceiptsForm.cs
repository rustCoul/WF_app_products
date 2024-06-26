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
    public partial class ReceiptsForm : Form
    {

        public ReceiptsForm()
        {
            InitializeComponent();
        }
       Actions actions =new Actions("Receipts", "receipt_id", "seller_id", "discount_card_id", "sale_date");
        private void btn_ADD_Receipts_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_receipt_id.Text , input_seller_id.Text, input_discount_card_id.Text, input_sale_date.Text };
          actions.ADD(GridView,actions,namesOfinputs);
        }

        private void btn_DELETE_Receipts_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_receipt_id.Text, input_seller_id.Text, input_discount_card_id.Text, input_sale_date.Text };
            actions.DELETE(GridView, actions, namesOfinputs[0]);
        }

        private void btn_EDIT_Receipts_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_receipt_id.Text, input_seller_id.Text, input_discount_card_id.Text, input_sale_date.Text };
            actions.EDIT(GridView, actions, namesOfinputs);
        }

        private void ReceiptsForm_Load(object sender, EventArgs e)
        {
            actions.populate(GridView);
            actions.fillcategory(Search_comboBox);
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
