using System;
using Xunit;
using War;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("h-4", "Four of Hearts")]
        [InlineData("h-10", "Ten of Hearts")]
        [InlineData("h-14", "Ace of Hearts")]
        [InlineData("d-2", "Two of Diamonds")]
        [InlineData("d-4", "Four of Diamonds")]
        [InlineData("d-10", "Ten of Diamonds")]
        [InlineData("d-13", "King of Diamonds")]
        [InlineData("c-4", "Four of Clubs")]
        [InlineData("c-10", "Ten of Clubs")]
        [InlineData("c-13", "King of Clubs")]
        [InlineData("s-4", "Four of Spades")]
        [InlineData("s-10", "Ten of Spades")]
        [InlineData("s-14", "Ace of Spades")]
        private static void testCardDisplay(string value, string expectedValue)
        {
            Assert.Equal(expectedValue, CardWars.CardDisplay(value));
        }
    }
}
