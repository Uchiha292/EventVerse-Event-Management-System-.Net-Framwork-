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
    public partial class ManageInfoPage : Form
    {
        public ManageInfoPage()
        {
            InitializeComponent();
        }

        private void EventDashboardButton_Click(object sender, EventArgs e)
        {

        }

        //Name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Email
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Contact
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //Password
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //Confirm Password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Confirm Change Button
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=HAMZA\\SQLEXPRESS;Initial Catalog=DBPROJECT;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string name = textBox1.Text;
                string email = textBox3.Text;
                string contact = textBox5.Text;
                string password = textBox4.Text;
                string confirmPassword = textBox2.Text;

                if (!string.IsNullOrEmpty(password) && password != confirmPassword)
                {
                    MessageBox.Show("Password doesnt match");
                    return;
                }

                string updateQuery = "UPDATE [User] SET ";

                // Only update fields that are not empty
                if (!string.IsNullOrEmpty(name))
                    updateQuery += "Name = @Name, ";
                if (!string.IsNullOrEmpty(email))
                    updateQuery += "Email = @Email, ";
                if (!string.IsNullOrEmpty(contact))
                    updateQuery += "Contact = @Contact, ";
                if (!string.IsNullOrEmpty(password))
                    updateQuery += "Password = @Password, ";

                updateQuery = updateQuery.TrimEnd(',', ' ');

                // Change data of user whose UserId = loggedIn User's ID
                updateQuery += " WHERE UserId = @UserId";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", string.IsNullOrEmpty(name) ? (object)DBNull.Value : name);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                    cmd.Parameters.AddWithValue("@Contact", string.IsNullOrEmpty(contact) ? (object)DBNull.Value : contact);
                    cmd.Parameters.AddWithValue("@Password", string.IsNullOrEmpty(password) ? (object)DBNull.Value : password);

                    //Logged in user's id
                    cmd.Parameters.AddWithValue("@UserId", LoginPage.loggedInUserId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0 ? "Changes Done!" : "Changes not done, some issue in entered data");
                }
            }
        }
    }
}
