using System.Collections.Generic;

namespace SimpleToster.Shared.Interfaces
{
    public interface IQuestionnaire<T> where T : IQuestion
    {
        ICollection<T> Questions { get; }
    }
}