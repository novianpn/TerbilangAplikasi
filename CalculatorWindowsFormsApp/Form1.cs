using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLibrary;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            Calculator calculator = new Calculator();

            listHasil.Items.Clear();
            listHasil.Items.Add("Hasil Penambahan " + a + " + " + b + " = " + calculator.Penambahan(a, b));
            listHasil.Items.Add(string.Format("Hasil Pengurangan {0} - {1} = {2} ", a,b, calculator.Pengurangan(a, b)));
            listHasil.Items.Add(string.Format("Hasil Perkalian {0} * {1} = {2} ", a, b, calculator.Perkalian(a, b)));
            listHasil.Items.Add(string.Format("Hasil Pembagian {0} / {1} = {2} ", a, b, calculator.Pembagian(a, b)));
        }
    }
}
