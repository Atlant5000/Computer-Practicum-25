using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    /// <summary>
    /// 2) Инициализировать одномерный массив с использованием конструктора , без указания размерности массива и без клавиатуры. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[] { 4, 5, 4, 6, 7 };
            foreach (int element in omas)
            {
                Console.Write($"{element}\t");
            }
            Console.ReadLine(); 
        }
    }
}
