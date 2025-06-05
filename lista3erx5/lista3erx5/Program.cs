using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3erx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            do
            {
                Console.Write("Digite um valor positivo: ");
                num = double.Parse(Console.ReadLine());
            } while (num <= 0);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
