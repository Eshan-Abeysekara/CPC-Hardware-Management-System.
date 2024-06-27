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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPC_Hardware_Management_System
{
    public partial class AddNewError : Form
    {
        public AddNewError()
        {
            InitializeComponent();
        }
        //CONNECTION STRING
        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Trust Server Certificate=True";


        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItem addnewitem = new AddNewItem();
            addnewitem.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txterror.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewResolvingStatus addnewresolving = new AddNewResolvingStatus();
            addnewresolving.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewTechnicians addnewtechnicians = new AddNewTechnicians();
            addnewtechnicians.Show();
            this.Hide();
        }


        //ADD ERROR
        private void button6_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(ConnectionString);

            string Error = txterror.Text;

            con.Open();
            string Query = "insert into Error values ('" + Error + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Adding Success....");

            Clear();
        }

        private void AddNewError_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNewItemBrand addnewitembrand = new AddNewItemBrand();
            addnewitembrand.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddNewItemModel addnewitemmodel = new AddNewItemModel();
            addnewitemmodel.Show();
            this.Hide();
        }
    }
}
