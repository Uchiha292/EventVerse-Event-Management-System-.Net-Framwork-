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
    public partial class Vendor7 : Form
    {
        public Vendor7()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Vendor8().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Vendor9().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Vendor10().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Vendor6().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Vendor1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Vendor2().ShowDialog();
        }
    }
}
