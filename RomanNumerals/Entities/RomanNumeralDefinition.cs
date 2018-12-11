namespace RomanNumerals.Entities
{
    public class RomanNumeralDefinition
    {
        public RomanNumeralDefinition(int rank, int number, string text)
        {
            Value = number;
            Text = text;
        }

        public int Rank { get; private set; }
        public int Value { get; private set; }
        public string Text { get; private set; }
    }
}
