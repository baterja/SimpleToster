using System.Collections.Generic;

namespace SimpleToster.Shared.Interfaces
{
    public interface ISingleChoiceQuestion<T> : IQuestion
    {
        bool? IsCorrect { get; }

        T ChosenAnswer { get; set; }

        ISet<T> PossibleAnswers { get; }
    }
}