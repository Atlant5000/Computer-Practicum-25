using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    /// <summary>
    /// 4) Заполнить одномерный массив случайным образом и вывести на экран с использованием цикла foreach.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] omas = new int[n];
            Random random = new Random();
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = random.Next(-10, 10);
            }
            foreach (int element in omas)
            {
                Console.Write($"{element}\t");
            }
            Console.ReadLine();
        }
    }
}
