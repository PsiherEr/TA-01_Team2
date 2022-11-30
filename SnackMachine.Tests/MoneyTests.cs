using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class MoneyTests
    {
        /*=================================TA-01_YurchenkoVasyl=============================*/
        [Fact]
        public void operatorravno_notnull_returntrue()
        {
            var sut_1 = new Money(0, 1, 0, 0, 0, 0);
            var sut_2 = new Money(0, 1, 0, 0, 0, 0);

            bool expected = true;
            Assert.Equal(expected, sut_1 == sut_2);

        }
        [Fact]
        public void operatorravno_nullornotnull_returnfalse()
        {
            var sut_1 = new Money(0, 1, 0, 0, 0, 0);
            Money sut_2 = null;

            bool expected = false;
            Assert.Equal(expected, sut_1 == sut_2);

        }
        [Fact]
        public void operatorravno_nullandnotnull_returntrue()
        {
            Money sut_1 = null;
            Money sut_2 = null;

            bool expected = true;
            Assert.Equal(expected, sut_1 == sut_2);

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