using BusinessLogic.Medium;
using Xunit;

namespace BusinessLogic.UT.Medium.ReverseTheCaseExercise
{
    public class ReverseTheCaseShould
    {
        [Theory]
        [InlineData("Happy Birthday", "hAPPY bIRTHDAY")]
        [InlineData("MANY THANKS", "many thanks")]
        [InlineData("sPoNtAnEoUs", "SpOnTaNeOuS")]
        public void ShouldReturnToogledCaseString(string str, string expectedResult)
        {
            var result = ReverseTheCase.ReverseCase(str);

            Assert.Equal(result, expectedResult);
        }
    }
}