using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW
{
    class Program
    {
        static int maxchisl(int a, int b)
        {
            return Math.Max(a, b);
        }

        static void mestznzch( ref int a ,ref int b)
        {
            int k = a;
            a = b;
            b = k;
        }

        static bool factorial(int a)
        {
            try
            {
                int b = 1;
                for (int i = 2; i < a; i++)
                {
                    b = checked((int)(b * i));
                }
                return true;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        static uint Recurtions(uint a)
        {
            try
            {
                if (a == 1 || a == 0)
                {
                    return 1;
                }
                else
                {
                    return a * Recurtions(a - 1);
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
                return 0;
            }
        }

        static int Nod(int a, int b)
        {
            while (a != b)
            {
                b = Math.Max(a, b) - Math.Min(a, b);
                a = Math.Min(a, b);
            }
            return a;
        }


        public static int Nod(int a, int b, int c)
        {
            int Nod = Math.Min(a, Math.Min(a, b));
            for (; Nod > 1; Nod--)
            {
                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0)
                    break;
            }
            return Nod;
        }

        static int Fap(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else if (a == 2)
            {
                return 1;
            }
            else if (a == 3)
            {
                return 2;
            }
            else if (a == 4)
            {
                return 3;
            }
            else
            {
                return (Fap(a - 1) + Fap(a - 2));
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
