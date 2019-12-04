using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Question : IQuestion
    {
        public string question { get; set; }
        public string answer { get; set; }
        public int grade { get; set; }
        public string category { get; set; }

        public void SetText(String questionText)
        {
            question = questionText;
        }

        public void SetAnswer(String correctResponse)
        {
            answer = correctResponse;
        }

        public void SetGrade(int currentGrade)
        {
            grade = currentGrade;
        }

        public void SetCategory(String currentCategory)
        {
            category = currentCategory;
        }

        public bool CheckAnswer(string response)
        {
            return response.Equals(answer);
        }

        public void Display()
        {
            Console.WriteLine(question);
        }
    }
}
