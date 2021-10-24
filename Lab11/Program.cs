using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation {k=200,b=1000};//Задаем аргументы экземпляра структуры Equation, служащей для нахождения решения уравнения типа 0=kx+b 
            Console.Write("Решением уравнения является Х=");
            equation.Root();
            Console.ReadKey();
        }

        struct Equation
        {
            public double k;
            public double b;

            public void Root()
            {
                if (k == 0 && b != 0)
                    Console.WriteLine("Уравнение не имеет решений");
                else if (k == 0 && b == 0)
                    Console.WriteLine("Решение - любое действительное число");
                else
                {
                    Console.WriteLine(-b / k);
                }
            }
        }
    }
}