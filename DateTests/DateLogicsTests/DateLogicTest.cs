using Laba3.DateLogics;
using Xunit;
using Assert = Xunit.Assert;

namespace DateTests.DateLogicsTests
{
    public class DateLogicTests
    {

        [Fact]
        public void IsLeapYear_2024_ReturnsTrue()
        {
            var date = new DateLogic(1, 1, 2024);
            bool result = date.IsLeapYear();
            Assert.True(result);
        }
        
        [Fact]
        public void IsLeapYear_2023_ReturnsFalse()
        {
            var date = new DateLogic(1, 1, 2023);
            bool result = date.IsLeapYear();
            Assert.False(result);
        }

        [Fact]
        public void IsLeapYear_1900_ReturnsFalse()
        {
            var date = new DateLogic(1, 1, 1900);
            Assert.False(date.IsLeapYear());
        }
        [Fact]
        public void Difference_NormalDateLogics_ReturnsCorrectValue()
        {
            var d1 = new DateLogic(1, 1, 2024);
            var d2 = new DateLogic(1, 1, 2023);
            int result = d1.Difference(d2);
            Assert.Equal(365, result);
        }

        [Fact]
        public void Difference_ReverseOrder_ReturnsPositiveValue()
        {
            var d1 = new DateLogic(1, 1, 2023);
            var d2 = new DateLogic(1, 1, 2024);
            int result = d1.Difference(d2);
            Assert.Equal(365, result);
        }

        [Fact]
        public void Difference_SameDateLogics_ReturnsZero()
        {
            var d1 = new DateLogic(1, 1, 2024);
            var d2 = new DateLogic(1, 1, 2024);
            int result = d1.Difference(d2);
            Assert.Equal(0, result);
        }
    }
}