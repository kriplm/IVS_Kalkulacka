using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mathlib;


namespace Kalkulačka_IVS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyPress +=
            new KeyPressEventHandler(Form1_KeyPress);
        }

        IVSMath ivsmath = new IVSMath();

        public Button znam;

        void znam_tmp(Button znam)
        {
            try
            {
                if (lblpredvýsledek.Text == "0")
                {
                    if (znam.Text == "!" || znam.Text == "√")
                    {
                        lblvysledek.Text = Convert.ToString(vysledek(Convert.ToDouble(lblvysledek.Text), 0, znam));
                    }
                    lblpredvýsledek.Text = lblvysledek.Text;
                }
                else
                {
                    double num1 = Convert.ToDouble(lblvysledek.Text);
                    double num2 = Convert.ToDouble(lblpredvýsledek.Text);
                    double vysldk = vysledek(num1, num2, znam);
                    lblpredvýsledek.Text = Convert.ToString(vysldk);
                }
                lblvysledek.Text = "0";
            }
            catch (Exception)
            {
                
            }
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                if (lblvysledek.Text == "0")
                    lblvysledek.Text = e.KeyChar.ToString();
                else
                    lblvysledek.Text += e.KeyChar.ToString();
            }
            else if (e.KeyChar == 43)
            {
                //show("+");
                znam_tmp(btnplus);
            }
            else if (e.KeyChar == 45)
            {
                // show("-");
                znam_tmp(btnminus);
            }
            else if (e.KeyChar == 42)
            {
                //    show("*");
                znam_tmp(btnkrat);
            }
            else if (e.KeyChar == 47)
            {
                //    show("/");
                znam_tmp(btndel);
            }
            else if (e.KeyChar == 8)
            {
                btndel_Click(sender,e);
            }
            else if (e.KeyChar == 25)
            {
                znam_tmp(btnmodulo);
            }
            else if (e.KeyChar == 33)
            {
                znam_tmp(btnfaktorial);
            }

        }

        double vysledek(double a, double b,Button znam)
        {
            double vys=0;

            switch (znam.Text)
            {
                case "+":
                    vys=ivsmath.Scitani(a, b);
                    break;

                case "-":
                    vys = ivsmath.Odcitani(a, b);
                    break;

                case "*":
                    vys = ivsmath.Nasobeni(a, b);
                    break;

                case "/":
                    if( b == 0)
                    {
                        MessageBox.Show("Nelze dělit nulou!");
               
                    }
                    vys = ivsmath.Deleni(a, b);
                    break;

                case "%":
                    vys = ivsmath.Modulo(a, b);
                    break;

                case "!":
                    vys = ivsmath.Faktorial(a);
                    break;

                case "√":
                    if (a <= 0)
                    {
                        MessageBox.Show("Nelze odmocnit nulové nebo záporné číslo!");
                        vys = 0;
                        break;
                    }
                    vys = ivsmath.Odmocnina(a);
                    break;
            }

            return vys;
        }
        

        private void number_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (lblvysledek.Text == "0")
            {
                lblvysledek.Text = num.Text;
            }
            else
            {
                lblvysledek.Text = lblvysledek.Text + num.Text;
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            lblvysledek.Text = "0";
            lblpredvýsledek.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblvysledek.Text = "0";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (lblvysledek.Text.Length > 0)
            {
                lblvysledek.Text = lblvysledek.Text.Remove(lblvysledek.Text.Length - 1, 1);
            }

            if (lblvysledek.Text == "")
            {
                lblvysledek.Text = "0";
            }
        }

        private void btnznam_Click(object sender, EventArgs e)
        {
                znam_tmp((Button)sender);
        }

        private void btnrovno_Click(object sender, EventArgs e)
        {
            try
            {
                double num2 = Convert.ToDouble(lblvysledek.Text);
                double num1 = Convert.ToDouble(lblpredvýsledek.Text);
                double vysldk = vysledek(num1, num2, znam);
                lblpredvýsledek.Text = Convert.ToString(vysldk);
                lblvysledek.Text = lblpredvýsledek.Text;
                lblpredvýsledek.Text = "0";
                if (lblpredvýsledek.Text == "")
                {
                    lblpredvýsledek.Text = "0";
                }
                if (lblvysledek.Text == "")
                {
                    lblvysledek.Text = "0";
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}