using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CPC_Hardware_Management_System
{
    public partial class AddNewItemBrand : Form
    {
        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Trust Server Certificate=True";
        public AddNewItemBrand()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            string brand = txtitembrand.Text;
            //string brand = txtitembrand.Text;
            //string model = txtitemmodel.Text;

            con.Open();
            string Query = "insert into Item_Brand values ('" + brand + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Brand Adding Success....");

            Clear();
        }
        public void Clear()
        {
            txtitembrand.Clear();
            //txtitemmodel.Clear();
            //txtitembrand.Clear();
        }
    }
}
