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
    public partial class Organizer10 : Form
    {
        public Organizer10()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Organization1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Organizer2().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Organizer5().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Organizer6().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Organizer9().ShowDialog();
        }
    }
}
