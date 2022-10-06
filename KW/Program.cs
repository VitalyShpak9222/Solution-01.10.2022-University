using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW
{
    class Program
    {
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



        static void Main(string[] args)
        {
            Console.WriteLine("Задание 35\r\nПрограмма повторяет разговор Гарри Поттера из 2 части серии и меняет цвет консоли на один из 16 помимо черного");
            Console.Clear();
            Random color = new Random();
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name2 = Console.ReadLine();
            Console.WriteLine("Привет, " + name2);
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            int color1 = color.Next(1, 15);
            if (color1 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (color1 == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            if (color1 == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            if (color1 == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            if (color1 == 4)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            if (color1 == 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }
            if (color1 == 6)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            if (color1 == 7)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            if (color1 == 8)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            if (color1 == 9)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (color1 == 10)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (color1 == 11)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            if (color1 == 12)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (color1 == 13)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            if (color1 == 14)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (color1 == 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.Clear();
            System.Threading.Thread.Sleep(5000);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
