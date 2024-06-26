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
    public partial class ManufacturersForm : Form
    {
    

        public ManufacturersForm()
        {
            InitializeComponent();
        }
        Actions actions=new Actions("Manufacturers", "manufacturer_id", "manufacturer_name", "country", "city");
      
        private void btn_ADD_Manufacturers_Click(object sender, EventArgs e)
        {
         
            
            string[] namesOfinputs = { input_manufacturer_id.Text, input_manufacturer_name.Text, input_country.Text, input_city.Text };
            actions.ADD(GridView,actions,namesOfinputs);
        }

        private void btn_DELETE_Manufacturers_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_manufacturer_id.Text, input_manufacturer_name.Text, input_country.Text, input_city.Text };
            actions.DELETE(GridView, actions, namesOfinputs[0]);
        }

        private void btn_EDIT_Manufacturers_Click(object sender, EventArgs e)
        {
            string[] namesOfinputs = { input_manufacturer_id.Text, input_manufacturer_name.Text, input_country.Text, input_city.Text };
            actions.EDIT(GridView,actions,namesOfinputs);

        }


        private void ManufacturersForm_Load(object sender, EventArgs e)
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
            actions.Filter(GridView ,Search_comboBox,input_Search);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            actions.populate(GridView);
        }
    }
}
