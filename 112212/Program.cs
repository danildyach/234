using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задача 1");
            zd1();
            Console.WriteLine("задача 2");
            zd2();
        }
        static void zd1()
        {
            //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            Console.WriteLine("Введите кол-во чисел которые хотели бы ввести :");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int count = 0;
            for (int i = 0; i < size; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; ++i)
            {
                if (a[i] > 0)
                {
                    count++;
                }

            }
            Console.WriteLine($" кол-во чисел больше 0{count}");
        }
        static void zd2()
        {
            //Задача 43.Напишите программу, которая найдёт точку пересечения двух прямых,
            //заданных уравнениями y = k1 * x + b1,
            //y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            Console.WriteLine("Введите b1");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k1");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b2");
            double b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k2");
            double k2 = Convert.ToInt32(Console.ReadLine());
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine($"({x};{y})");
        }
    }
}
