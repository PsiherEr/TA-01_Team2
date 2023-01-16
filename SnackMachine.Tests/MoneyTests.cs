using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class MoneyTests
    {
        [Theory]
        [InlineData(1, 0, 0, 0, 0, 0)]
        [InlineData(0, 1, 0, 0, 0, 0)]
        [InlineData(0, 0, 1, 0, 0, 0)]
        [InlineData(0, 0, 0, 1, 0, 0)]
        [InlineData(0, 0, 0, 0, 1, 0)]
        [InlineData(0, 0, 0, 0, 0, 1)]
        public void OperatorPlus(int oneCentCount, int tenCentCount, int quarterCount, int oneDollarCount, int fiveDollarCount, int twentyDollarCount)
        {
            var sut_1 = new Money(oneCentCount, tenCentCount, quarterCount, oneDollarCount, fiveDollarCount, twentyDollarCount);
            var sut_2 = new Money(oneCentCount, tenCentCount, quarterCount, oneDollarCount, fiveDollarCount, twentyDollarCount);
            decimal expected = 2*(oneCentCount * 0.01m + tenCentCount * 0.10m + quarterCount * 0.25m + oneDollarCount + fiveDollarCount * 5 + twentyDollarCount * 20);
            Assert.Equal(expected, (sut_1 + sut_2).Amount);
        }

        [Theory]
        [InlineData(1, 0, 0, 0, 0, 0)]
        [InlineData(0, 1, 0, 0, 0, 0)]
        [InlineData(0, 0, 1, 0, 0, 0)]
        [InlineData(0, 0, 0, 1, 0, 0)]
        [InlineData(0, 0, 0, 0, 1, 0)]
        [InlineData(0, 0, 0, 0, 0, 1)]
        public void OperatorMinus(int oneCentCount, int tenCentCount, int quarterCount, int oneDollarCount, int fiveDollarCount, int twentyDollarCount)
        {
            var sut_1 = new Money(oneCentCount, tenCentCount, quarterCount, oneDollarCount, fiveDollarCount, twentyDollarCount);
            var sut_2 = new Money(oneCentCount, tenCentCount, quarterCount, oneDollarCount, fiveDollarCount, twentyDollarCount);
            decimal expected = 0;
            Assert.Equal(expected, (sut_1 - sut_2).Amount);
        }
    }
}