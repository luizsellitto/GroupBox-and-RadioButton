using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox_and_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            double first = Convert.ToDouble(tb_first.Text);
            double second = Convert.ToDouble(tb_second.Text);

            if(rb_soma.Checked == true)
            {
                result = first + second;

            }
            else if (rb_sub.Checked == true)
            {

            }
            else if (rb_mult.Checked == true)
            {

            }
            else
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
