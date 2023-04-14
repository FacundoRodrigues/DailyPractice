using BusinessLogic.Easy;
using Xunit;

namespace BusinessLogic.UT.BurrrrrrrpExercise
{
    public class BurrrrrrrpShould
    {
        [Theory]
        [InlineData("Burrrp", 3)]
        [InlineData("Burrrrrp", 5)]
        [InlineData("Burrrrrrrrrp", 9)]
        public void ShouldAddEspecificRsCount(string expectedResult, int countOfRsToAdd)
        {
            var result = Burrrrrrrp.LongBurp(countOfRsToAdd);

            Assert.Equal(result, expectedResult);
        }
    }
}