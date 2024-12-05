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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new Admin1().ShowDialog();
        }

        private void labelTotalUsers_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin3().ShowDialog();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            new Vendor1().ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            new Organization1().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new LoginPage().Show();
        }
    }
}
