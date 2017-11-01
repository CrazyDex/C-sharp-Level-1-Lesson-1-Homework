using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalc
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

        static void Main(string[] args)
        {
            string[] questions = new string[]
            {
                "Рост в см: ",
                "Вес в кг: "
            };

            string[] answers = new string[questions.Length];

            Console.WriteLine("\n\tПожалуйста заполните анкету чтобы узнать свой ИМТ.");
            for (int i = 0; i < 2; i++)
            {
                answers[i] = Question(questions[i]);
            }

            double height = double.Parse(answers[0]) / 100;
            double mass = double.Parse(answers[1]);
            double index = mass / Math.Pow(height, 2);

            Console.WriteLine(string.Format("\n Твой ИМТ {0:N2}", index));

            Console.ReadKey();
        }
    }
}
