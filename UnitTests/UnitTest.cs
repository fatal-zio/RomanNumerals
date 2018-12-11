using NUnit.Framework;
using RomanNumerals.Entities;
using RomanNumerals.Logic;

namespace Tests
{
    public class Tests
    {
        private RomanNumeralEvaluationStrategy _strategy;

        [SetUp]
        public void Setup() => _strategy = new RomanNumeralEvaluationStrategy();

        [Test]
        public void Translate1990()
        {
            Assert.AreEqual("MCMXC", new RomanNumeral(1990, _strategy).Text);
        }

        [Test]
        public void Translate2008()
        {
            Assert.AreEqual("MMVIII", new RomanNumeral(2008, _strategy).Text);
        }

        [Test]
        public void Translate99()
        {
            Assert.AreEqual("XCIX", new RomanNumeral(99, _strategy).Text);
        }

        [Test]
        public void Translate47()
        {
            Assert.AreEqual("XLVII", new RomanNumeral(47, _strategy).Text);
        }
    }
}