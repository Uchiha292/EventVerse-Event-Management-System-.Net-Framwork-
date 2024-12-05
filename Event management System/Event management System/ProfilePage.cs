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
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            ManageInfoPage mngInfoPage = new ManageInfoPage();
            mngInfoPage.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PastEventsPage pastEvPage = new PastEventsPage();
            pastEvPage.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UpdatePrefPage upPrefPage = new UpdatePrefPage();
            upPrefPage.Show();
        }

        private void EventDashboardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
