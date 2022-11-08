using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class MoneyTests
    {
        /*=================================TA-01_YurchenkoVasyl=============================*/
        [Theory]
        [InlineData(0,0,0,0,0,0.0)]
        [InlineData(0, 1, 0, 0, 0, 0.0)]
        [InlineData(0, 0, 1, 0, 0, 0.0)]
        [InlineData(0, 0, 0, 1, 0, 0.0)]
        [InlineData(0, 0, 0, 0, 1, 0.0)]
        [InlineData(0, 0, 0, 0, 0, 1.0)]
        public void operatorravno_returnravno(int oneCent, int tenCent,int quarter, int oneDollar, int fiveDollar, int twentyDollar)
        {
            var sut_1 = new Money(oneCent, tenCent, quarter, oneDollar, fiveDollar, twentyDollar);
            var sut_2 = new Money(oneCent, tenCent, quarter, oneDollar, fiveDollar, twentyDollar);

            bool expected = true;

            Assert.Equal(expected,sut_1 == sut_2);
        }
        [Fact]
        public void operatorneravno_returnneravno()
        {
            var sut_1 = new Money(0, 0, 0, 1, 0, 0);
            var sut_2 = new Money(0, 0, 0, 0, 1, 0);

            bool expected = true;

            Assert.Equal(expected, sut_1 != sut_2);
        }
        /*==================================================================================*/
    }
}