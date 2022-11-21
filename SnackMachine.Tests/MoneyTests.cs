using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class MoneyTests
    {
        /*=================================TA-01_YurchenkoVasyl=============================*/
        [Fact]
        public void operatorravno_returnravno_1()
        {
            var sut_1 = new Money(0, 1, 0, 0, 0, 0);
            var sut_2 = new Money(0, 1, 0, 0, 0, 0);

            bool expected = true;
            Assert.Equal(expected, sut_1 == sut_2);

        }
        [Fact]
        public void operatorravno_returnravno_2()
        {
            var sut_1 = new Money(0, 1, 0, 0, 0, 0);
            var sut_2 = new Money(0, 0, 0, 0, 0, 0);

            bool expected = false;
            Assert.Equal(expected, sut_1 == sut_2);

        }
        [Fact]
        public void operatorravno_returnravno_3()
        {
            var sut_1 = new Money(0, 0, 0, 0, 0, 0);
            var sut_2 = new Money(0, 0, 0, 0, 0, 0);

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