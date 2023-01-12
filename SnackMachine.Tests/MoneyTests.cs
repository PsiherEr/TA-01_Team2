using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void OperatorPlus()
        {
            var sut_1 = new Money(0, 1, 0, 0, 0, 0);
            var sut_2 = new Money(0, 0, 1, 0, 0, 0);
            decimal expected = 0.35m;
            Assert.Equal(expected, (sut_1 + sut_2).Amount);
        }

        [Fact]
        public void OperatorMinus()
        {
            var sut_1 = new Money(0, 0, 0, 0, 2, 0);
            var sut_2 = new Money(0, 0, 0, 0, 1, 0);
            decimal expected = 5m;
            Assert.Equal(expected, (sut_1 - sut_2).Amount);
        }
    }
}