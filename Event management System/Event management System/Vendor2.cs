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
    public partial class Vendor2 : Form
    {
        public Vendor2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Vendor4().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Vendor3().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Vendor5().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
