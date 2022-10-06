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
                numlist[i] = randx.Next(1, 200);
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
        }
        static int Array_task4(out double srznach, ref double proizv, params int[] mass)
        {
            srznach = 0;
            proizv = 1;

            foreach (int i in mass)
            {
                proizv *= i;
                srznach += (i / mass.Count());
            }
            return mass.Sum();
        }

        public static Dictionary<int, string> consoleDigits = new Dictionary<int, string>
        {
            [1] = " # \n" +
                  "## \n" +
                  " # \n" +
                  " # \n" +
                  "###",

            [2] = " # \n" +
                  "# #\n" +
                  "  #\n" +
                  " # \n" +
                  "###",

            [3] = "## \n" +
                  "  #\n" +
                  " # \n" +
                  "  #\n" +
                  "## ",

            [4] = "# #\n" +
                  "# #\n" +
                  "###\n" +
                  "  #\n" +
                  "  #",

            [5] = "###\n" +
                  "#  \n" +
                  "###\n" +
                  "  #\n" +
                  "## ",

            [6] = " ##\n" +
                  "#  \n" +
                  "###\n" +
                  "# #\n" +
                  "###",

            [7] = "###\n" +
                  "  #\n" +
                  "  #\n" +
                  " # \n" +
                  " # ",

            [8] = "###\n" +
                  "# #\n" +
                  "###\n" +
                  "# #\n" +
                  "###",

            [9] = "###\n" +
                  "# #\n" +
                  "###\n" +
                  "  #\n" +
                  "## ",

            [0] = " # \n" +
                  "# #\n" +
                  "# #\n" +
                  "# #\n" +
                  " # "
        };
        struct ded
        {
            public string name; 
            public string level_vorch; 
            public string[] phraz;
            public int downtrodden;

            public void Print()
            {
                Random x = new Random();
                Console.WriteLine($"Имя: {name}\nУровень ворчливости: {level_vorch}\nЛюбимые фразы ");
                foreach ( string i in phraz)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine($"Количество фингалов: {downtrodden}");
            }
        }

        public enum Level_ded
        {
            level_1 = 1, level_2 = 2, level_3 = 3 , level_4 = 4, level_5 = 5
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1\nТекст задания\nНаписать метод для решения квадратного уравнения");
            Equation_task1();

            Console.WriteLine("\nЗадание №2\nТекст задания\nВывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива, которые нужно поменять местами.Вывести на экран получившийся массив.");
            Replacement_task2();

            Console.WriteLine("\n\nЗадание №3\nТекст задания\nНаписать метод для сортировки одномерного массива пузырьком");
            Sort_task3();

            Console.WriteLine("\nЗадание №4\nТекст задания\n. Написать метод, где в качества аргумента будет передан массив (ключевое слово params).Вывести сумму элементов массива(вернуть).Вывести(ref) произведение массива. Вывести(out) среднее арифметическое в массиве.");
            Random count = new Random();
            double a = 0;
            double b = 0;
            double c;
            int x = count.Next(5, 100);
            int[] mass = new int[x];
            for (int i = 0; i < x; i++)
            {
                mass[i] = count.Next(1000);
            }
            c = Array_task4(out a, ref b, mass);
            Console.WriteLine($"Сумма элементов {c} среднее арифметическое {b} произведение членов {a}");

            Console.WriteLine("\n\nЗадание №5\nТекст задания\n5. Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке.Если пользователь ввёл не цифру, то программа должна выпасть в исключение.Программа завершает работу, если пользователь введёт слово: exit или закрыть(оба варианта должны сработать) - консоль закроется.");
            try
            {
                Console.WriteLine("Введите число от 0 до 9 ключительно");
                string text = (Console.ReadLine());
                if (text == "закрыть" || text == "exit")
                {
                }
                else if (int.TryParse(text, out var number) == true)
                {
                    int chisl = int.Parse(text);
                    if (chisl > 9 || chisl < 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Выход за предел");
                        System.Threading.Thread.Sleep(3000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();

                    }
                    switch (chisl)
                    {
                        case 0:
                            {
                                Console.WriteLine(consoleDigits[0]);
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine(consoleDigits[1]);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine(consoleDigits[2]);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine(consoleDigits[3]);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine(consoleDigits[4]);
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine(consoleDigits[5]);
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine(consoleDigits[6]);
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine(consoleDigits[7]);
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine(consoleDigits[8]);
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine(consoleDigits[9]);
                                break;
                            }
                    }
                }
                else
                {
                    int chisl = int.Parse(text);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            Console.WriteLine("\n\nЗадание №6\nТекст задания\n. Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке.Если пользователь ввёл не цифру, то программа должна выпасть в исключение.Программа завершает работу, если пользователь введёт слово: exit или закрыть(оба варианта должны сработать) - консоль закроется.");
            Random m = new Random();
            string[] name_of_ded = new[] { "Максим", "Илия", "Николай", "Михаил", "Вадим", "Данил", "Феодосий" };
            string[][] phraz = { new string[] {"Гады", "0" }, new string[] {"Шлюхи", "0"}, new string[] { "Мать твою за ногу", "0"}, new string[] { "Едрит твою налево","0"}, new string[]{ "Ебучая скотина", "1"} };
            ded[] dedi = new ded[5];
            int k;
            int v = 0;
            int g;
            for (int i = 0; i < dedi.Count(); i++)
            {
                dedi[i].name = name_of_ded[m.Next(0, name_of_ded.Count())];
                dedi[i].level_vorch = Convert.ToString((Level_ded)Enum.GetValues(typeof(Level_ded)).GetValue(m.Next(0, 5)));
                dedi[i].downtrodden = 0;
                k = m.Next(0, phraz.Count());
                g = 0;
                while (g < 2)
                {
                    foreach (string[] f in phraz)
                    {
                        if (v == k)
                        {
                            dedi[i].phraz.Append(Convert.ToString(f[0]));
                            dedi[i].downtrodden += int.Parse(f[1]);
                        }
                        v++;
                    }
                    g++;
                }
                for (int h = 0; h < dedi[i].phraz.Count(); h++)
                {
                                        }

            }

            Console.ReadKey();
        }
    }
}
