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
    public partial class employeemenu : Form
    {
        public employeemenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creatnewaccount d1 = new creatnewaccount();
            d1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setoverdraft d2 = new setoverdraft();
            d2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
