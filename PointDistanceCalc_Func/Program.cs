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
            text = text.Trim(new char[] { '(', ')' });
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

        static void DistanceCalc(Point p1, Point p2)
        {
            //и тут я заплутал, не хватило сил самому разобраться как из этого метода заСЕТить иксы и игрики поинтов
            //поэтому получился у меня царь костыль =(

            //т.е. метод тупо вставляет значения в формулу...
            double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            Console.WriteLine("\nРасстояние между точками составляет {0:N2} единиц", distance);
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
            Console.WriteLine("\n\tЧтобы узнать расстояние между точками\n\tвводите координаты в формате: (23,-37)");
            for (int i = 0; i < 2; i++)
            {
                answers[i] = Question(questions[i]);

            }

            point1.X = CoordinatesParser(answers[0], 0);
            point1.Y = CoordinatesParser(answers[0], 1);
            point2.X = CoordinatesParser(answers[1], 0);
            point2.Y = CoordinatesParser(answers[1], 1);

            DistanceCalc(point1, point2);

            Console.ReadKey();
        }
    }
}
