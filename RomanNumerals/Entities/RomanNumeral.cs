using RomanNumerals.Logic;

namespace RomanNumerals.Entities
{
    public class RomanNumeral
    {

        public RomanNumeral(int number, EvaluationStrategy strategy)
        {
            Number = number;
            Text = strategy.Evaluate(number);
        }

        public string Text { get; private set; }
        public int Number { get; private set; }

    }
}
