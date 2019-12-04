using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleChoiceQuestion first = new MultipleChoiceQuestion();
            first.SetText("What was the original name of the Java language?");
            first.AddChoice("*7", false);
            first.AddChoice("Duke", false);
            first.AddChoice("Oak", true);
            first.AddChoice("Gosling", false);
            first.SetGrade(2);
            first.SetCategory("Knowledge");
            MultipleChoiceQuestion second = new MultipleChoiceQuestion();
            second.SetText("In which country was the inventor of Java born?");
            second.AddChoice("Australia", false);
            second.AddChoice("Canada", true);
            second.AddChoice("Denmark", false);
            second.AddChoice("United States", false);
            second.SetGrade(1);
            second.SetCategory("Common knowledge");
            Question third = new Question();
            third.SetText("What is this programming language called");
            third.SetAnswer("CSharp");
            third.SetGrade(1);
            third.SetCategory("Common knowledge");

            PresentQuestion(first);
            PresentQuestion(second);
            PresentQuestion(third);
        }

        public static void PresentQuestion(IQuestion q)
        {
            q.Display();
            Console.WriteLine(("Your answer: "));
            string response = Console.ReadLine();
            Console.WriteLine((q.CheckAnswer(response)));
        }
    }
}
