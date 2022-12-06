using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSystem15
{
    public partial class mainList : Form
    {
        public mainList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewBalance l1 = new viewBalance();
            l1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            amount m = new amount();
            m.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            transfer t3 = new transfer();
            t3.Show();
            this.Close();
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
               // this.Controls.Clear();
                InitializeComponent();
            }
            else
            {

            }
        }
    }
}
