using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GOLDFILM.COM
{
    public partial class Form2 : Form0
    {
        Label v = new Label();
        public Form2()
        {
            InitializeComponent();
            if (Program.name != null)
            {
                button11.Visible = true;
            }
            else
            {
                button11.Visible = false;
            }
                
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Visible = true;
            webBrowser1.Navigate("https://www.youtube.com/watch?v=-VYnM2V-ic0");
        }

        private void tabl(object sender, EventArgs e)
        {
            
                v = (Label)sender;
                string search = v.Name;
                MySqlConnection con = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root; charset=utf8");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT `films`.`name`, `films`.`description`, `films`.`year`  FROM gr671_adyu.genresfilms inner join `gr671_adyu`.`films` on `genresfilms`.`id_film` = `films`.`id` inner join `gr671_adyu`.`genres` on `genresfilms`.`id_genre` = `genres`.`id` where `genres`.`name` = '" + search + "'; ", con);
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                bindingSource1.DataSource = dt;
                panel4.Visible = true;

                selectedforbd();
            
        }

        private void tabls(object sender, EventArgs e)
        {
            
                v = (Label)sender;
                string search = v.Name;
                MySqlConnection con = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root; charset=utf8");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT `films`.`name`, `films`.`description`, `films`.`year`, `films`.`picture`  FROM gr671_adyu.countryfilms inner join `gr671_adyu`.`countrylist` on `countryfilms`.`id_country` = `countrylist`.`id` inner join `gr671_adyu`.`films` on `countryfilms`.`id_film` = `films`.`id` where `countrylist`.`country_name` = '" + search + "'; ", con);
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                bindingSource1.DataSource = dt;
                panel4.Visible = true;
                selectedforbd();
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void selectedforbd()
        {
            tx1.DataBindings.Clear();
            tx2.DataBindings.Clear();
            tx13.DataBindings.Clear();
            this.tx1.DataBindings.Add(new Binding("Text", bindingSource1, "name"));
            this.tx2.DataBindings.Add(new Binding("Text", bindingSource1, "year"));
            this.tx13.DataBindings.Add(new Binding("Text", bindingSource1, "description"));
            takeid();
            MySqlConnection con = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root; charset=utf8");
            con.Open();
            MySqlCommand coma = new MySqlCommand("SELECT picture FROM gr671_adyu.films where `name` LIKE '" + tx1.Text + "';", con);
            string abc = Convert.ToString(coma.ExecuteScalar());
            pictureBox1.Image = Bitmap.FromFile(abc);
        }


        private void button10_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
            takeid();
            selectedforbd();
        }
      

        private void button8_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
            takeid();
            selectedforbd();
        }
       

        private void label18_Click(object sender, EventArgs e) => panel4.Visible = false;

        private void button11_Click(object sender, EventArgs e)
        {
            string absd = tx13.Text;
            MySqlConnection con = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root; charset=utf8");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `gr671_adyu`.`favoritefilms` (`id_user`, `id_film`) VALUES (" + Program.id + ", " + Program.filmid +"); ", con);
            cmd.ExecuteNonQuery();
        }

        private void takeid()
        { 
            MySqlConnection con = new MySqlConnection("Server = localhost; database = gr671_adyu; UID = root; charset=utf8");
            con.Open();
            MySqlCommand coma = new MySqlCommand("SELECT id FROM gr671_adyu.films where `name` LIKE '" + tx1.Text + "';", con);
            Program.filmid = Convert.ToInt32(coma.ExecuteScalar());
            if (Program.filmid < 0)
            {
                return;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
