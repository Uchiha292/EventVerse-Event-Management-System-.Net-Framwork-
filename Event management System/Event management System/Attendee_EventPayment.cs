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
    public partial class Attendee_EventPayment : Form
    {
        public Attendee_EventPayment()
        {
            InitializeComponent();
        }

        private void EventDashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchEventsButton_Click(object sender, EventArgs e)
        {
            new SearchEventsPage().Show();
        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            new FeedbackPage().Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            new ProfilePage().Show();
        }
    }
}
