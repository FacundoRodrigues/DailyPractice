using System.Text;

namespace BusinessLogic.Easy
{
    /// <summary>
    /// Stuttering Function
    /// Write a function that stutters a word as if someone is struggling to read it.The first two letters are
    /// repeated twice with an ellipsis '...' and space after each, and then the word is pronounced with a question mark '?'.
    ///
    /// Examples
    ///     Stutter("incredible") ➞ "in... in... incredible?"
    ///     Stutter("enthusiastic") ➞ "en... en... enthusiastic?"
    ///     Stutter("outstanding") ➞ "ou... ou... outstanding?"
    ///
    /// Notes
    ///     Assume all input is in lower case and at least two characters long.
    /// </summary>
    public static class StutteringFunction
    {
        private const string Ellipsis = "... ";
        private const string QuestionMark = "?";

        public static string Stutter(string word)
        {
            var firstTwoLetters = word.Substring(0, 2);
            var sb = new StringBuilder();

            sb.Append(firstTwoLetters)
                .Append(Ellipsis)
                .Append(firstTwoLetters)
                .Append(Ellipsis)
                .Append(word)
                .Append(QuestionMark);

            return sb.ToString();
        }
    }
}