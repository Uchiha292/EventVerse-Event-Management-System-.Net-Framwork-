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
    public partial class LoginPage : Form
    {
        //Storing loggedIn user's ID
        public static int loggedInUserId = -1;
        //Storing loggedIn user's type
        public static string loggedInUserType = "";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=HAMZA\\SQLEXPRESS;Initial Catalog=DBPROJECT;Integrated Security=True"))
            {
                conn.Open();

                string name = textBox1.Text;
                string pass = textBox2.Text;
                string userType = textBox3.Text;

                string query = "SELECT COUNT(*) FROM [USER] WHERE Name = @Name AND Password = @Password AND UserType = @UserType";

                using (SqlCommand cm = new SqlCommand(query, conn))
                {
                    cm.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = name });
                    cm.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar) { Value = pass });
                    cm.Parameters.Add(new SqlParameter("@UserType", SqlDbType.NVarChar) { Value = userType });

                    int result = (int)cm.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Login Successful");

                        // Getting UserID and UserType
                        query = "SELECT UserID, UserType FROM [USER] WHERE Name = @Name AND Password = @Password AND UserType = @UserType";

                        using (SqlCommand cm2 = new SqlCommand(query, conn))
                        {
                            cm2.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = name });
                            cm2.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar) { Value = pass });
                            cm2.Parameters.Add(new SqlParameter("@UserType", SqlDbType.NVarChar) { Value = userType });

                            using (SqlDataReader reader = cm2.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    loggedInUserId = reader.GetInt32(reader.GetOrdinal("UserID"));
                                    loggedInUserType = reader.GetString(reader.GetOrdinal("UserType"));
                                    panelPage();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }
                }
            }
        }


        //Showing pages respected to User Type
        private void panelPage()
        {
            if (loggedInUserType == "Attendee")
            {
                AttendeeMainPage attendeePage = new AttendeeMainPage();
                attendeePage.Show();
            }
            else if (loggedInUserType == "Admin")
            {
                Admin1 adminPage = new Admin1();
                adminPage.Show();
            }
            else if (loggedInUserType == "Organizer")
            {
                Organization1 orgPage = new Organization1();
                orgPage.Show();
            }
            else if (loggedInUserType == "Vendor/Sponsor" || loggedInUserType == "Vendor" || loggedInUserType == "Sponsor")
            {
                Vendor1 vendorPage = new Vendor1();
                vendorPage.Show();
            }
        }

        //Username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegisterPage signPage = new RegisterPage();
            signPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //UserType
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
