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
    public partial class AddNewItemModel : Form
    {
        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Trust Server Certificate=True";
        public AddNewItemModel()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            string model = txtitemmodel.Text;
            //string brand = txtitembrand.Text;
            //string model = txtitemmodel.Text;

            con.Open();
            string Query = "insert into Item_Model values ('" + model + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Model Adding Success....");

            Clear();
        }
        public void Clear()
        {
            txtitemmodel.Clear();
            //txtitemmodel.Clear();
            //txtitembrand.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItem addnewitem = new AddNewItem();
            addnewitem.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewError addnewerror = new AddNewError();
            addnewerror.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewResolvingStatus addnewresolving = new AddNewResolvingStatus();
            addnewresolving.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewTechnicians addnewtechnician = new AddNewTechnicians();
            addnewtechnician.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
