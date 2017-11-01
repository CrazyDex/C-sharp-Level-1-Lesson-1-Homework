using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
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
                "Имя: ",
                "Фамилия: ",
                "Возраст: ",
                "Рост: ",
                "Вес: "
            };

            string[] answers = new string[questions.Length];
            string taskA = "", taskB = "", taskC = "";

            Console.WriteLine("\n\tПожалуйста заполните анкету.");
            for (int i = 0; i < 5; i++)
            {
                answers[i] = Question(questions[i]);
                taskA += answers[i] + " ";
            }
            taskB = string.Format("{0} {1} {2} {3} {4}", answers[0], answers[1], answers[2], answers[3], answers[4]);
            taskC = $"{answers[0]} {answers[1]} {answers[2]} {answers[3]} {answers[4]}";

            Console.Write("\n Вариант а: ");
            Console.WriteLine(taskA);

            Console.Write("\n Вариант б: ");
            Console.WriteLine(taskB);

            Console.Write("\n Вариант в: ");
            Console.WriteLine(taskC);

            Console.ReadKey();
        }
    }
}
