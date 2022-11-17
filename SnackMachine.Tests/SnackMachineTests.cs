using Xunit;
using SnackMachineLogic;

namespace SnackMachine.Tests
{
    public class SnackMachineTests
    {

        [Fact]    
        public void Equals_ComparingWithNullReferenceObject_ReturnsFalse()
        {
            //Arrange
            object sut = new Money(5, 0, 0, 4, 0, 0);
            object sut1 = null;

            //Act
            bool actual = sut.Equals(sut1);

            //Assert 
            Assert.False(actual);
        }

        [Theory]
        [InlineData(5, 0, 0, 4, 0, 0, true)]
        [InlineData(5, 2, 0, 4, 0, 0, false)]
        public void Equals_ComparingObjects_ShouldCompareProperly(int oneCentCount, int tenCentCount, int quarterCount, int oneDollarCount, int fiveDollarCount, int twentyDollarCount, bool expected)
        {
            //Arrange
            object sut = new Money(5, 0, 0, 4, 0, 0);
            object sut1 = new Money(oneCentCount, tenCentCount, quarterCount, oneDollarCount, fiveDollarCount, twentyDollarCount);
            //Act
            bool actual = sut.Equals(sut1);

            //Assert
            Assert.Equal<bool>(expected, actual);
        }

        [Fact]
        public void GetHashCode_HashCodeOf2_DollarsComparingWithHashCodeOf1_Dollar_5_Cents_AreDifferent()
        {
            //Arrange
            object sut = new Money(0, 0, 0, 2, 0, 0);
            object sut1 = new Money(5, 0, 0, 1, 0, 0);
            //Act
            int hash = sut.GetHashCode();
            int hash1 = sut1.GetHashCode();

            //Assert
            Assert.NotEqual(hash, hash1);
        }

        [Theory]
        [InlineData(4, 3, 0, 0, 0, 0, "¢34")]
        [InlineData(5, 2, 0, 4, 1, 0, "$9,25")]
        public void ToString_ShowAmountOfMoneyInCorrectForm(int oneCentCount, int tenCentCount, int quarterCount, int oneDollarCount, int fiveDollarCount, int twentyDollarCount, string expected)
        {
            //Arrange
            object sut = new Money(oneCentCount, tenCentCount, quarterCount, oneDollarCount, fiveDollarCount, twentyDollarCount);

            //Act
            string actual = sut.ToString();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}