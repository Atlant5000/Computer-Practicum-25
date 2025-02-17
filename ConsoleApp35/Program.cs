using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    /// <summary>
    /// 1) Выполнить инициализацию одномерного массива с использованием конструктора без указания значений элементов и вывести на экран.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] omas = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"omas[{i}]=");
                omas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
            Console.ReadLine();
        }
    }
}
