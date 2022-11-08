using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class SnackMachineTests
    {
        [Fact]
        public void CheckHowMoneyIsInserted()
        {
            //Arrange
            var sut = new SnackMachineLogic.SnackMachine();
            var insertedmoney = new Money(0, 0, 0, 0, 0, 1);
            decimal expected = 20m;

            //Act
            sut.InsertMoney(insertedmoney);

            //Assert
            Assert.Equal(expected, sut.MoneyInTransaction.Amount);
        }

        [Fact]
        public void CheckHowMoneyIsInserted_UsingFewBills()
        {
            var sut = new SnackMachineLogic.SnackMachine();
            decimal expected = 1.05m;

            sut.InsertMoney(Money.Dollar);
            for (int i = 0; i < 5; i++)
            {
                sut.InsertMoney(Money.Cent);
            }

            Assert.Equal(sut.MoneyInTransaction.Amount, expected, 2);
        }

        [Fact]
        public void CheckIfMoneyIsReturned()
        {
            //Arrange
            var sut = new SnackMachineLogic.SnackMachine();
            var insertedmoney = new Money(1, 0, 0, 0, 0, 0);
            decimal expected = 0m;

            //Act
            sut.InsertMoney(insertedmoney);
            sut.ReturnMoney();

            //Assert
            Assert.Equal(expected, sut.MoneyInside.Amount);
        }

        [Fact]
        public void CheckIfSnackIsBought()
        {
            //Arrange
            var sut = new SnackMachineLogic.SnackMachine();
            var insertedmoney = new Money(0, 0, 1, 0, 0, 0);
            decimal expected = 0.25m;

            //Act
            sut.InsertMoney(insertedmoney);
            sut.BuySnack();

            //Assert
            Assert.Equal(expected, sut.MoneyInside.Amount);
        }
    }
}