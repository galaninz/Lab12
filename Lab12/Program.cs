using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            double p = Solution.GetLength(r);
            double s = Solution.GetArea(r);
            Console.WriteLine($"Длина окружности - {p:.00}, площадь {s:.00}");

            Console.WriteLine("Введите точку (x,y)");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (Solution.GetBelong(x,y,r) == false)
                Console.WriteLine($"Точка с координатами {x} и {y} - не принадлежит окружности с радиусов {r}");
            else
                Console.WriteLine($"Точка с координатами {x} и {y} - принадлежит окружности с радиусов {r}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
    