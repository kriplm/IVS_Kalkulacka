using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulačka_IVS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        
    }
}
