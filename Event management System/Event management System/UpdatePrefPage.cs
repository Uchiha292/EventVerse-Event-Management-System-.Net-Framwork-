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
    public partial class UpdatePrefPage : Form
    {
        public UpdatePrefPage()
        {
            InitializeComponent();
        }

        private void UpdatePrefPage_Load(object sender, EventArgs e)
        {

        }

        private void EventDashboardButton_Click(object sender, EventArgs e)
        {
            AttendeeMainPage mainPage = new AttendeeMainPage();
            mainPage.Show();
        }

        private void SearchEventsButton_Click(object sender, EventArgs e)
        {
            SearchEventsPage searchPage = new SearchEventsPage();
            searchPage.Show();
        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            FeedbackPage feedPage = new FeedbackPage();
            feedPage.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
        }
    }
}
