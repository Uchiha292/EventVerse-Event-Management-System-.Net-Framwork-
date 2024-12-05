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

namespace Event_management_System
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        //Full Name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Email
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Password
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Sign up Button
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=HAMZA\\SQLEXPRESS;Initial Catalog=DBPROJECT;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string fullName = textBox1.Text;
                string email = textBox3.Text;
                string phoneNo = textBox5.Text;
                string address = textBox7.Text;
                string password = textBox4.Text;
                string confirmPassword = textBox2.Text;
                string userType = textBox6.Text;

                // Validate UserType
                if (!new[] { "Attendee", "Organizer", "Admin", "Vendor/Sponsor" }.Contains(userType))
                {
                    MessageBox.Show("Invalid User Type. Please Select: Attendee, Organizer, Admin, Vendor/Sponsor");
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Password doesnt match");
                    return;
                }

                // SQL Query
                string query = "INSERT INTO [USER] (Name, Email, Password, PhoneNo, Address, UserType) " +
                               "VALUES (@Name, @Email, @Password, @PhoneNo, @Address, @UserType)" +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@UserType", userType);

                    //Getting UserID
                    int userId = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userId > 0)
                    {
                        string insertTableQuery = "";

                        if (userType == "Attendee")
                        {
                            insertTableQuery = "INSERT INTO ATTENDEE (AttendeeID) VALUES (@UserID)";
                        }
                        else if (userType == "Organizer")
                        {
                            insertTableQuery = "INSERT INTO ORGANIZER (OrganizerID) VALUES (@UserID)";
                        }
                        else if (userType == "Vendor/Sponsor" || userType == "Vendor" || userType == "Sponsor")
                        {
                            insertTableQuery = "INSERT INTO SERVICE_PROVIDER (ProviderID) VALUES (@UserID)";
                        }

                        if (!string.IsNullOrEmpty(insertTableQuery))
                        {
                            using (SqlCommand cm = new SqlCommand(insertTableQuery, conn))
                            {
                                cm.Parameters.AddWithValue("@UserID", userId);

                                int rowsAffected = cm.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Registration Done!");
                                }
                                else
                                {
                                    MessageBox.Show("Registration Failed!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed!");
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        //Contact#
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //Confirm Password
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        //User Type
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        
        //Address
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
