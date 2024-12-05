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
    public partial class Vendor8 : Form
    {
        public Vendor8()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Vendor7().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Vendor1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Vendor2().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Vendor6().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Vendor7().ShowDialog();
        }
    }
}
