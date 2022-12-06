using System.Threading;
using System.Threading.Tasks;
    

namespace ATMSystem15
{
    public partial class pin : Form
    {
        public pin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            if (comboBox1.SelectedIndex == 0)
            {
                //change language to English:
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

                this.RightToLeft = RightToLeft.No;
                this.ResumeLayout(false);

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //change the language to arabic: 
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
              //  this.Controls.Clear();
                InitializeComponent();  
            }
            else
            {
             
            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}