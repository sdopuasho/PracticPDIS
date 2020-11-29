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
    public partial class Form3 : Form0
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Visible = true;
            webBrowser1.Navigate("https://www.youtube.com/watch?v=yPEneKJK2V4");
        }
    }
}
