using System.Text.RegularExpressions;

namespace BusinessLogic.Easy
{
    /// <summary>
    /// Create a function that counts how many D's are in a sentence.
    ///
    /// Examples
    ///     CountDs("The quick brown fox jumps over the lazy dog and the Dalmatian.") ➞ 3
    ///     CountDs("My friend Dylan got distracted in school.") ➞ 4
    ///     CountDs("Debris was scattered all over the yard.") ➞ 3
    ///     CountDs("The rodents hibernated in their den.") ➞ 3
    ///
    /// Notes
    ///     Your function must be case-insensitive.
    ///     Remember to return the result.
    /// </summary>
    public static class HowManyD_sAreThere
    {
        public static string pattern = @"d";

        //Seguir probando este Pattern para entender como scapea el and, dog y Dalmatian
        public static string pattern2 = @"\b\w+d\b";

        public static int CountDs(string str)
        {
            return Regex.Matches(str, pattern, RegexOptions.IgnoreCase).Count;
        }
    }
}