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
namespace appforSDBD
{
    public partial class Form1 : DesignerSDBD
    {
        public Form1()
        {   
           
            InitializeComponent();
            /*
           MySqlConnection con = new MySqlConnection("Server = localhost; Database = ceh; Uid = root;");
           con.Open();
           MySqlCommand com = new MySqlCommand(",con");
           MySqlDataAdapter adp = new MySqlDataAdapter(com);
           DataTable tabl = new DataTable();
           adp.Fill(tabl);
           dataGridView1.DataSource = tabl;
           */
            /*
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = ceh; Uid = root;");
            con.Open();
            MySqlCommand com = new MySqlCommand(",con");
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable tabl = new DataTable();
            adp.Fill(tabl);
            dataGridView1.DataSource = tabl;
            */
            /*
           MySqlConnection con = new MySqlConnection("Server = localhost; Database = ceh; Uid = root;");
           con.Open();
           MySqlCommand com = new MySqlCommand(",con");
           MySqlDataAdapter adp = new MySqlDataAdapter(com);
           DataTable tabl = new DataTable();
           adp.Fill(tabl);
           dataGridView1.DataSource = tabl;
           */
            /*
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = ceh; Uid = root;");
            con.Open();
            MySqlCommand com = new MySqlCommand(",con");
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable tabl = new DataTable();
            adp.Fill(tabl);
            dataGridView1.DataSource = tabl;
            */
            /*
           MySqlConnection con = new MySqlConnection("Server = localhost; Database = ceh; Uid = root;");
           con.Open();
           MySqlCommand com = new MySqlCommand(",con");
           MySqlDataAdapter adp = new MySqlDataAdapter(com);
           DataTable tabl = new DataTable();
           adp.Fill(tabl);
           dataGridView1.DataSource = tabl;
           */
            /*
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = ceh; Uid = root;");
            con.Open();
            MySqlCommand com = new MySqlCommand(",con");
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable tabl = new DataTable();
            adp.Fill(tabl);
            dataGridView1.DataSource = tabl;
            */
            /*
           MySqlConnection con = new MySqlConnection("Server = localhost; Database = ceh; Uid = root;");
           con.Open();
           MySqlCommand com = new MySqlCommand(",con");
           MySqlDataAdapter adp = new MySqlDataAdapter(com);
           DataTable tabl = new DataTable();
           adp.Fill(tabl);
           dataGridView1.DataSource = tabl;
           */
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Вход s = new Вход();
            s.Show();
            this.Hide();
        }
    }
}
