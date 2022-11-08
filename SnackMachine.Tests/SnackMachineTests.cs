using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class SnackMachineTests
    {
        [Fact]
        public void SnackMachineConstructor_MoneyInside()
        {
            var sut = new SnackMachineLogic.SnackMachine();

            Assert.Equal(sut.MoneyInside, Money.None);
        }

        [Fact]
        public void SnackMachineConstructor_MoneyInTransaction()
        {
            var sut = new SnackMachineLogic.SnackMachine();

            Assert.Equal(sut.MoneyInTransaction, Money.None);
        }

        
    }
}