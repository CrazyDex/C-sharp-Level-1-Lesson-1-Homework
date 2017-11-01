using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pause
{
    class Program
    {
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

        static void Main(string[] args)
        {
            //тестик

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("asdasd " + i);
            //    Pause(5);
            //}
        }
    }
}
