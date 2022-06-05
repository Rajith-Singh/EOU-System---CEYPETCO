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

        private void add_testing_details_Load(object sender, EventArgs e)
        {
            GetTestingDetails();
        }

        private void GetTestingDetails()
        {
            throw new NotImplementedException();
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
    }
}
