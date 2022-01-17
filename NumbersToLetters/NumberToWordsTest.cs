using System;
using System.Linq;
using Xunit;

namespace NumbersToLetters
{
    public class NumberToWordsTest
    {
        [Fact]
        public void TestNumbersToWords()
        {
            Assert.Throws<Exception>(() => new NumbersToLetters("1000009"));

        }

    }
}
