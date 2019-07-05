using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Training.Testing.Data;
using Training.Testing.Repo;

namespace Training.Testing.Tests
{
    [TestClass]
    public class PhraseMockTest
    {
        private static Mock<PhraseContext> _context;
        private static Mock<DbSet<Phrase>> _mockSet;

        private static PhraseRepo _phraseRepo;

        private static string _newSentence = "Change is as good as a holdiay";

        private static Phrase _newPhrase = new Phrase() { Id = 1, Sentence = _newSentence };

        private static IQueryable<Phrase> phrases = new List<Phrase>() {
            new Phrase() { Sentence = "Nothing tastes like Fresca!" },
            new Phrase() { Sentence = "How many wood would a woodchuck chuck" },
            new Phrase() { Sentence = "Live is like a box of chocolates" },
            new Phrase() { Sentence = "Oh my ears and whiskers!" }
        }.AsQueryable();


        [ClassInitialize]
        public static void Init(TestContext context)
        {
            _context = new Mock<PhraseContext>();

            _mockSet = new Mock<DbSet<Phrase>>();
            _mockSet.As<IQueryable<Phrase>>().Setup(m => m.Provider).Returns(phrases.Provider);
            _mockSet.As<IQueryable<Phrase>>().Setup(m => m.Expression).Returns(phrases.Expression);
            _mockSet.As<IQueryable<Phrase>>().Setup(m => m.ElementType).Returns(phrases.ElementType);
            _mockSet.As<IQueryable<Phrase>>().Setup(m => m.GetEnumerator()).Returns(phrases.GetEnumerator());

            _context.Setup(p => p.Phrases).Returns(_mockSet.Object);

            _phraseRepo = new PhraseRepo(_context.Object);
        }

        [TestMethod]
        public void Add()
        {
            Phrase phrase = new Phrase() { Id = _newPhrase.Id, Sentence = _newPhrase.Sentence };
            Phrase latestPhrase = _phraseRepo.Add(phrase);

            Assert.IsTrue(latestPhrase.Id == _newPhrase.Id);

            _mockSet.Verify(m => m.Add(It.IsAny<Phrase>()), Times.Once());
            _context.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void Get()
        {
            IEnumerable<Phrase> latestPhrases = _phraseRepo.Get();

            Assert.IsTrue(latestPhrases.Count() == phrases.Count());
        }
    }
}
