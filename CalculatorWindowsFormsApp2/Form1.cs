﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {

            Double nilaiA, nilaiB, hasil;

            if (comboBox1.SelectedIndex == 0)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA + nilaiB;
                txtHasil.Text = hasil.ToString();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA - nilaiB;
                txtHasil.Text = hasil.ToString();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA * nilaiB;
                txtHasil.Text = hasil.ToString();
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA / nilaiB;
                txtHasil.Text = hasil.ToString();
            }






        }
    }
}
