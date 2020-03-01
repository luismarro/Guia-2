using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_3_de_pro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double valorConvertido = 0;

            if (listBox1.Text.Equals("Pulgadas") && listBox2.Text.Equals("Pulgadas"))
            {

                valorConvertido = Convert.ToDouble(textBox2.Text) * 1;

            }

            else if (listBox1.Text.Equals("Pulgadas") && listBox2.Text.Equals("Pies"))
            {
                valorConvertido = Convert.ToDouble(textBox2.Text) * 0.0833333;
            }

            else if (listBox1.Text.Equals("Pulgadas") && listBox2.Text.Equals("Yardas"))
            {

                valorConvertido = Convert.ToDouble(textBox2.Text) * 0.0277778;
            }

            else if (listBox1.Text.Equals("Pies") && listBox2.Text.Equals("Pulgadas"))
            {
                valorConvertido = Convert.ToDouble(textBox2.Text) * 12;
            }

            else if (listBox1.Text.Equals("Pies") && listBox2.Text.Equals("Pies"))
            {
                valorConvertido = Convert.ToDouble(textBox2.Text) * 1;
            }
            else if (listBox1.Text.Equals("Pies") && listBox2.Text.Equals("Yardas"))
            {
                valorConvertido = Convert.ToDouble(textBox2.Text) * 0.333333;
            }
            else if (listBox1.Text.Equals("Yardas") && listBox2.Text.Equals("Pulgadas"))
            {
                valorConvertido = Convert.ToDouble(textBox2.Text) * 36;
            }
            else if (listBox1.Text.Equals("Yardas") && listBox2.Text.Equals("Pies"))
            {
                valorConvertido = Convert.ToDouble(textBox2.Text) * 3;
            }
            else if (listBox1.Text.Equals("Yardas") && listBox2.Text.Equals("Yardas"))
            {
                valorConvertido = Convert.ToDouble(textBox2.Text) * 1;
            }

            textBox1.Text = Convert.ToString( valorConvertido);
                
                
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
