using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPrint;

namespace Task6_prints
{
    class Program
    {
        //public static void Print(string str)
        //{
        //    Console.WriteLine(str);
        //}

        //public static void Print(string str, string position)
        //{
        //    if (position == "mid")
        //    {
        //        Console.WriteLine("{0,50}", str);
        //    }
        //}

        public static void PrintKostyl(string str, int mid_x = 0, int mid_y = 0, int clear = 0)
        {
            int width = Console.WindowWidth;
            int length = str.Length;
            int height = Console.WindowHeight;
            int midX = (width - length) / 2;
            int midY = height / 2;
            string finaly = "";

            if (clear == 1)
            {
                Console.Clear();
            }

            if ((mid_x == 1) && (mid_y == 1))
            {
                for (int i = 0; i < midY - 1; i++)
                {
                    finaly += "\n";
                }

                for (int i = 0; i < midX; i++)
                {
                    finaly += " ";
                }
            }
            else if (mid_x == 1)
            {
                for (int i = 0; i < midX; i++)
                {
                    finaly += " ";
                }
            }
            else if (mid_y == 1)
            {
                for (int i = 0; i < midY - 1; i++)
                {
                    finaly += "\n";
                }
            }

            finaly += str;
            Console.WriteLine(finaly);
        }

        static void Main(string[] args)
        {
            string name = "Денис", surname = "Евдохин", city = "Москва";
            //Print($"{name}, {surname}, {city}");

            //Print($"{name}, {surname}, {city}", "mid");

            //Print($"{name}, {surname}, {city}", 10, 0);

            //int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine());

            //MyClass.Print(($"{name}, {surname}, {city}"), a, b);
            //PrintKostyl(($"{name}, {surname}, {city}"), a, b, c);

            MyClass.Print($"{name} {surname}, {city}\n\nвыводится через метод из библиотеки\n\nследующая строка выводится методом из этой программы по середине экрана\n");
            Console.ReadKey();
            PrintKostyl($"{name} {surname}, {city}", 1);
            MyClass.Print("\nследующая по середине вертикали, но правильно\nработает только если экран перевоначально пуст\n");
            Console.ReadKey();
            PrintKostyl($"{name} {surname}, {city}", 0, 1);
            MyClass.Print("\nследующая по середине по вертикали консоли с пред очисткой\n");
            Console.ReadKey();
            PrintKostyl($"{name} {surname}, {city}", 0, 1, 1);
            MyClass.Print("\nследующая по середине консоли с пред очисткой\n");
            Console.ReadKey();
            PrintKostyl($"{name} {surname}, {city}", 1, 1, 1);
            MyClass.Pause(10);
        }
    }
}
