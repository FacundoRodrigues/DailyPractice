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
    ///
    /// Regex.Matches Method
    /// https://learn.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.matches?view=net-5.0
    /// </summary>
    public static class HowManyD_sAreThere
    {
        //\b. Límite de palabra
        //\w: Representa cualquier carácter no alfanumérico. Coincide con cualquier carácter que no sea una letra, un número o un guion bajo
        //\w+:Significa "uno o más caracteres de palabra"
        //\w*:El carácter \w coincide con cualquier carácter de palabra, incluyendo letras, números y el guión bajo "_".
        //Ej:"h\w*o" coincidiría con "hello", "hero", "hollow", "how"

        public static string pattern = @"[dD]";

        public static int CountDs(string str) => Regex.Matches(str, pattern).Count;
    }
}