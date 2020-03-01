using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2_pro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            double a;
           double b;
            double d;
            double mul;
            double tota1;
            double mul2;
            double tota2;
            double mul3;
            double tota3;
            double mul4;
            double tota4;


            a = Convert.ToDouble(txtcan.Text);
            b = Convert.ToDouble(txtpre.Text);
  

            d = (a * b);
            
            if (des0.Checked == true)
            {
                txtdes.Text= "0.00";
                txttot.Text = d.ToString();
                
            }

            if( des5.Checked == true)
            {
                mul= (d * 0.05);
                tota1= (d - mul );
                txtdes.Text = mul.ToString();
                txttot.Text = tota1.ToString();

            }

            if(des10.Checked ==true)
            {
                mul2 = (d * 0.10);
                tota2 = (d - mul2);
                txtdes.Text = mul2.ToString();
                txttot.Text = tota2.ToString();

            }
            if(des15.Checked==true)
            {
                mul3 = (d * 0.15);
                tota3 = (d - mul3);
                txtdes.Text = mul3.ToString();
                txttot.Text = tota3.ToString();
            }
            if(des20.Checked==true)
            {
                mul4=(d*0.20);
                tota4=(d-mul4);
                txtdes.Text = mul4.ToString();
                txttot.Text = tota4.ToString();
            }


        }

        private void lim_Click(object sender, EventArgs e)
        {
            txtcan.Clear();
            txtpre.Clear();
            txtdes.Clear();
            txttot.Clear();
            
        }

        private void sal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
