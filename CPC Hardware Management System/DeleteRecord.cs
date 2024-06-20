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
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CPC_Hardware_Management_System
{
    public partial class DeleteRecord : Form
    {
        //CONNECTION STRING
        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public DeleteRecord()
        {
            InitializeComponent();
            DataBlind();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }
        //DATA BLIND
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
        //SEARCH INFORMATION
        private void button4_Click(object sender, EventArgs e)
        {
            {
                DataBlind();
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
        }
        //DELETE INFORMATION
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete NewRecord where Ref_No = '"+int.Parse(cmbrefno.Text)+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information Delete Success.....");
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
    }

}
