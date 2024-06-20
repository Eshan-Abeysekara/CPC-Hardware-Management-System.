using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPC_Hardware_Management_System
{
    public partial class AddNewTechnicians : Form
    {
        public AddNewTechnicians()
        {
            InitializeComponent();
        }
        //CONNECTION STRING
        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Trust Server Certificate=True";

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtemfno.Clear();
            txttechnicianname.Clear();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewError addnewerror = new AddNewError();
            addnewerror.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewResolvingStatus addnewresolving = new AddNewResolvingStatus();
            addnewresolving.Show();
            this.Hide();
        }
        //ADD TECHNICIANS
        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con =  new SqlConnection(ConnectionString);

            string emfno = txtemfno.Text;
            string name = txttechnicianname.Text;

            con.Open();
            string Query = "insert into Technicians values ('"+emfno+"','"+name+"')";
            SqlCommand cmd = new SqlCommand(Query,con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Technician Adding Success....");

            Clear();
        }
    }
}

