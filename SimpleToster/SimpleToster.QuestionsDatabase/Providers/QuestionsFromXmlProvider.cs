using System.Collections.Generic;
using SimpleToster.Shared.Interfaces;

namespace SimpleToster.QuestionsDatabase.Providers
{
    internal class QuestionsFromXmlProvider : IQuestionsProvider<IQuestion>
    {
        private readonly string filePath;

        internal QuestionsFromXmlProvider(string filePath)
        {
            this.filePath = filePath;
        }

        public IEnumerable<IQuestion> GetQuestions()
        {
            return null;
        }
    }
}