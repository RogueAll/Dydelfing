using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dydelfomania
{
    public partial class SETTINGS : Form
    {

        Form1 Main;
        public SETTINGS(Form1 form1)
        {

            Main = form1;    
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { GlobalVar.Krokodyl = 1; } else { GlobalVar.Krokodyl = 0; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVar.width= Int32.Parse(textBox1.Text);
            GlobalVar.dydelf= Int32.Parse(textBox2.Text);
            GlobalVar.pracz= Int32.Parse(textBox3.Text);
            GlobalVar.height= Int32.Parse(textBox4.Text);

            Main.Show();
            this.Hide();
        }
    }
}
