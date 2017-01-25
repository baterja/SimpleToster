﻿using System.Collections.Generic;
using System.Diagnostics;
using SimpleToster.Shared.Interfaces;

namespace SimpleToster.QuestionsDatabase.QuestionsTypes
{
    public class SimpleStringTestQuestion : ISingleChoiceQuestion<string>
    {
        private readonly string goodAnswer;

        private string chosenAnswer;

        public SimpleStringTestQuestion(ISet<string> possibleAnswers, string goodAnswer)
        {
            this.PossibleAnswers = possibleAnswers;
            this.goodAnswer = goodAnswer;
        }

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