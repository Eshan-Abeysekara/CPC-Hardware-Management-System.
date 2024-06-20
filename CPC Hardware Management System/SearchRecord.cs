using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CPC_Hardware_Management_System
{
    public partial class SearchRecord : Form
    {
        //CONNECTION STRING
        string ConnectionString = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public SearchRecord()
        {
            InitializeComponent();

        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            DGV();
        }

        //DATA BLINDING
        public void DataBlind1()
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
            SqlCommand cmd = new SqlCommand("select Serial_No from NewRecord", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbserialno.Items.Clear();
            while (datareader.Read())
            {
                cmbserialno.Items.Add(datareader["Serial_No"].ToString());
            }
            con.Close();
        }
        public void DataBlind6()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Asset_No from NewRecord", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            cmbassetno.Items.Clear();
            while (datareader.Read())
            {
                cmbassetno.Items.Add(datareader["Asset_No"].ToString());
            }
            con.Close();
        }

        public void Clear()
        {
            cmbrefno.Text = string.Empty;
            dateandtime1.Format = DateTimePickerFormat.Custom; 
            dateandtime1.Checked = false;
            dateandtime2.Format = DateTimePickerFormat.Custom;
            dateandtime2.Checked = false;
            cmblocation.Text = string.Empty;
            cmberror.Text = string.Empty;
            cmbassetno.Text = string.Empty;
            cmbserialno.Text = string.Empty;
            cmbresolvingstatus.Text = string.Empty;
        }


        public void DGV()
        {
            dataGridView1.DataSource = "Data Source=DESKTOP-43NLUQ4;Initial Catalog=CPC_HardwareDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            dataGridView1.Refresh();
        }

        private void SearchRecord_Load(object sender, EventArgs e)
        {
            DataBlind1();
            DataBlind2();
            DataBlind4();
            DataBlind5();
            DataBlind6();
            Clear();
        }


        public async Task ABC()
        {

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string sql = @"SELECT * FROM NewRecord 
                       WHERE (@refNo IS NULL OR Ref_No LIKE @refNo) 
                       AND (@location IS NULL OR Location LIKE @location) 
                       AND (@serialNo IS NULL OR Serial_No LIKE @serialNo) 
                       AND (@assetNo IS NULL OR Asset_No LIKE @assetNo) 
                       AND (@error IS NULL OR Error LIKE @error) 
                       AND (@resolvingStatus IS NULL OR Resolving_Status LIKE @resolvingStatus)
                       
                       AND 

                       ((@start IS NULL AND @end IS NULL) OR Date_and_Time BETWEEN @start AND @end)";



                using (SqlCommand cmd = new SqlCommand(sql, con))
                {

                    cmd.Parameters.AddWithValue("@start", dateandtime1.Checked ? (object)dateandtime1.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@end", dateandtime2.Checked ? (object)dateandtime2.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@refNo", string.IsNullOrEmpty(cmbrefno.Text) ? (object)DBNull.Value : "%" + cmbrefno.Text + "%");
                    cmd.Parameters.AddWithValue("@location", string.IsNullOrEmpty(cmblocation.Text) ? (object)DBNull.Value : "%" + cmblocation.Text + "%");
                    cmd.Parameters.AddWithValue("@serialNo", string.IsNullOrEmpty(cmbserialno.Text) ? (object)DBNull.Value : "%" + cmbserialno.Text + "%");
                    cmd.Parameters.AddWithValue("@assetNo", string.IsNullOrEmpty(cmbassetno.Text) ? (object)DBNull.Value : "%" + cmbassetno.Text + "%");
                    cmd.Parameters.AddWithValue("@error", string.IsNullOrEmpty(cmberror.Text) ? (object)DBNull.Value : "%" + cmberror.Text + "%");
                    cmd.Parameters.AddWithValue("@resolvingStatus", string.IsNullOrEmpty(cmbresolvingstatus.Text) ? (object)DBNull.Value : "%" + cmbresolvingstatus.Text + "%");

                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
        }




        private void cmbresolvingstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGV();
            ABC();
        }

        private void dateandtime1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateandtime1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateandtime2_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}