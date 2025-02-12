using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    /// <summary>
    /// 1) Выполнить инициализацию одномерного массива с использованием конструктора без указания значений элементов и вывести на экран.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] omas = new int[n];
            for (int i = 0;i<n;i++)
            {
                Console.Write($"omas[{i}]=");
                omas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i<omas.Length;i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
            Console.ReadLine();*/
            /*Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] omas = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"omas[{i}]=");
                omas[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
            Console.ReadLine();*/
            // 2) Инициализировать одномерный массив с использованием конструктора , без указания размерности массива и без клавиатуры. 
            /*int[] omas = new int[] {4,5,4,6,7};
            foreach (int element in omas)
            {
                Console.Write($"{element}\t");
            }
            Console.ReadLine();*/
            // 4) Заполнить одномерный массив случайным образом и вывести на экран с использованием цикла foreach.
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] omas = new int[n];
            Random random = new Random();
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] =random.Next(-10, 10);
            }
            foreach (int element in omas)
            {
                Console.Write($"{element}\t");
            }
            Console.ReadLine();
        }
    }
}
