namespace Dydelfomania
{
    public partial class Form1 : Form
    {
        SETTINGS f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!GlobalVar.settingsexist)
            {
                f2 = new SETTINGS(this); GlobalVar.settingsexist=true;
            }
            Refresh();
            this.Hide();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dydelfing_Time f3 = new Dydelfing_Time(this);
            
            this.Hide();
            f3.Show();
        }
    }
}
