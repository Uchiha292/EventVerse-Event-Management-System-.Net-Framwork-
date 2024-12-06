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
    public partial class AttendeeMainPage : Form
    {
        public AttendeeMainPage()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FeedbackPage feedPage = new FeedbackPage();
            feedPage.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            SearchEventsPage searchPage = new SearchEventsPage();
            searchPage.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Download_CheckInPage checkInPage = new Download_CheckInPage();
            checkInPage.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EventDashboardLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AttendeeMainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPROJECTDataSet1.ATTENDEE_EVENT' table. You can move, or remove it, as needed.
            this.aTTENDEE_EVENTTableAdapter.Fill(this.dBPROJECTDataSet1.ATTENDEE_EVENT);

        }
    }
}
