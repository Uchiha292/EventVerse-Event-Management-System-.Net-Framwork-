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
    public partial class Download_CheckInPage : Form
    {
        public Download_CheckInPage()
        {
            InitializeComponent();
        }

        private void EventDashboardLabel_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            new SearchEventsPage().Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FeedbackPage().Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            new ProfilePage().Show();
        }
    }
}
