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
    public partial class Organizer2 : Form
    {
        public Organizer2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Organizer3().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Organizer4().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Organization1().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Organizer10().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Organizer9().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Organizer6().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Organizer5().ShowDialog();
        }
    }
}
