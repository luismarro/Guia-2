using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace ejercicio_4_pro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            err.Clear();
            String patronEmail = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if(!Regex.IsMatch(textBox1.Text, patronEmail))
            {

                err.SetError(textBox1, "Ingrese un email valido");
            }

            String patronPassword = "^[A-Z]{1,}[a-z]{1,}[0-9]{1,}[^a-zA-Z]{1,}$";

            if (textBox2.Text.Length >= 8)
            {
                if (!Regex.IsMatch(textBox2.Text, patronPassword))
                {

                    err.SetError(textBox2, "Ingrese un password valido");
                }
            }
            else {
                

                    err.SetError(textBox2, "Debe tener minimo 8 caracteres");
                
            
            }

            if (textBox2.Text == textBox3.Text) 
           {
               
           }
            else
            {
                err.SetError(textBox3, "Ingrese el mismo password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
