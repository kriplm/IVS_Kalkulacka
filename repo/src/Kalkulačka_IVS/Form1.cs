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

        public bool vstup=true;

        /**
         * @brief Funkce znam_tmp znaménka, která v první fázi jen mění znaménku u mezivýslekdu a až je zadána další číslice,
         * tak slouží pro vypočtení aktuálního výsledku a zobrazení do mezivýpočtu.
         * 
         * @param Button znam Předání znaménka do funkce pomocí charu Buttonu.
         *
         * 
         */

        void znam_tmp(Button znam)
        {
            try
            {
                if (vstup == false)
                {
                    lblpredvýsledek.Text = lblpredvýsledek.Text.Remove(lblpredvýsledek.Text.Length - 1) + znam.Text;
                }
                else
                {
                    if (lblpredvýsledek.Text == "0")
                    {
                        lblpredvýsledek.Text = lblvysledek.Text + znam.Text;
                    }
                    else
                    {
                        char znak = lblpredvýsledek.Text[lblpredvýsledek.Text.Length - 1];
                        if (char.IsNumber(znak))
                        {
                            lblpredvýsledek.Text = lblpredvýsledek.Text + znam.Text;
                        }
                        else
                        {
                            lblpredvýsledek.Text = lblpredvýsledek.Text.Remove(lblpredvýsledek.Text.Length - 1);
                            double meziVysledek = vysledek(Convert.ToDouble(lblpredvýsledek.Text), Convert.ToDouble(lblvysledek.Text), znak);
                            lblpredvýsledek.Text = Convert.ToString(meziVysledek) + znam.Text;
                        }
                    }
                    lblvysledek.Text = "0";
                }
                vstup = false;
            }
            catch (Exception)
            {
                
            }
        }

        /**
         * @brief Funkce Form1_KeyPress je pro zadávání vstupních hodnot přes klávesnici
         * 
         * @param object sender
         * @param KeyPressEventsArgs e
         *
         * 
         */

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57)|| e.KeyChar ==44)
            {
                vstup = true;
                if (lblvysledek.Text == "0" && e.KeyChar != 44)
                    lblvysledek.Text = e.KeyChar.ToString();
                else
                {
                    if (lblvysledek.Text.IndexOf(",", 0, lblvysledek.Text.Length) == -1)
                        lblvysledek.Text += e.KeyChar.ToString();
                    else if ( e.KeyChar != 44)
                    {
                        lblvysledek.Text += e.KeyChar.ToString();
                    }

                }
                 
            }
            else if (e.KeyChar == 43)
            {
                znam_tmp(btnplus);
            }
            else if (e.KeyChar == 45)
            {
                znam_tmp(btnminus);
            }
            else if (e.KeyChar == 42)
            {
                znam_tmp(btnkrat);
            }
            else if (e.KeyChar == 47)
            {
                znam_tmp(btndel);
            }
            else if (e.KeyChar == 79 || e.KeyChar == 111)
            {
                znam_tmp(btnodmocnina);
            }
            else if (e.KeyChar == 37)
            {
                znam_tmp(btnmodulo);
            }
            else if (e.KeyChar == 33)
            {
                znam_tmp(btnfaktorial);
            }
            else if (e.KeyChar == 127 )
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
            else if (e.KeyChar == 13)
            {
                MessageBox.Show("vaďu je kokot");
            }
        }

        /**
         * @brief Funkce vysledek slouží pro výpočet s použítím matematické knihovny
         * 
         * @param double a První číselný argument funkce
         * @param double b Druhý číselný argument funkce
         * @param char znak Argument, na základě kterého, rozhodujeme o kterou výpočetní akci se jedná
         * 
         * @return Výsledek Vypočítaná hodnota čísel A a B na základě znaménka znak
         */

        double vysledek(double a, double b,char znak)
        {
            double vys=0;

            switch (znak)
            {
                case '+':
                    vys=ivsmath.Scitani(a, b);
                    break;

                case '-':
                    vys = ivsmath.Odcitani(a, b);
                    break;

                case '*':
                    vys = ivsmath.Nasobeni(a, b);
                    break;

                case '/':
                    try
                    {
                        vys = ivsmath.Deleni(a, b);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chybný vstup u funkce Dělení");
                    }                   
                    break;

                case '%':
                    try
                    {
                        vys = ivsmath.Modulo(a, b);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chybný vstup u funce Modulo");
                    }
                    break;

                case '!':
                    try
                    {
                        vys = ivsmath.Faktorial(a);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chybný vstup u funkce Faktoriál");
                    }
                    break;

                case '√':
                    try
                    {
                        vys = ivsmath.Odmocnina(a, b);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chybný vstup u funkce Odmocnina");
                    }
                    break;

                case '^':
                    try
                    {
                        vys = ivsmath.Mocnina(a, b);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chybná vstup u funkce Mocnina");
                    }
                    break;
            }

            return vys;
        }

        /**
         * @brief Funkce number_click je pro číselné Buttony, které slouží jako vstupní hodnoty kalkulačky
         * 
         * @param sender
         * @param EventArgs
         * 
         */

        private void number_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            vstup = true;

            if (lblvysledek.Text == "0")
            {
                lblvysledek.Text = num.Text;
            }
            else
            {
                lblvysledek.Text = lblvysledek.Text + num.Text;
            }
        }

        /**
        * @brief Funkce btnAC_Click slouží pro úplné vynulování kalkulačky
        * 
        * @param sender
        * @param EventArgs
        * 
        */

        private void btnAC_Click(object sender, EventArgs e)
        {
            lblvysledek.Text = "0";
            lblpredvýsledek.Text = "0";
        }

        /**
        * @brief Funkce btnC_Click vynuluje jen zadávaní vstupní hodnoty, ne mezivýsledek.
        * 
        * @param sender
        * @param EventArgs
        * 
        */

        private void btnC_Click(object sender, EventArgs e)
        {
            lblvysledek.Text = "0";
        }

        /**
       * @brief Funkce btndel_Click maže poslední znak ve vstupní hodnotě.
       * 
       * @param sender
       * @param EventArgs
       * 
       */

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

        /**
       * @brief Funkce btnznam_Click je pomocná funkce pro předání znaku znaménka do pomocné funkce znam_tmp
       * 
       * @param sender
       * @param EventArgs
       * 
       */

        private void btnznam_Click(object sender, EventArgs e)
        {
                znam_tmp((Button)sender);
        }

       /**
       * @brief Funkce btnrovno_Click vypočítá a zobrazí vypočtenou hodnotu do Výsledku
       * 
       * @param sender
       * @param EventArgs
       * 
       */

        private void btnrovno_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblpredvýsledek.Text == "0")
                {
                    lblpredvýsledek.Text = "0";
                }
                else
                {
                    char znak = lblpredvýsledek.Text[lblpredvýsledek.Text.Length - 1];
                    lblpredvýsledek.Text = lblpredvýsledek.Text.Remove(lblpredvýsledek.Text.Length - 1);
                    double meziVysledek = vysledek(Convert.ToDouble(lblpredvýsledek.Text), Convert.ToDouble(lblvysledek.Text), znak);
                    lblvysledek.Text = Convert.ToString(meziVysledek);
                    lblpredvýsledek.Text = "0";
                }
            }
            catch (Exception)
            {

                
            }
        }

        /**
       * @brief Funkce btnfaktorial_Click je mimořádná funkce pro matematickou funkci faktoriál
       * 
       * @param sender
       * @param EventArgs
       * 
       */

        private void btnfaktorial_Click(object sender, EventArgs e)
        {
            if (lblpredvýsledek.Text == "0")
            {
                try
                {

                    lblpredvýsledek.Text = Convert.ToString(ivsmath.Faktorial(Convert.ToDouble(lblvysledek.Text)));
                }
                catch
                {
                    MessageBox.Show("Chybný vstup u funkce Faktoriál");
                    lblpredvýsledek.Text = "0";
                    lblvysledek.Text = "0";
                }
             }
            else
            {
                try
                {
                    char znak = lblpredvýsledek.Text[lblpredvýsledek.Text.Length - 1];
                    lblpredvýsledek.Text = lblpredvýsledek.Text.Remove(lblpredvýsledek.Text.Length - 1);
                    double meziVysledek = vysledek(Convert.ToDouble(lblpredvýsledek.Text), ivsmath.Faktorial(Convert.ToDouble(lblvysledek.Text)), znak);
                    lblpredvýsledek.Text = Convert.ToString(meziVysledek);
                    lblvysledek.Text = "0";
                }
                catch (Exception)
                {
                    MessageBox.Show("Chybný vstup u funkce Faktoriál");
                    lblpredvýsledek.Text = "0";
                }
               
            }
            
        }
    }
}