using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Data.SqlClient;

namespace EOU
{
    public partial class add_testing_details : Form
    {
        public add_testing_details()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NTKI9H5\SQLEXPRESS;Initial Catalog=EOU;Integrated Security=True");

        private void add_testing_details_Load(object sender, EventArgs e)
        {
            GetTestingDetails();
        }

        private void GetTestingDetails()
        {
            SqlCommand cmd = new SqlCommand("Select T.epfno, T.bill_desc, T.date, T.testing_charges, E.name from Testing T, emp E where T.epfno = E.epfno", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            testing_grid.DataSource = dt;

        }

        public void updateBalance()
        {
            SqlCommand cmd = new SqlCommand("update emp set testing_allowance=testing_allowance - @testing_charges where epfno = @epfno ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@epfno", testing_epf_no.Text);
            cmd.Parameters.AddWithValue("@testing_charges", testing_value.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void moveImageBoxT(object sender)
        {
            GunaButton b = (GunaButton)sender;
            imageSlideT.Location = new Point(b.Location.X + 35, b.Location.Y - 23);
            imageSlideT.SendToBack();
        }

        private void t_btn_home_Click(object sender, EventArgs e)
        {
            moveImageBoxT(sender);
        }

        private void t_btn_member_Click(object sender, EventArgs e)
        {
            moveImageBoxT(sender);
        }

        private void t_btn_testing_Click(object sender, EventArgs e)
        {
            moveImageBoxT(sender);
        }

        private void t_btn_channelling_Click(object sender, EventArgs e)
        {
            moveImageBoxT(sender);
        }

        private void t_btn_spectacles_Click(object sender, EventArgs e)
        {
            moveImageBoxT(sender);
        }

        private void t_btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void channelling_calc_Click(object sender, EventArgs e)
        {
            if (IsValid()) 
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Testing VALUES (@epfno, @bill_desc, @date, @testing_charges)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@epfno", testing_epf_no.Text);
                cmd.Parameters.AddWithValue("@bill_desc", bill_description.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(testing_date.Text));
                cmd.Parameters.AddWithValue("@testing_charges", testing_value.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New testing record is successfully added","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTestingDetails();
                updateBalance();
            }
        }

        private bool IsValid()
        {
            if (testing_epf_no.Text == string.Empty)
            {
                MessageBox.Show("EPF Number is required","Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
