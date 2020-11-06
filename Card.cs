using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PlumpTest
{
    class Card
    {

        private int value;
        private int color;
        private string colorName;

        private readonly string[] valueNames = new string[] {
        "ACE",
        "ONE",
        "TWO",
        "THREE",
        "FOUR",
        "FIVE",
        "SIX",
        "SEVEN",
        "EIGHT",
        "NINE",
        "TEN",
        "KNIGHT",
        "QUEEN",
        "KING"};

        public Card(int value, Tuple<int, string> color)
        {
            this.value = value;
            this.color = color.Item1;
            colorName = color.Item2;
        }

        public string toString()
        {
            return valueNames[value - 1] + " of " + colorName;
        }
    }
}
