using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Millionare.Model
{
    class Game
    {
        public Hint[] hints { get; private set; }
        public int Balance { get; private set; }

        public Level CurrentLevel { get; private set; }
        public Game()
        {
            hints = new Hint[] { new Hint(), new Hint(), new Hint() };
            Balance = 0;
        }

        public event Func<Level> GetLevel;
        public event Action EndGame;
        public event Action NewLevel;
        public event Func<int> GetAnswer;

        public async void Start()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    CurrentLevel = GetLevel();
                    NewLevel();
                    var Answer = GetAnswer();

                    if (CurrentLevel.CheckAnswer(Answer))
                    {
                        Balance += 100;
                    }
                    else
                    {
                        EndGame();
                        break;
                    }

                }
            });
        }

        public (string First, string Second) Get2IncorrectAnswers(int correctAnswer)
        {
            int first, second;
            int tmp;
            Random random = new Random();
            string firstToReturn = "", secondToReturn = "";

            tmp = random.Next(1, 5);

            while (tmp == correctAnswer)
            {
                tmp = random.Next(1, 5);
            }
            first = tmp;

            tmp = random.Next(0, 4);

            while (tmp == correctAnswer || tmp == first)
            {
                tmp = random.Next(0, 4);
            }
            second = tmp;

            if (first == 0)
            {
                firstToReturn = "answer0";
            }
            else if (first == 1)
            {
                firstToReturn = "answer1";
            }
            else if (first == 2)
            {
                firstToReturn = "answer2";
            }
            else if (first == 3)
            {
                firstToReturn = "answer3";
            }

            if (second == 0)
            {
                secondToReturn = "answer0";
            }
            else if (second == 1)
            {
                secondToReturn = "answer1";
            }
            else if (second == 2)
            {
                secondToReturn = "answer2";
            }
            else if (second == 3)
            {
                secondToReturn = "answer3";
            }

            return (firstToReturn, secondToReturn);
        }

        public (int First, int Second, int Third, int Fourth) RandomizeHelp()
        {
            int First, Second, Third, Fourth;

            var random = new Random();

            First = random.Next(0, 100);
            Second = random.Next(0, 100 - First);
            Third = random.Next(0, 100 - First - Second);
            Fourth = 100 - First - Second - Third;


            var Correct = Math.Max(Math.Max(First, Second), Math.Max(Third, Fourth));

            if(CurrentLevel.CurrentQuestion.IndexOfCorrectAnswer == 0)
            {
                if(Correct == First)
                {
                    return (Correct, Second, Third, Fourth);
                }
                else if(Correct == Second)
                {
                    return (Correct, First, Third, Fourth);
                }
                else if(Correct == Third)
                {
                    return (Correct, Second, First, Fourth);
                }
                else if(Correct == Fourth)
                {
                    return (Correct, First, Second, Fourth);
                }
            }
            else if (CurrentLevel.CurrentQuestion.IndexOfCorrectAnswer == 1)
            {
                if (Correct == First)
                {
                    return (Second, Correct, Third, Fourth);
                }
                else if (Correct == Second)
                {
                    return (First, Correct, Third, Fourth);
                }
                else if (Correct == Third)
                {
                    return (Second, Correct, First, Fourth);
                }
                else if (Correct == Fourth)
                {
                    return (First, Correct, Second, Fourth);
                }
            }
            else if (CurrentLevel.CurrentQuestion.IndexOfCorrectAnswer == 2)
            {
                if (Correct == First)
                {
                    return (Second, Third, Correct, Fourth);
                }
                else if (Correct == Second)
                {
                    return (First, Third, Correct, Fourth);
                }
                else if (Correct == Third)
                {
                    return (Second, First, Correct, Fourth);
                }
                else if (Correct == Fourth)
                {
                    return (First, Second, Correct, Fourth);
                }
            }
            else if (CurrentLevel.CurrentQuestion.IndexOfCorrectAnswer == 3)
            {
                if (Correct == First)
                {
                    return (Second, Third, Fourth, Correct);
                }
                else if (Correct == Second)
                {
                    return (First, Third, Fourth, Correct);
                }
                else if (Correct == Third)
                {
                    return (Second, First, Fourth, Correct);
                }
                else if (Correct == Fourth)
                {
                    return (First, Second, Third, Correct);
                }
            }
            throw new Exception();

        }

        public int GetIncorectAnswer(int correct)
        {
            Random random = new Random();

            var res = random.Next(0, 4);

            while(res == correct)
            {
                res = random.Next(0, 4);
            }

            return res;
        }
    }

}
