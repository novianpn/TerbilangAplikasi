using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //var b = 6;

            Console.Write("Inputkan Nilai A = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai B = ");
            var b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();

            Console.Title = "Aplikasi Calculator Versi Console";

            Calculator calculator = new Calculator();

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + calculator.Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan  {0} - {1} = {2} ",a, b, calculator.Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian  {0} * {1} = {2} ", a, b, calculator.Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian  {0} / {1} = {2} ", a, b, calculator.Pembagian(a, b));

            Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
            Console.ReadKey();
        }

        
    }
}
