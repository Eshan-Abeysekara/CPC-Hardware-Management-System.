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
    public partial class NewRecord : Form
    {
        public NewRecord()
        {
            InitializeComponent();
            
        }
        //CONNECTION STRING
        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //CLEAR TEXTBOX
        public void Clear()
        {
            
            txtuserepf.Clear();
            txtusername.Clear();
            txtintercom.Clear();
            txtserialno.Clear();
            txtassetno.Clear();
            txtip.Clear();
            txtetrno.Clear();
            txtgatesheetno.Clear();
            txtcarrierempno.Clear();
            txtcarriername.Clear();
            txtreceiverempno.Clear();
            txtreceivername.Clear();
            dateandtime.Format = DateTimePickerFormat.Custom;
            dateandtime.Text = DateTime.Now.ToString();
            returndatetime.Format = DateTimePickerFormat.Custom;
            returndatetime.Checked = false;
            receiveddatetime.Format = DateTimePickerFormat.Custom;
            receiveddatetime.Checked = false;
            txtcompany.Clear();
            txtrempno.Clear();
            txtrname.Clear();
            txtcempno.Clear();
            txtcname.Clear();
            cmbtechnicianepfno.Text = string.Empty;
            cmbtechnicianname.Text = string.Empty;
            cmbresolvingstatus.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        //ADD DATA
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "insert into NewRecord values (@dateandtime,@userepf,@username,@userlocation,@intercom,@item,@brand,@model,@serialno,@assetno,@ip,@etrno,@gatesheetno,@error,@carrierempno,@carriername,@receiverempno,@receivername,@technicianepfno,@technicianname,@resolvingstatus,@company,@returndatetime,@rempno,@rname,@cempno,@cname,@receiveddatetime)";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@dateandtime",dateandtime.Value);
            cmd.Parameters.AddWithValue("@userepf",txtuserepf.Text);
            cmd.Parameters.AddWithValue("@username",txtusername.Text);
            cmd.Parameters.AddWithValue("@userlocation", cmblocation.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@intercom",txtintercom.Text);
            cmd.Parameters.AddWithValue("@item", cmbitem.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@brand", cmbbrand.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@model", cmbmodel.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@serialno",txtserialno.Text);
            cmd.Parameters.AddWithValue("@assetno",txtassetno.Text);
            cmd.Parameters.AddWithValue("@ip",txtip.Text);
            cmd.Parameters.AddWithValue("@etrno",txtetrno.Text);
            cmd.Parameters.AddWithValue("@gatesheetno", txtgatesheetno.Text);
            cmd.Parameters.AddWithValue("@error", cmberror.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@carrierempno", txtcarrierempno.Text);
            cmd.Parameters.AddWithValue("@carriername", txtcarriername.Text);
            cmd.Parameters.AddWithValue("@receiverempno", txtreceiverempno.Text);
            cmd.Parameters.AddWithValue("@receivername", txtreceivername.Text);
            cmd.Parameters.AddWithValue("@technicianepfno", cmbtechnicianepfno.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@technicianname", cmbtechnicianname.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@resolvingstatus", cmbresolvingstatus.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@company", txtcompany.Text);
            cmd.Parameters.AddWithValue("@returndatetime", returndatetime.Value);
            cmd.Parameters.AddWithValue("@rempno", txtrempno.Text);
            cmd.Parameters.AddWithValue("@rname", txtrname.Text);
            cmd.Parameters.AddWithValue("@cempno",txtcempno.Text);
            cmd.Parameters.AddWithValue("@cname",txtcname.Text);
            cmd.Parameters.AddWithValue("@receiveddatetime", receiveddatetime.Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Success....");
            con.Close();
            Clear();
        }
        

        private void NewRecord_Load(object sender, EventArgs e)
        {
            DataBlind1();          
            DataBlind2();
            DataBlind3();
            DataBlind4();
            Clear();    
        }

        //DATA BLINDING
        public void DataBlind1()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Item_Name,Item_Brand,Itrm_Model from Item", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbitem.Items.Clear();
            while (datareader.Read())
            {
                cmbitem.Items.Add(datareader["Item_Name"].ToString());
                cmbbrand.Items.Add(datareader["Item_Brand"].ToString());
                cmbmodel.Items.Add(datareader["Itrm_Model"].ToString());
            }
            con.Close();
        }
        
        public void DataBlind2()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Error from Error",con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmberror.Items.Clear();

            while (datareader.Read())
            {
                cmberror.Items.Add(datareader["Error"].ToString());
            }
            con.Close();
        }
        public void DataBlind3()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select EMF_No,Technicians_Name from Technicians", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbtechnicianepfno.Items.Clear();
            cmbtechnicianname.Items.Clear();

            while (datareader.Read())
            {
                cmbtechnicianepfno.Items.Add(datareader["EMF_No"].ToString());
                cmbtechnicianname.Items.Add(datareader["Technicians_Name"].ToString());
            }
            con.Close();
        }
        public void DataBlind4()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Resolving_Status from Resolving_Status",con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbresolvingstatus.Items.Clear();
            while (datareader.Read())
            {
                cmbresolvingstatus.Items.Add(datareader["Resolving_Status"].ToString());
            }
            con.Close();
        }

    }
}
