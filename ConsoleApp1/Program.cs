using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Equation_task1()
        {
            try
            {
                Console.WriteLine("Введите коэффиценты квадратного уравнения");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());
                double x1 = 0;
                double x2 = 0;
                if (b * b - 4 * a * c > 0)
                {
                    x1 = ((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                    x2 = ((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                    Console.WriteLine($"первый корень {0} , второй {1}", x1, x2);
                }
                else if (b * b - 4 * a * c == 0)
                {
                    Console.WriteLine("Уравнение не имет корней");
                }
                else if (x1 == x2)
                {
                    Console.WriteLine($"Единственный корень уравнения равен {0}", x1);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        static void Replacement_task2()
        {
            int[] numlist = new int[20];
            Random randx = new Random();
            Console.WriteLine("Начальный список");
            for (int i = 0; i < 20; i++)
            {
                numlist[i] = randx.Next(1 , 200);
                Console.Write(numlist[i] + " ");
            }
            int a = randx.Next(0, 20);
            int b = randx.Next(0, 20);
            while (a == b)
            {
                b = randx.Next(0, 19);
            }
            Console.WriteLine($"\nБудем менять местами элементы с индексами {Convert.ToString(a)} и {Convert.ToString(b)}");
            int num = numlist[a];
            numlist[a] = numlist[b];
            numlist[b] = num;
            Console.WriteLine("Измененный список");
            foreach (int i in numlist)
            {
                Console.Write(i + " ");
            }           
        }

        static void Sort_task3()
        {
            Random x = new Random();
            int[] nosort = new int[10];
            Console.WriteLine("Массив до сортировки");
            for (int i = 0; i < 10; i++)
            {
                nosort[i] = x.Next(100);
                Console.Write(nosort[i] + " ");
            }
            int a = 0;
            int count = 0;
            for (int i = 0; i < nosort.Count() - 1; i++)
            {
                for (int k = 0; k < nosort.Count() - 1; k++)
                {
                    if (nosort[k] > nosort[k + 1])
                    {
                        a = nosort[k + 1];
                        nosort[k + 1] = nosort[k];
                        nosort[k] = a;
                        count++;
                    }
                }
                if (count == 0)
                {
                    break;
                }
            }
            Console.WriteLine("\nМассив после сортировки");
            foreach (int i in nosort)
            {
                Console.Write(i + " ");
            }
            {

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1\nТекст задания\nНаписать метод для решения квадратного уравнения");
            Equation_task1();

            Console.WriteLine("\nЗадание №2\nТекст задания\nВывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива, которые нужно поменять местами.Вывести на экран получившийся массив.");
            Replacement_task2();

            Console.WriteLine("\n\nЗадание №3\nТекст задания\nНаписать метод для сортировки одномерного массива пузырьком");
            Sort_task3();
            Console.ReadKey();

        }
    }
}
