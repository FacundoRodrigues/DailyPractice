using Xunit;

namespace BusinessLogic.UT.RaucousApplauseExercise
{
    public class RaucousApplauseShould
    {
        [Theory]
        [InlineData("ClaClaClaClap!", 4)]
        [InlineData("ClClClaClaClaClap!", 6)]
        [InlineData("CCClaClClap!Clap!ClClClap!", 9)]
        public void ShouldReturnExpectedClaps(string clapText, int expectedClaps)
        {
            var totalCountClaps = RaucousApplause.CountClaps(clapText);

            Assert.Equal(totalCountClaps, expectedClaps);
        }
    }
}