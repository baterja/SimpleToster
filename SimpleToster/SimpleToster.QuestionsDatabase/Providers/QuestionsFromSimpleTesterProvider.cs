using System.Collections.Generic;
using System.IO;
using SimpleToster.QuestionsDatabase.QuestionsTypes;
using SimpleToster.Shared.Interfaces;

namespace SimpleToster.QuestionsDatabase.Providers
{
    public class QuestionsFromSimpleTesterProvider : IQuestionsProvider<SimpleStringTestQuestion>
    {
        private readonly string filePath;

        public QuestionsFromSimpleTesterProvider(string filePath)
        {
            this.filePath = filePath;
        }

        public IEnumerable<SimpleStringTestQuestion> GetQuestions()
        {
            using (var reader = File.OpenText(this.filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    while (string.IsNullOrWhiteSpace(line))
                    {
                        line = reader.ReadLine();
                    }

                    var question = line;
                    var numberOfPossibleAnswersString = reader.ReadLine();
                    var numberOfPossibleAnswers = int.Parse(numberOfPossibleAnswersString);

                    var possibleAnswers = new List<string>();
                    for (var i = 0; i < numberOfPossibleAnswers; i++)
                    {
                        var currentQuestion = reader.ReadLine();
                        possibleAnswers.Add(currentQuestion);
                    }

                    var orderOfGoodAnswer = int.Parse(reader.ReadLine()) - 1;
                    // bo w formacie występuje numerowanie od 1 zamiast od 0
                    var goodAnswer = possibleAnswers[orderOfGoodAnswer];

                    var setOfPossibleAnswers = new HashSet<string>(possibleAnswers);
                    var simpleStringTestQuestion = new SimpleStringTestQuestion(question, setOfPossibleAnswers,
                        goodAnswer);

                    yield return simpleStringTestQuestion;
                }
            }
        }
    }
}