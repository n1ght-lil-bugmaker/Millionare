using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionare.Model
{
    class Level
    {
        public Question CurrentQuestion { get; private set; }
        public Level(Question question)
        {
            this.CurrentQuestion = question;
        }
        public bool CheckAnswer(int indexOfAnswer)
        {
            return CurrentQuestion.IsAnswerCorrect(indexOfAnswer);
        }

    }
}
