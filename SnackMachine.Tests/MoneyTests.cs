using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class MoneyTests
    {


        //Azin//

        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0)]
        [InlineData(1, 0, 0, 0, 0, 0)]
        [InlineData(0, 1, 0, 0, 0, 0)]
        [InlineData(0, 0, 1, 0, 0, 0)]
        [InlineData(0, 0, 0, 1, 0, 0)]
        [InlineData(0, 0, 0, 0, 1, 0)]
        [InlineData(0, 0, 0, 0, 0, 1)]
        public void MoneyConstructor(int cent, int tenCents, int quarter, int dollar, int fiveDollars, int twentyDollars)
        {
            var sut = new Money(cent, tenCents, quarter, dollar, fiveDollars, twentyDollars);
            bool expected = true;
            bool test = false;

            if(sut.OneCentCount == cent && sut.TenCentCount == tenCents && sut.QuarterCount == quarter && sut.OneDollarCount == dollar && sut.FiveDollarCount == fiveDollars && sut.TwentyDollarCount == twentyDollars)
            {
                test = true;
            }


            Assert.Equal(test, expected);

        }

        [Fact]
        public void MoneyConstructor_Amount()
        {
            var sut = new Money(1, 1, 1, 1, 1, 1);
            decimal expected = 26.36m;

            Assert.Equal(sut.Amount, expected);
   
        }

        //Azin//

    }
}