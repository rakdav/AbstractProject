using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(34, 78);
            Console.WriteLine($"Площадь прямоугольника={rectangle.Area():F2}");
            Console.WriteLine($"Периметр прямоугольника={rectangle.Perimetr():F2}");
            Circle circle = new Circle(12);
            Console.WriteLine($"{circle.Area():F2}");
            Console.WriteLine($"{circle.Perimetr():F2}");
            Console.ReadKey();
        }
    }
}
