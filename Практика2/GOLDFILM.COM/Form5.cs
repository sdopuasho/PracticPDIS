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
    public partial class Form5 : Form3
    {
        public Form5()
        {
            InitializeComponent();
            timer2.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.gl_reg_yn = true;
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button8.BackColor = Color.White;
            button8.Enabled = true;
            timer2.Stop();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.gl_reg_yn = false;
            this.Hide();
        }
    }
}
