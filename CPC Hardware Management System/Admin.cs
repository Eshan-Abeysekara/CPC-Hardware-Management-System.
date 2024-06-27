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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
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
            AddNewResolvingStatus addnewresolvingstatus = new AddNewResolvingStatus();
            addnewresolvingstatus.Show();
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
            AddNewItemBrand addnewitembrand = new AddNewItemBrand();
            addnewitembrand.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNewItemModel addnewitemmodel = new AddNewItemModel();
            addnewitemmodel.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
