using BusinessLogic.Easy;
using Xunit;

namespace BusinessLogic.UT.Easy.HowManyD_sAreThereExercise
{
    public class HowManyDSAreThereShould
    {
        [Theory]
        [InlineData("The quick brown fox jumps over the lazy dog and the Dalmatian", 3)]
        [InlineData("My friend Dylan got distracted in school.", 4)]
        [InlineData("Debris was scattered all over the yard.", 3)]
        [InlineData("The rodents hibernated in their den.", 3)]
        public void ShouldReturnCountOfDs(string str, int expectedCount)
        {
            var resultCount = HowManyD_sAreThere.CountDs(str);

            Assert.Equal(expectedCount, resultCount);
        }
    }
}