using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTube
{
    public partial class Mainapp : Form
    {
        public Mainapp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainapp sp = new Mainapp();
            sp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gaming sp = new Gaming();
            sp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Music sp = new Music();
            sp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
