using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOLDFILM.COM
{
    public partial class Form6 : Form1
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            this.Show();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            this.Show();
            this.Hide();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            this.Show();
            this.Hide();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            this.Show();
            this.Hide();
            a.ShowDialog();
        }
    }
}
