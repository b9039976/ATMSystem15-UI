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
    public partial class amount : Form
    {
        public amount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainList f2 = new mainList();
            f2.Show();  
            this.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void amount_Load(object sender, EventArgs e)
        {

        }
    }
}
