using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal class Lab6 : ILabs
    {
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы
            int Factorial(int n)
            {
                if (n == 1) return 1;

                return n * Factorial(n - 1);
            }

            int factorial4 = Factorial(4);  // 24
            int factorial5 = Factorial(5);  // 120
            int factorial6 = Factorial(6);  // 720

            Console.WriteLine($"Факториал числа 4 = {factorial4}");
            Console.WriteLine($"Факториал числа 5 = {factorial5}");
            Console.WriteLine($"Факториал числа 6 = {factorial6}");
        }

        public string Description()
        {
            return "Задания лабораторной №6";
        }

        public int Id()
        {
            return 6;
        }

        public string Name()
        {
            return "Рекурсивные функции";
        }
    }
}

