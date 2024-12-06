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
    public partial class SearchEventsPage : Form
    {
        public SearchEventsPage()
        {
            InitializeComponent();
        }

        private void SearchEventsPage_Load(object sender, EventArgs e)
        {
            LoadEvents();
            AddBookEventColumn();
        }

        //Search text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim();
            LoadFilteredEvents(searchQuery);
        }

        private void LoadFilteredEvents(string searchQuery)
        {
            string connString = "Data Source=HAMZA\\SQLEXPRESS;Initial Catalog=DBPROJECT;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // SQL query searching Title or Category
                    string query = @"SELECT Title, Catery, Description, Location, StartDate, EndDate 
                             FROM EVENTS 
                             WHERE Title LIKE @SearchQuery OR Catery LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable filteredEventsTable = new DataTable();
                            adapter.Fill(filteredEventsTable);

                            dataGridView1.DataSource = filteredEventsTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering events: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEvents()
        {
            string connString = "Data Source=HAMZA\\SQLEXPRESS;Initial Catalog=DBPROJECT;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT Title, Catery, Description, Location, StartDate, EndDate FROM EVENTS";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable eventsTable = new DataTable();
                            adapter.Fill(eventsTable);

                            dataGridView1.DataSource = eventsTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Adding Book Event Column
        private void AddBookEventColumn()
        {
            if (!dataGridView1.Columns.Contains("BookEvent"))
            {
                var bookEventColumn = new DataGridViewLinkColumn
                {
                    HeaderText = "Book Event",
                    Text = "Book",
                    UseColumnTextForLinkValue = true,
                    Name = "BookEvent",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dataGridView1.Columns.Add(bookEventColumn);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "BookEvent")
            {
                Attendee_EventPayment bookEvent = new Attendee_EventPayment();
                bookEvent.Show();
            }
        }



        //Attendee Main Page Link
        private void label2_Click(object sender, EventArgs e)
        {
            AttendeeMainPage mainPage = new AttendeeMainPage();
            mainPage.Show();
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