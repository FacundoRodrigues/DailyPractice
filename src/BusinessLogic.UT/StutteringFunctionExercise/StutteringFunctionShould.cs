using BusinessLogic.Easy;
using Xunit;

namespace BusinessLogic.UT.StutteringFunctionExercise
{
    public class StutteringFunctionShould
    {
        [Theory]
        [InlineData("incredible", "in... in... incredible?")]
        [InlineData("enthusiastic", "en... en... enthusiastic?")]
        [InlineData("outstanding", "ou... ou... outstanding?")]
        public void ShouldStutterAWord(string word, string expectedResult)
        {
            var result = StutteringFunction.Stutter(word);
            Assert.Equal(result, expectedResult);
        }
    }
}