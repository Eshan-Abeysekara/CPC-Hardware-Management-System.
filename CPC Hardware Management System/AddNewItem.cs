﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Data.SqlClient;

namespace CPC_Hardware_Management_System
{
    public partial class AddNewItem : Form
    {
        public AddNewItem()
        {
            InitializeComponent();
        }
        //CONNECTION STRRING 
        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Trust Server Certificate=True";

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewError addnewerror = new AddNewError();
            addnewerror.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewResolvingStatus addresolvingstatus = new AddNewResolvingStatus();
            addresolvingstatus.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewTechnicians addnewtechnicians = new AddNewTechnicians();
            addnewtechnicians.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //CLEAR TEXTBOX
        public void Clear()
        {
            txtitemname.Clear();
            //txtitemmodel.Clear();
            //txtitembrand.Clear();
        }


        //ADD ITEM
        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            string name = txtitemname.Text;
            //string brand = txtitembrand.Text;
            //string model = txtitemmodel.Text;

            con.Open();
            string Query = "insert into Item values ('" + name + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Adding Success....");

            Clear();

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddNewError addnewerror = new AddNewError();
            addnewerror.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddNewResolvingStatus addnewresolving = new AddNewResolvingStatus();
            addnewresolving.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddNewTechnicians addnewtechnicians = new AddNewTechnicians();
            addnewtechnicians.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
