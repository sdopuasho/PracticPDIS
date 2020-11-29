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
    public partial class Form0 : Form
    {
        GroupBox prevBox;
        Color first = Color.Red;
        Color second = Color.Lime;
        int MaxTimerTime = 5;
        int CurrentTimerTime = 0;
        public Form0()
        {
            InitializeComponent();
            if(Program.name != null && Program.family != null)
            {
                panel2.Visible = true;
                label15.Text = Program.name + " " + Program.family;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            else
            {
                if (Program.name != null && Program.family != null)
                {
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Show();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Show();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Show();
            this.Hide();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            this.Show();
            this.Hide();
            a.ShowDialog();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            if (sender == label3) { label3.ForeColor = first; label5.ForeColor = second; }
            if (sender == label5) { label5.ForeColor = first; label3.ForeColor = second; }
            hideOthers((sender == label3) ? groupBox1 : groupBox2);
        }

        public void hideOthers(GroupBox box)
        {
            if (prevBox != null && prevBox == box)
            {
                box.Visible = !box.Visible;
                return;
            }
            prevBox = box;
            Controls.OfType<GroupBox>().ToList().ForEach(m => m.Visible = false);
            box.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {         
            string login = textBox2.Text;
            string password = textBox3.Text;
            // if (login.Length == 0 || password.Length == 0)
            MySqlConnection connection = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root; charset=utf8");
            connection.Open();
            MySqlCommand cmd4 = new MySqlCommand("SELECT `user`.`id` FROM user where `login` = '" + login + "' and `password` = '" + password + "'; ", connection);
            Program.id = Convert.ToInt32(cmd4.ExecuteScalar());
            if (login == "" || password == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else if(Program.id < 0) {
                MessageBox.Show("Пользователя не существует");
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT `user`.`status` FROM user where `login` = '" + login + "' and `password` = '" + password + "'; ", connection);
                MySqlCommand cmd2 = new MySqlCommand("SELECT `user`.`otchestvo` FROM user where `login` = '" + login + "' and `password` = '" + password + "'; ", connection);
                MySqlCommand cmd3 = new MySqlCommand("SELECT `user`.`name` FROM user where `login` = '" + login + "' and `password` = '" + password + "'; ", connection);
                Program.status = command.ExecuteScalar().ToString();
                Program.name = cmd3.ExecuteScalar().ToString();
                Program.family = cmd2.ExecuteScalar().ToString();
                if (Program.status == null)
                {
                    MessageBox.Show("Не правильно введён логин или пароль");
                }
                else
                {
                    int k;
                    this.Hide();
                    Form1 a = new Form1();
                    a.Show();
                    k = Program.status == "admin" ? 1 : 0;
                    if (k == 1)
                    {
                        MessageBox.Show("Привествую " + Program.status + "!");
                    }
                    else
                    {
                        MessageBox.Show("Добро пожаловать " + Program.name + ", " + Program.family + ".");
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 asd = new Form5();
            asd.ShowDialog();
            this.Show();

            if (Program.gl_reg_yn != true)
            {
                MessageBox.Show("Регистрация отменнена");
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
            }
            else
            {
                string login = textBox5.Text;
                string password = textBox4.Text;
                string repeatPassword = textBox6.Text;
                string fam = textBox9.Text;
                string nam = textBox7.Text;
                string otc = textBox8.Text;
                if (login.Length == 0 || password.Length == 0 || repeatPassword.Length == 0)
                {
                    MessageBox.Show("Заполните все поля");
                }
                else
                {
                    if (password != repeatPassword)
                    {
                        MessageBox.Show("Пароли не совпадают");
                    }
                    else
                    {
                        MySqlConnection connection = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root;; charset=utf8");
                        connection.Open();
                        MySqlCommand command = new MySqlCommand("SELECT COUNT(`user`.`status`) FROM gr671_adyu.user where `user`.`login` = '" + login + "' and `user`.`password` = '" + password + "'; ", connection);
                        int coundfFields = 0;
                        coundfFields = Convert.ToInt32(command.ExecuteScalar());
                        if (coundfFields == 1)
                        {
                            MessageBox.Show("Такой пользователь уже существует");
                        }
                        else
                        {
                            MySqlCommand command1 = new MySqlCommand("INSERT INTO `gr671_adyu`.`user`(`login`,`password`, `familiy`, `name`, `otchestvo`)" + " VALUES( '" + login + "' , '" + password + "', '" + fam + "', '" + nam + "', '" + otc + "' )", connection);
                            command1.ExecuteNonQuery();
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
                            textBox8.Text = "";
                            textBox9.Text = "";
                            MessageBox.Show("Регистрация прошла успешно");
                        }
                    }
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Visible = true;
            webBrowser1.Navigate("https://www.youtube.com/watch?v=BsNnpp2PgbI");
            //System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=BsNnpp2PgbI"); - так делать не надо 
        }

        private void Form0_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Visible = true;
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ATS-sqHumpQ");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label7.Text = "5";
            panel1.Visible = false;
            label7.Visible = true;
            label6.Visible = true;
            linkLabel1.Visible = false;
            webBrowser1.GoHome();
            linkLabel1.Text = "Пропустить";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTimerTime += 1;
            label7.Text = (MaxTimerTime - CurrentTimerTime).ToString();
            if (!(CurrentTimerTime >= MaxTimerTime)) return;
            label7.Visible = false;
            label6.Visible = false;
            linkLabel1.Visible = true;
            timer1.Stop();
            CurrentTimerTime = 0;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Program.family = null;
            Program.name = null;
            Program.id = 0;
            Program.status = null;
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void takeall()
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root; charset=utf8");
            con.Open();
            MySqlCommand coma = new MySqlCommand("", con);
            Program.filmid = Convert.ToInt32(coma.ExecuteScalar());
            if (Program.filmid < 0)
            {
                return;
            }
        }

    }
}
/*          MySqlConnection con = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `detective` FROM gr671_adyu.genres;", con);
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

            для отображения бд в DataGridView
 */
