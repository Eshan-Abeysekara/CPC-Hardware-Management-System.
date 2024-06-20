using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPC_Hardware_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Clear();
        }

        public void Clear()
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //LOGIN 
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            Admin admin = new Admin();
            User user = new User();

            if (username == "Admin" && password == "Admin123")
            {
                admin.Show();
                this.Hide();
            }
            else if (username == "User" && password == "User123")
            {
                user.Show();
                this.Hide();
            }
            else if (username == "" && password == "")
            {
                MessageBox.Show("Enter User Name and Password");
            }
            else
            {
                MessageBox.Show("Username or Password incorrect");
                Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
