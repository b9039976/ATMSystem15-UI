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
    public partial class viewBalance : Form
    {
        public viewBalance()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainList f2 = new mainList();
            f2.Show();
            this.Hide();
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
    }
    }

