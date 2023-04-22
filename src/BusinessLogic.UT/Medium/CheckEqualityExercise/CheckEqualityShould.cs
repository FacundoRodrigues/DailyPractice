using BusinessLogic.Medium;
using Xunit;

namespace BusinessLogic.UT.Medium.CheckEqualityExercise
{
    public class CheckEqualityShould
    {
        [Theory]
        [InlineData(1, true, false)]
        [InlineData(0, "0", false)]
        [InlineData(1, 1, true)]
        public void ShouldCompareTwoObjects(object firstObject, object secondObject, bool expectedResult)
        {
            var result = EqualityCheck.CheckEquality(firstObject, secondObject);

            Assert.Equal(expectedResult, result);
        }
    }
}