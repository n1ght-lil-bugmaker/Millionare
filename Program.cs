using Millionare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Threading;

namespace Millionare
{
    static class Program
    {
        
        static SqlConnection connection;
        static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Millionare\Database.mdf;Integrated Security=True";
        static HashSet<int> UsedID = new HashSet<int>();
        private static Level GetLevel()
        {
            Random random = new Random();
            var id = random.Next(1, 4);

            while (UsedID.Contains(id))
            {
                id = random.Next(1, 5);
            }
            UsedID.Add(id);
            
            if(UsedID.Count == 4)
            {
                UsedID.Clear();
            }


            SqlCommand command = new SqlCommand($"SELECT * FROM [QUESTIONS] WHERE Id = {id}", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();

                return new Level(new Question(
                    reader["QUESTION"].ToString(),
                    new string[]
                    {
                        reader["Answer_0"].ToString(),
                        reader["Answer_1"].ToString(),
                        reader["Answer_2"].ToString(),
                        reader["Answer_3"].ToString(),
                    },
                    int.Parse(reader["CorrectIndex"].ToString())));
            }
        }

        static void Main()
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();

            var form = new MainForm();
            var game = new Game();

            game.EndGame += () =>
            {
                var res = MessageBox.Show($"Игра окончена со счетом {game.Balance}\nПравильный ответ: " +
                    $"{game.CurrentLevel.CurrentQuestion.Options[game.CurrentLevel.CurrentQuestion.IndexOfCorrectAnswer]}", "Millionare");
                form.Close();
                connection.Close();
            };
            game.GetLevel += GetLevel;
            game.NewLevel += () =>
            {
                form.Controls["answer0"].Show();
                form.Controls["answer1"].Show();
                form.Controls["answer2"].Show();
                form.Controls["answer3"].Show();

                form.Controls["answer0"].Text = game.CurrentLevel.CurrentQuestion.Options[0];
                form.Controls["answer1"].Text = game.CurrentLevel.CurrentQuestion.Options[1];
                form.Controls["answer2"].Text = game.CurrentLevel.CurrentQuestion.Options[2];
                form.Controls["answer3"].Text = game.CurrentLevel.CurrentQuestion.Options[3];

                form.Controls["QuestionLabel"].Text = game.CurrentLevel.CurrentQuestion.QuestionText;
                form.Controls["BalanceLabel"].Text = game.Balance.ToString();

            };
            game.GetAnswer += form.GetAnswer;

            game.hints[0].ToUse += () =>
            {
                var incorrect = game.Get2IncorrectAnswers(game.CurrentLevel.CurrentQuestion.IndexOfCorrectAnswer);

                while (form.Controls[incorrect.First] == null || form.Controls[incorrect.Second] == null) { }

                form.Controls[incorrect.First].Hide();
                form.Controls[incorrect.Second].Hide();
            };
            game.hints[1].ToUse += () =>
            {
                Random random = new Random();

                var checker = random.Next(1, 101);

                if(checker <= 80)
                {
                    MessageBox.Show($"Мне кажется, что верный ответ - " +
                    $"{game.CurrentLevel.CurrentQuestion.Options[game.CurrentLevel.CurrentQuestion.IndexOfCorrectAnswer]}",
                    "Твой знающий друг");
                }
                else
                {
                    var result = game.GetIncorectAnswer(game.CurrentLevel.CurrentQuestion.IndexOfCorrectAnswer);

                    MessageBox.Show($"Мне кажется, что верный ответ - " +
                        $"{game.CurrentLevel.CurrentQuestion.Options[result]}", "Твой знающий друг");
                }
                
            };
            game.hints[2].ToUse += () =>
            {
                var result = game.RandomizeHelp();

                MessageBox.Show($"Результаты опроса зала" +
                    $"\n{game.CurrentLevel.CurrentQuestion.Options[0]}: {result.First}%" +
                    $"\n{game.CurrentLevel.CurrentQuestion.Options[1]}: {result.Second}%" +
                    $"\n{game.CurrentLevel.CurrentQuestion.Options[2]}: {result.Third}%" +
                    $"\n{game.CurrentLevel.CurrentQuestion.Options[3]}: {result.Fourth}%",
                    "Опрос зала");
            };

            form.Controls["hint0"].Click += (sender, args) =>
            {
                game.hints[0].Use();
                (sender as Button).Hide();
            };
            form.Controls["hint1"].Click += (sender, args) =>
            {
                game.hints[1].Use();
                (sender as Button).Hide();
            };
            form.Controls["hint2"].Click += (sender, args) =>
            {
                game.hints[2].Use();
                (sender as Button).Hide();
            };

            game.Start();
            Application.Run(form);
            
            
        }
    }
}
