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
    public partial class ZZZ : Form
    {
        public ZZZ()
        {
            InitializeComponent();
            groupBox1.DataBindings.Add("Visible", button1, "Visible");
            groupBox2.DataBindings.Add("Visible", label5, "Visible");
        }
    }
}
