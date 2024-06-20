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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            NewRecord newrecord = new NewRecord();
            newrecord.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRecord updaterecord = new UpdateRecord();
            updaterecord.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchRecord searchrecord = new SearchRecord();
            searchrecord.Show();
            this.Hide();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            DeleteRecord deleterecord = new DeleteRecord();
            deleterecord.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
