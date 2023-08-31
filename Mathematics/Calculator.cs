using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    internal class Calculator
    {
        public void Add(int num1, int num2)
        {
            int toplam = num1 + num2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Extraction(int num1, int num2)
        {
            int toplam = num1 - num2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Divide(int num1, int num2)
        {
            int toplam = num1 / num2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Multiply(int num1, int num2)
        {
            int toplam = num1 * num2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
