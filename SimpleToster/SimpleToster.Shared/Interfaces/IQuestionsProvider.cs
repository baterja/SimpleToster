using System.Collections.Generic;

namespace SimpleToster.Shared.Interfaces
{
    public interface IQuestionsProvider<out T> where T : IQuestion
    {
        IEnumerable<T> GetQuestions();
    }
}