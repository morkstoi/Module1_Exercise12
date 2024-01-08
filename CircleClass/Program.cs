using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности:");
            double r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки x1:");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки y1:");
            double y1 = Convert.ToInt32(Console.ReadLine());
            double x0 = 0;
            double y0 = 0;
            double circleArea = CircleDefi.GetArea(r);
            double circleLength = CircleDefi.GetLength(r);
            bool withinBoundaries = CircleDefi.IsWithinBounadries(x1, y1, x0, y0, r);
            Console.WriteLine($"Площадь круга равна:{circleArea}.");
            Console.WriteLine($"Длина окружности равна:{circleLength}.");
            Console.WriteLine($"Точка с координатами ({x1},{y1}) находится внутри окружности:{withinBoundaries}.");
            Console.ReadKey();




        }
    }
}
