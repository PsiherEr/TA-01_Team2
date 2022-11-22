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
            var expected = new Money(0, 1, 1, 0, 0, 0);
            Assert.Equal(expected, sut_1 + sut_2);
        }

        [Fact]
        public void OperatorMinus()
        {
            var sut_1 = new Money(0, 1, 0, 0, 0, 0);
            var sut_2 = new Money(0, 1, 0, 0, 0, 0);
            var expected = new Money(0, 0, 0, 0, 0, 0);
            Assert.Equal(expected, sut_1 - sut_2);
        }
    }
}