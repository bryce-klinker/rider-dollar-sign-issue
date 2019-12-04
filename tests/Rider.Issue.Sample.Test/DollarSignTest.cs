using Xunit;

namespace Rider.Issue.Sample.Test
{
    public class DollarSignTest
    {
        [Fact]
        public void ShouldReturnAmountInCurrencyFormat()
        {
            Assert.Equal("$3.98", Dollars.Format(3.98));
        }

        [Fact]
        public void ShouldReturnDollarSign()
        {
            Assert.Equal("$", Dollars.Sign());
        }
    }
}
