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
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }
       Actions actions =new Actions("Warehouse", "warehouse_id", "warehouse_address");
        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            actions.populate(GridView);
            actions.fillcategory(Search_comboBox);
        }

        private void btn_ADD_Warehouse_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_WarehouseID.Text, input_WarehouseAdress.Text };
           actions.ADD(GridView,actions,namesOfinputs);
        }

        private void btn_DELETE_Warehouse_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_WarehouseID.Text, input_WarehouseAdress.Text };
            actions.DELETE(GridView, actions, namesOfinputs[0]);
        }

        private void btn_EDIT_Warehouse_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_WarehouseID.Text, input_WarehouseAdress.Text };
            actions.EDIT(GridView, actions, namesOfinputs);
        }

        private void WarehouseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            input_WarehouseID.Text = GridView.SelectedRows[0].Cells[0].Value.ToString();
            input_WarehouseAdress.Text = GridView.SelectedRows[0].Cells[1].Value.ToString();
            
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
