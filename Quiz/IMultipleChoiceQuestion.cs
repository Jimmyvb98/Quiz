using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    interface IMultipleChoiceQuestion
    {
        string question { get; set; }
        string answer { get; set; }
        int grade { get; set; }
        string category { get; set; }

        void SetText(String questionText);
        void SetAnswer(String correctResponse);
        bool CheckAnswer(string response);
        void AddChoice(String choice, bool correct);
        void Display();
    }
}
