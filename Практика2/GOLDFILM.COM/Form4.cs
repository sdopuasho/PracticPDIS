using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GOLDFILM.COM
{
    public partial class Form4 : Form0
    {
        public Form4()
        {
            InitializeComponent();
            if(Program.name != null)
            {
                textBox7.Text = Program.name;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string name = textBox7.Text;
            string mail = textBox8.Text;
            string tema = textBox8.Text;
            string text = textBox10.Text;
            string rating = comboBox1.Text;
            if (name.Length == 0 || mail.Length == 0 || tema.Length == 0 || text.Length == 0 || rating.Length == 0)
            {
                MessageBox.Show("Заполните все поля");
            }
            else if (Program.name != null || Program.family != null) 
            {
                MySqlConnection c = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root; charset=utf8");
                c.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `gr671_adyu`.`svyz`(`name`,`mail`,`tema`,`text`,`rating`,`id_user`)VALUES('"+ name + "', '" + mail + "', '" + tema + "', '" + text + "', '" + rating + "', " + Program.id + ");", c);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MySqlConnection c = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root; charset=utf8");
                c.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `gr671_adyu`.`svyz`(`name`,`mail`,`tema`,`text`,`rating`)VALUES('" + name + "', '" + mail + "', '" + tema + "', '" + text + "', '" + rating + "');", c);
                cmd.ExecuteNonQuery();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Visible = true;
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ivtNq8weJhk");
        }
    }
}
