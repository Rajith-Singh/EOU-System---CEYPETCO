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
    public partial class add_members : Form
    {
        public add_members()
        {
            InitializeComponent();
        }

        private void moveImageBox(object sender)
        {
            GunaButton b = (GunaButton)sender;
            imageSlide.Location = new Point(b.Location.X + 35, b.Location.Y - 23);
            imageSlide.SendToBack();
        }

        private void m_btn_home_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void m_btn_member_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void m_btn_testing_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void m_btn_channelling_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void m_btn_spectacles_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void m_btn_logout_Click(object sender, EventArgs e)
        {

        }
    }
}
