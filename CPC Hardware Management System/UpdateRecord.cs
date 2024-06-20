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
    public partial class UpdateRecord : Form
    {
        public UpdateRecord()
        {
            InitializeComponent();
            DataBlind();
        }

        //CONNECTION STRING

        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }
        // SEARCH DATA
        private void button4_Click(object sender, EventArgs e)
        {
            DataBlind();
            DataBlind1();
            DataBlind2();
            DataBlind3();
            DataBlind4();
            DataBlind5();
            DataBlind6();

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from NewRecord where Ref_No = '" + int.Parse(cmbrefno.Text) + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dateandtime.Text = reader.GetValue(1).ToString();
                txtuserepf.Text = reader.GetValue(2).ToString();
                txtusername.Text = reader.GetValue(3).ToString();
                cmblocation.Text = reader.GetValue(4).ToString();
                txtintercom.Text = reader.GetValue(5).ToString();
                cmbitem.Text = reader.GetValue(6).ToString();
                cmbbrand.Text = reader.GetValue(7).ToString();
                cmbmodel.Text = reader.GetValue(8).ToString();
                txtserialno.Text = reader.GetValue(9).ToString();
                txtassetno.Text = reader.GetValue(10).ToString();
                txtip.Text = reader.GetValue(11).ToString();
                txtetrno.Text = reader.GetValue(12).ToString();
                txtgatesheetno.Text = reader.GetValue(13).ToString();
                cmberror.Text = reader.GetValue(14).ToString();
                txtcarrierempno.Text = reader.GetValue(15).ToString();
                txtcarriername.Text = reader.GetValue(16).ToString();
                txtreceiverempno.Text = reader.GetValue(17).ToString();
                txtreceivername.Text = reader.GetValue(18).ToString();
                cmbtechnicianepfno.Text = reader.GetValue(19).ToString();
                cmbtechnicianname.Text = reader.GetValue(20).ToString();
                cmbresolvingstatus.Text = reader.GetValue(21).ToString();
                txtcompany.Text = reader.GetValue(22).ToString();
                returndatetime.Text = reader.GetValue(23).ToString();
                txtrempno.Text = reader.GetValue(24).ToString();
                txtrname.Text = reader.GetValue(25).ToString();
                txtcempno.Text = (reader.GetValue(26).ToString());
                txtcname.Text = reader.GetValue(27).ToString();
                receiveddatetime.Text = reader.GetValue(28).ToString();
            }
            con.Close();

        }

        //DATA BLINDING
        public void DataBlind()
        {

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Ref_No from NewRecord", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbrefno.Items.Clear();

            while (datareader.Read())
            {
                cmbrefno.Items.Add(datareader["Ref_No"].ToString());
            }
            con.Close();
        }
        public void DataBlind1()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Item_Name FROM Item", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbitem.Items.Clear();
            while (datareader.Read())
            {
                cmbitem.Items.Add(datareader["Item_Name"].ToString());
                //cmbbrand.Items.Add(datareader["Item_Brand"].ToString());
                //cmbmodel.Items.Add(datareader["Itrm_Model"].ToString());
            }
            con.Close();
        }
        public void DataBlind2()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Error from Error", con);
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
            SqlCommand cmd = new SqlCommand("select Resolving_Status from Resolving_Status", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbresolvingstatus.Items.Clear();
            while (datareader.Read())
            {
                cmbresolvingstatus.Items.Add(datareader["Resolving_Status"].ToString());
            }
            con.Close();
        }
        public void DataBlind5()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Item_Model from Item_Model", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbmodel.Items.Clear();
            while (datareader.Read())
            {
                //cmbitem.Items.Add(datareader["Item_Name"].ToString());
                cmbmodel.Items.Add(datareader["Item_Model"].ToString());
                //cmbmodel.Items.Add(datareader["Itrm_Model"].ToString());
            }
            con.Close();
        }
        public void DataBlind6()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Item_Brand from Item_Brand", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbbrand.Items.Clear();
            while (datareader.Read())
            {
                //cmbitem.Items.Add(datareader["Item_Name"].ToString());
                cmbbrand.Items.Add(datareader["Item_Brand"].ToString());
                //cmbmodel.Items.Add(datareader["Itrm_Model"].ToString());
            }
            con.Close();
        }

        // CLEAR TEXTBOX
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
            dateandtime.Text = DateTime.Now.ToString();
            returndatetime.Text = DateTime.Now.ToString();
            receiveddatetime.Text = DateTime.Now.ToString();
            txtcompany.Clear();
            txtrempno.Clear();
            txtrname.Clear();
            txtcempno.Clear();
            txtcname.Clear();
            cmbrefno.Text = string.Empty;
            cmblocation.Text = string.Empty;
            cmbitem.Text = string.Empty;
            cmbbrand.Text = string.Empty;
            cmbmodel.Text = string.Empty;
            cmberror.Text = string.Empty;
            cmbtechnicianepfno.Text = string.Empty;
            cmbtechnicianname.Text = string.Empty;
            cmbresolvingstatus.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // UPDATE DATA
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update NewRecord set " +
                "Date_and_Time=@dateandtime,"+
                "User_EPF=@userepf , User_Name=@username, Location=@userlocation," +
                "Inter_Com=@intercom, Item= @item, Brand=@brand," +
                "Model=@model, Serial_No=@serialno, Asset_No=@assetno, IP=@ip," +
                "ETR_No=@etrno, Gate_Sheet_No=@gatesheetno, Error=@error," +
                "Carrier_EMP_No=@carrierempno, Carrier_Name=@carriername," +
                "Receiver_EMP_NO=@receiverempno," +
                "Receiver_Name=@receivername, Technician_EPF_No=@technicianepfno," +
                "Technician_Name=@technicianname, Resolving_Status=@resolvingstatus," +
                "Company=@company, Return_Date_and_Time=@returndatetime, Receiver_EMP_No2=@rempno," +
                "Receiver_Name2=@rname, Carrier_EMP_No2=@cempno, Carrier_name2=@cname," +
                "Received_Date_and_Time=@receiveddatetime where Ref_No=@refno", con);
            cmd.Parameters.AddWithValue("@refno",cmbrefno.Text);
            cmd.Parameters.AddWithValue("@dateandtime", dateandtime.Value);
            cmd.Parameters.AddWithValue("@userepf", txtuserepf.Text);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@userlocation", cmblocation.Text);
            cmd.Parameters.AddWithValue("@intercom", txtintercom.Text);
            cmd.Parameters.AddWithValue("@item", cmbitem.Text);
            cmd.Parameters.AddWithValue("@brand", cmbbrand.Text);
            cmd.Parameters.AddWithValue("@model", cmbmodel.Text);
            cmd.Parameters.AddWithValue("@serialno", txtserialno.Text);
            cmd.Parameters.AddWithValue("@assetno", txtassetno.Text);
            cmd.Parameters.AddWithValue("@ip", txtip.Text);
            cmd.Parameters.AddWithValue("@etrno", txtetrno.Text);
            cmd.Parameters.AddWithValue("@gatesheetno", txtgatesheetno.Text);
            cmd.Parameters.AddWithValue("@error", cmberror.Text);
            cmd.Parameters.AddWithValue("@carrierempno", txtcarrierempno.Text);
            cmd.Parameters.AddWithValue("@carriername", txtcarriername.Text);
            cmd.Parameters.AddWithValue("@receiverempno", txtreceiverempno.Text);
            cmd.Parameters.AddWithValue("@receivername", txtreceivername.Text);
            cmd.Parameters.AddWithValue("@technicianepfno", cmbtechnicianepfno.Text);
            cmd.Parameters.AddWithValue("@technicianname", cmbtechnicianname.Text);
            cmd.Parameters.AddWithValue("@resolvingstatus", cmbresolvingstatus.Text);
            cmd.Parameters.AddWithValue("@company", txtcompany.Text);
            cmd.Parameters.AddWithValue("@returndatetime", returndatetime.Value);
            cmd.Parameters.AddWithValue("@rempno", txtrempno.Text);
            cmd.Parameters.AddWithValue("@rname", txtrname.Text);
            cmd.Parameters.AddWithValue("@cempno", txtcempno.Text);
            cmd.Parameters.AddWithValue("@cname", txtcname.Text);
            cmd.Parameters.AddWithValue("@receiveddatetime", receiveddatetime.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update is Success......");
;        }
    }
}
