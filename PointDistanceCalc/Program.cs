using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDistanceCalc
{
    class Program
    {
        static string Question(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n {0}", text);
            Console.ResetColor();
            string answer = Console.ReadLine();
            return answer;
        }

        static int CoordinatesParser(string text, int os)
        {
            text = text.Trim(new char[] { '(', ')'});
            int numCh = text.IndexOf(',');
            if (os == 0) { return int.Parse(text.Substring(0, numCh)); }
            else if (os == 1) { return int.Parse(text.Substring(numCh + 1)); }
            else { return 0; }
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            string[] questions = new string[]
            {
                "Координаты первой точки: ",
                "Координаты второй точки: "
            };

            string[] answers = new string[questions.Length];

            //просто для разнообразия
            Console.WriteLine("\n\tЧтобы узнать расстояние между точками вводите координаты в формате: (23,-37)");
            for (int i = 0; i < 2; i++)
            {
                answers[i] = Question(questions[i]);

            }

            point1.X = CoordinatesParser(answers[0], 0);
            point1.Y = CoordinatesParser(answers[0], 1);
            point2.X = CoordinatesParser(answers[1], 0);
            point2.Y = CoordinatesParser(answers[1], 1);

            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

            //вариант а
            Console.WriteLine("\nРасстояние между точками составляет {0:N2} единиц", distance);

//            Console.WriteLine("{0},{1}", point1.X, point1.Y);
//            Console.WriteLine("{0},{1}", point2.X, point2.Y);

            Console.ReadKey();
        }
    }
}
