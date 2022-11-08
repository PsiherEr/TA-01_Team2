using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void MoneyConstructor_Amount()
        {
            var sut = new Money(1, 1, 1, 1, 1, 1);
            decimal expected = 26.36m;

            Assert.Equal(sut.Amount, expected);
   
        }
    }
}