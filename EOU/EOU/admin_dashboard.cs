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

namespace EOU
{
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }

        private void moveImageBox(object sender)
        {
            GunaButton b = (GunaButton)sender;
            imageSlide.Location = new Point(b.Location.X + 35, b.Location.Y - 23);
            imageSlide.SendToBack();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void btn_testing_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void btn_channelling_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void btn_spectacles_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void imageSlide_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }
    }
}
