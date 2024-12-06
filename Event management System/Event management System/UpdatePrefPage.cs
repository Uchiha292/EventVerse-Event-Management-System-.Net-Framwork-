using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        //Prefrence
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Confirm Button
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=HAMZA\\SQLEXPRESS;Initial Catalog=DBPROJECT;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string preference = textBox1.Text;

                string updateQuery = "UPDATE ATTENDEE SET ";

                // Only update fields that are not empty
                if (!string.IsNullOrEmpty(preference))
                    updateQuery += "EventPreferences = @EventPreferences, ";

                updateQuery = updateQuery.TrimEnd(',', ' ');

                // Change data of user whose UserId = loggedIn User's ID
                updateQuery += " WHERE AttendeeID = @AttendeeID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@EventPreferences", string.IsNullOrEmpty(preference) ? (object)DBNull.Value : preference);

                    //Logged in user's id
                    cmd.Parameters.AddWithValue("@AttendeeID", LoginPage.loggedInUserId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0 ? "Prefrence Updated!" : "Prefrence not updated");
                }
            }
        }
    }
}
