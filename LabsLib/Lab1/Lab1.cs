using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    public class Lab1 : AllLabsProject.ILabs
    {
        public void Demo()
        {
            Console.WriteLine("Задание 1");
            double z = Math.Pow(2, 2) - Math.Pow(3, 3);
            double x = Math.Sqrt(Math.Pow(3, 4) - Math.Pow(2, 4));
            double v = Math.Abs(Math.Pow(3, 5) - Math.Pow(15, 2.5));
            double result1 = Math.Sqrt(z / x + v);
            Console.WriteLine(" Ответ: " + result1);
            Console.WriteLine();


            Console.WriteLine("Задание 2");
            double f, g;
            double h;
            Random rnd = new Random();
            f = rnd.Next();
            g = rnd.Next();
            double result2 = (Math.Pow(f, 2) + Math.Cbrt(g)) / f + g;
            h = result2;
            Console.WriteLine();
            Console.WriteLine(" Ответ: " + h);
            Console.WriteLine();


            Console.WriteLine("Задание 3");
            double a = 5.93576;
            int b = (int)g;
            int c = (int)(Math.Round(a));
            int d = (int)(Math.Floor(a));
            double e = Math.Round(a, 1);
            int y = 5;


            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(y++);
            Console.WriteLine(++y);
            Console.WriteLine();


            Console.WriteLine("Задание 4");
            Random rnd1 = new Random();
            int i = rnd.Next(0, 1000);


            Console.WriteLine();
            Console.WriteLine(i);
        }
        public string Description()
        {
            return "Задания лабораторной №1";
        }

        public int Id()
        {
            return 1;
        }

        public string Name()
        {
            return "Арифметические опреации. Классы Random и Math";
        }
    }
}
  
