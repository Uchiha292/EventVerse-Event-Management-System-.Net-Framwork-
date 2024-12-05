using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Event_management_System
{
    public partial class Admin8 : Form
    {
        public Admin8()
        {
            InitializeComponent();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignRoles_Click(object sender, EventArgs e)
        {
            new Admin2().ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            new Main().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Admin6().ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            new Admin5().ShowDialog();
        }
    }
}
