using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleToster.QuestionsDatabase.QuestionsTypes;

namespace SimpleToster.QuestionsDatabase.Tests
{
    [TestClass]
    public class SimpleStringTestQuestionTests
    {
        [TestMethod]
        public void XmlSerializationTest()
        {
            var possibleAnswers = new HashSet<string>(new[] {"a", "b", "c", "d"});
            var goodAnswer = possibleAnswers.First();

            var test = new SimpleStringTestQuestion(possibleAnswers, goodAnswer);

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
    }
}
