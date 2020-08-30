using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Millionare.Model
{
    class Question
    {
        public string QuestionText { get; private set; }
        public string[] Options { get; private set; }
        public int IndexOfCorrectAnswer { get; private set; }
        public Question(string QuestionText, IEnumerable<string> Options, int IndexOfCorrectAnswer)
        {
            if(Options.Count() != 4)
            {
                throw new NotImplementedException("You must give only 4 options");
            }

            this.Options = new string[4];

            int index = 0;
            foreach(var option in Options)
            {
                this.Options[index] = option;
                index++;
            }

            this.QuestionText = QuestionText;
            this.IndexOfCorrectAnswer = IndexOfCorrectAnswer;
        } 
        public bool IsAnswerCorrect(int IndexToCheck)
        {
            return IndexToCheck == IndexOfCorrectAnswer;
        }


    }
}
