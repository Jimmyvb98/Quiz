using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public interface IQuestion
    {
        string question { get; set; }
        string answer { get; set; }
        int grade { get; set; }
        string category { get; set; }

        void SetText(String questionText);
        void SetAnswer(String correctResponse);
        void SetGrade(int currentGrade);
        void SetCategory(String currentCategory);
        bool CheckAnswer(string response);
        void Display();
    }
}
