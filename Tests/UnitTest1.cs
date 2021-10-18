using System;
using Xunit;
using TDDByExample;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.Equal(5, five.amount);
        }
    }
}
