using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int x, y ;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x = Convert.ToInt16(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            y = Convert.ToInt16(textBox2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(x, y);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
