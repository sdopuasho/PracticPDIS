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
    public partial class Form1 : Form0
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Авторизуйтесь на сайте");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Visible = true;
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ivtNq8weJhk");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            linkLabel1.Visible = true;
            panel1.Visible = true;
            webBrowser1.Navigate("https://vk.com/coldfilm_ru");
            linkLabel1.Text = "Закрыть";
        }
    }
}
