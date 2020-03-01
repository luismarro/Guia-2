using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1_pro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cal1_Click(object sender, EventArgs e)
        {
            int nu1;
            string rom = "";

            nu1 = Convert.ToInt16(num1.Text);
            

            switch (nu1)
            {
                case 1:
                    rom = "  I  ";
                    break;
                case 2:
                    rom = "  II  ";
                    break;
                case 3:
                    rom = "  III   ";
                    break;
                case 4:
                    rom = "   IV  ";
                    break;
                case 5:
                    rom = "   V   ";
                    break;
                case 6:
                    rom = "  VI   ";
                    break;
                case 7:
                    rom = "  VII   ";
                    break;
                case 8:
                    rom = "  VIII  ";
                    break;
                case 9:
                    rom = "  IX   ";
                    break;
                case 10:
                    rom = "  X  ";
                    break;

                default:
                    rom = "  El numero ingresado no esta en el rango";
                    break;

            }
            num2.Text = rom;
        }

        private void lim_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
        }

        private void sal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
