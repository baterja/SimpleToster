using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleToster.QuestionsDatabase.Providers;
using SimpleToster.QuestionsDatabase.QuestionsTypes;
using SimpleToster.QuestionsDatabase.Tests.Properties;

namespace SimpleToster.QuestionsDatabase.Tests
{
    [TestClass]
    public class SimpleStringTestQuestionTests
    {
        [TestMethod]
        public void XmlSerializationTest()
        {
            var question = "To be or not?";
            var possibleAnswers = new HashSet<string>(new[] {"a", "b", "c", "d"});
            var goodAnswer = possibleAnswers.First();

            var test = new SimpleStringTestQuestion(question, possibleAnswers, goodAnswer);

            var serializer = new XmlSerializer(typeof(SimpleStringTestQuestion));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (var writer = XmlWriter.Create(sww))
                {
                    serializer.Serialize(writer, test);
                    xml = sww.ToString(); // Your XML
                }
            }
        }

        [TestMethod]
        public void SimpleTesterDeserializationTest()
        {
            var filepath = "./Resources/SimpleTesterWI.txt";
            var provider = new QuestionsFromSimpleTesterProvider(filepath);
            var test = provider.GetQuestions().ToList();
        }
    }
}
