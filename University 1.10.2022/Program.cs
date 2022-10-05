using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_1._10._2022
{

    class Program
    {
        static Array equation()
        {
            Console.WriteLine("Введите коэффиценты квадратного уравнения вида ax^2 + bx + c = 0 ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("с = ");
            double c = double.Parse(Console.ReadLine());
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
        static void Main(string[] args)
        {
            equation();
            Console.ReadKey();
        }
    }
}
