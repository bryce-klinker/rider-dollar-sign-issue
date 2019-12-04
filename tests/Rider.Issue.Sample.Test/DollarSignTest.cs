using System;
using Xunit;

namespace Rider.Issue.Sample.Test
{
    public class DollarSignTest
    {
        [Fact]
        public void ShouldReturnDollarSign()
        {
            Assert.Equal("$3.98", Dollars.Get(3.98));
        }
    }
}
