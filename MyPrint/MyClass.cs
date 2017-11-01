using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrint
{
    public class MyClass
    {
        public static void Print(string str, int x, int y)
        {
            string finaly = "";
            Console.SetCursorPosition(x, y);
            finaly += str;
            Console.WriteLine(finaly);
        }
        public static void Print(string str)
        {
            string finaly = "";
            finaly += str;
            Console.WriteLine(finaly);
        }

        public static void Pause(int seconds = 1)
        {
            //ЗАРИСОВКА НА БУДУЩЕЕ, ПОКА ХЕНДЛЕР НЕ ПОНИМАЮ
            //if (seconds == 0)
            //{
            //    Console.WriteLine("\n\nВключена пауза.\nНажатие любой клавиши продолжит работу\n\n");
            //    bool b = true;
            //    int i = 0;
            //    while (b)
            //    {
            //        System.Threading.Thread.Sleep(i++);
            //        EventHandler
            //    }
            //}
            //else
            //{
            Console.WriteLine("\n\nВключена пауза на {0} секунд\n\n", seconds);
            System.Threading.Thread.Sleep(seconds * 1000);
            //}    
        }
    }
}
