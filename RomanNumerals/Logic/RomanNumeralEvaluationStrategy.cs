using System;
using System.Collections.Generic;
using System.Text;
using RomanNumerals.Entities;

namespace RomanNumerals.Logic
{
    public class RomanNumeralEvaluationStrategy : EvaluationStrategy
    {
        private List<RomanNumeralDefinition> _definitions;

        public RomanNumeralEvaluationStrategy()
        {
            CreateDefinitions();
        }

        private void CreateDefinitions()
        {
            _definitions = new List<RomanNumeralDefinition>
            {
                new RomanNumeralDefinition(0, 1000, "M"),
                new RomanNumeralDefinition(1, 900, "CM"),
                new RomanNumeralDefinition(2, 500, "D"),
                new RomanNumeralDefinition(3, 400, "CD"),
                new RomanNumeralDefinition(4, 100, "C"),
                new RomanNumeralDefinition(5, 90, "XC"),
                new RomanNumeralDefinition(6, 50, "L"),
                new RomanNumeralDefinition(7, 40, "XL"),
                new RomanNumeralDefinition(8, 10, "X"),
                new RomanNumeralDefinition(9, 9, "IX"),
                new RomanNumeralDefinition(10, 5, "V"),
                new RomanNumeralDefinition(11, 4, "IV"),
                new RomanNumeralDefinition(12, 1, "I")
            };
        }

        public override string Evaluate(int number)
        {
            if (number == 0) return string.Empty;
            if (number > 4000 || number < 0) throw new ArgumentOutOfRangeException();

            return ToRoman(number);
        }

        private string ToRoman(int number)
        {
            var sb = new StringBuilder();

            foreach (var definition in _definitions)
            {
                ProcessRomanNumeralDefinition(ref number, ref sb, definition);
            }

            return sb.ToString();
        }

        private void ProcessRomanNumeralDefinition(ref int number, ref StringBuilder sb, RomanNumeralDefinition def)
        {
            while (number >= def.Value)
            {
                if (number >= def.Value)
                {
                    sb.Append(def.Text);
                    number = number - def.Value;
                }
            }
        }
    }
}
