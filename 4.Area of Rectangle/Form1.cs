using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Area_of_Rectangle
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
            double length = Convert.ToDouble(textBox1.Text);
            double height = Convert.ToDouble(textBox2.Text);

            //calculate area 
            double area = length * height;
            

            //display results 
            textBox3.Text = area.ToString();
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(textBox1.Text);
            double height = Convert.ToDouble(textBox2.Text);

            double perimeter = 2 * (length + height);

            textBox4.Text = perimeter.ToString();
        }
    }
}
