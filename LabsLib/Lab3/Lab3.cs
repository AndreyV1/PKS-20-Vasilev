using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal class Lab3 : AllLabsProject.ILabs
    {
        public void Demo()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("While");
            int num = 0, ost5;
            while (num <= 100)
            {
                num++;
                ost5 = num % 5;
                if (ost5 == 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("do while");
            int num1 = 0, osta5;
            do
            {
                num1++;
                osta5 = num1 % 5;
                if (osta5 == 0)
                {
                    Console.WriteLine(num1);
                }
            }
            while (num1 <= 100);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("for");
            int ostat5, num2;
            for (num2 = 0; num2 <= 100; num2++)
            {
                ostat5 = num2 % 5;
                if (ostat5 == 0 && num2 != 0)
                {
                    Console.WriteLine(num2);
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Задание 2");
            int nac = 0, summa = 0;
            while (nac <= 30)
            {
                int c = nac % 2;
                nac++;
                if (c == 0)
                {
                    summa += nac;
                }
            }
            Console.WriteLine("Сумма:" + summa);

        }
        public string Description()
        {
            return "Задания лабораторной №3";
        }

        public int Id()
        {
            return 3;
        }

        public string Name()
        {
            return "Циклы";
        }
    }
}