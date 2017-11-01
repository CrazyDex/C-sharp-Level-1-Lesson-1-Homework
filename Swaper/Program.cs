using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи два числа чтобы поменять их местами");
            int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine());
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);

            int temp = y;
            y = x;
            x = temp;
            Console.WriteLine("вариант через 3ю переменную");
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);
            
            //ВНИМАНИЕ!!! т.к. я не заставляю ТУТ пользователя повторно вводить два числа,
            //то они меняются на обратно на тот порядок как их вводил пользователь
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("вариант без 3й переменной");
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);

            Console.WriteLine("Как бы бонус, через массив, только не понимаю,\nможно ли назвать данный способ без 3й переменной...\n\nи да... тут вновь надо ввести два числа, так-то...");
            int[] ar = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
            Console.WriteLine("ar[0]={0}", ar[0]);
            Console.WriteLine("ar[1]={0}", ar[1]);
            ar.Reverse();
            Console.WriteLine("ar[0]={0}", ar[0]);
            Console.WriteLine("ar[1]={0}", ar[1]);

            Console.ReadKey();
        }
    }
}
