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
    public partial class Vendor1 : Form
    {
        public Vendor1()
        {
            InitializeComponent();

        
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Profile page.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
