using System.Text;

namespace BusinessLogic.Medium
{
    /// <summary>
    /// Reverse the Case
    ///     Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
    ///
    /// Examples
    ///     ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
    ///     ReverseCase("MANY THANKS") ➞ "many thanks"
    ///     ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
    /// </summary>
    public static class ReverseTheCase
    {
        public static string ReverseCase(string str)
        {
            var sb = new StringBuilder(str.Length);

            var enumerable = str.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)).ToArray();

            sb.Append(enumerable);

            return sb.ToString();
        }
    }
}