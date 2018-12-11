using NUnit.Framework;
using RomanNumerals.Logic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Translate1990()
        {
            var evaluator = new RomanNumeralEvaluator();

            Assert.AreEqual("MCMXC", evaluator.Evaluate(1990));
        }

        [Test]
        public void Translate2008()
        {
            var evaluator = new RomanNumeralEvaluator();

            Assert.AreEqual("MMVIII", evaluator.Evaluate(2008));
        }

        [Test]
        public void Translate99()
        {
            var evaluator = new RomanNumeralEvaluator();

            Assert.AreEqual("XCIX", evaluator.Evaluate(99));
        }

        [Test]
        public void Translate47()
        {
            var evaluator = new RomanNumeralEvaluator();

            Assert.AreEqual("XLVII", evaluator.Evaluate(47));
        }
    }
}