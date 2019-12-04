using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class MultipleChoiceQuestion : IQuestion
    {
        public List<string> choices;
        public string question { get; set; }
        public string answer { get; set; }
        public int grade { get; set; }
        public string category { get; set; }

        public MultipleChoiceQuestion()
        {
            choices = new List<string>();
        }
        public void SetText(String questionText)
        {
            question = questionText;
        }

        public void SetAnswer(String correctResponse)
        {
            answer = correctResponse;
        }

        public bool CheckAnswer(string response)
        {
            return response.Equals(answer);
        }

        public void SetGrade(int currentGrade)
        {
            grade = currentGrade;
        }

        public void SetCategory(String currentCategory)
        {
            category = currentCategory;
        }

        public void AddChoice(String choice, bool correct)
        {
            choices.Add(choice);
            if (correct)
            {
                answer = choice;
            }
        }

        public void Display()
        {
            Console.WriteLine(question);
            for (int i = 0; i < choices.Count(); i++)
            {
                int choiceNumber = i + 1;
                Console.WriteLine(choiceNumber + ": " + choices[i]);
            }
        }
    }
}
