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
            tableLayoutPanel1.BackColor = Color.White;

            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.ColumnCount = 3;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(Color.Black)) // You can change the color of the borders
            {
                // Calculate the width and height of each cell
                int totalWidth = tableLayoutPanel1.ClientSize.Width;
                int totalHeight = tableLayoutPanel1.ClientSize.Height;

                int rowCount = tableLayoutPanel1.RowCount;
                int colCount = tableLayoutPanel1.ColumnCount;

                // Draw horizontal and vertical lines to show the cell boundaries
                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        // Calculate the bounds of each cell
                        int x = (totalWidth / colCount) * col;
                        int y = (totalHeight / rowCount) * row;
                        int cellWidth = totalWidth / colCount;
                        int cellHeight = totalHeight / rowCount;

                        // Draw a rectangle around the cell
                        e.Graphics.DrawRectangle(borderPen, x, y, cellWidth, cellHeight);
                    }
                }
            }
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
    }
}
