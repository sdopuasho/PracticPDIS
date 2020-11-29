using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appforSDBD
{
    public partial class Вход : DesignerSDBD
    {
        public Вход()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Выберите пользователя");
            }
            if (comboBox1.Text == "Просмотр")
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
            if (comboBox1.Text == "Администрирование")
             {
                this.Hide();
                administrate f = new administrate();
                f.Show();
            }
            else
            {
                if (comboBox1.Text == "" || comboBox1.Text == "Просмотр" || comboBox1.Text == "Администрирование") { }
                else { MessageBox.Show("Пользователь не существует"); }
            }
            
            
        }

       
    }
}
