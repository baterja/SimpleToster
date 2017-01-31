using System.Collections.Generic;
using System.Diagnostics;
using SimpleToster.Shared.Interfaces;

namespace SimpleToster.QuestionsDatabase.QuestionsTypes
{
    public class SimpleStringTestQuestion : ISingleChoiceQuestion<string>
    {
        private readonly string goodAnswer;

        private string chosenAnswer;

        public SimpleStringTestQuestion(string question, ISet<string> possibleAnswers, string goodAnswer)
        {
            this.Question = question;
            this.PossibleAnswers = possibleAnswers;
            this.goodAnswer = goodAnswer;
        }

        public string Question { get; }

        public string ChosenAnswer
        {
            get { return this.chosenAnswer; }
            set
            {
                if (this.PossibleAnswers.Contains(value))
                {
                    this.chosenAnswer = value;
                    this.IsCorrect = value == this.goodAnswer;
                }
                Debug.Fail("Ustawia coś z kosmosu zamiast z kolekcji opcji do wyboru.");
            }
        }

        public bool? IsCorrect { get; private set; }

        public ISet<string> PossibleAnswers { get; }
    }
}