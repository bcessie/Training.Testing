using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.Testing.Domain;

namespace Training.Testing.Tests
{
    [TestClass]
    public class PhraseUnitTest
    {
        [TestMethod]
        public void IsValid()
        {
            Phrase phrase = new Phrase() { Sentence = "Bond, James Bond" };
            Assert.IsTrue(phrase.IsValid());
        }

        [TestMethod]
        public void IsNotValid()
        {
            Phrase phrase = new Phrase() { Sentence = "" };
            Assert.IsFalse(phrase.IsValid());
        }

        [TestMethod]
        public void IsNotValid_Space()
        {
            Phrase phrase = new Phrase() { Sentence = "                          " };
            Assert.IsFalse(phrase.IsValid());
        }
    }
}
