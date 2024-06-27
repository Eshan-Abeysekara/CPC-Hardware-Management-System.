using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace CPC_Hardware_Management_System
{
    public partial class AddNewResolvingStatus : Form
    {
        public AddNewResolvingStatus()
        {
            InitializeComponent();
        }
        //CONNECTION STRING
        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Trust Server Certificate=True";


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItem addnewitem = new AddNewItem();
            addnewitem.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewError addnewerror = new AddNewError();
            addnewerror.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewTechnicians addnewtechnicians = new AddNewTechnicians();
            addnewtechnicians.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtresolvingstatus.Clear();
        }

        //ADD RESOLVING STATUS
        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            string status = txtresolvingstatus.Text;

            con.Open();
            string Query = "insert into Resolving_Status values ('" + status + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Resolving Status Adding Success....");

            Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddNewItemBrand addnewitembrand = new AddNewItemBrand();
            addnewitembrand.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNewItemModel addnewitemmodel = new AddNewItemModel();
            addnewitemmodel.Show();
            this.Hide();
        }
    }
}
