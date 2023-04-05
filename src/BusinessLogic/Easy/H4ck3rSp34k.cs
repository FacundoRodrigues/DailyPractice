using System.Text;

namespace BusinessLogic.Easy
{
    public static class H4ck3rSp34k
    {
        private static IDictionary<char, char> pattern = new Dictionary<char, char>
        {
            { 'a' , '4' },
            { 'e' , '3' },
            { 'i' , '1' },
            { 'o' , '0' },
            { 's' , '5' }
        };

        /// <summary>
        /// Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.
        /// Examples
        ///     HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"
        ///     HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"
        ///     HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
        ///
        /// Notes
        ///     In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string HackerSpeak(string str)
        {
            var matchedLetters = str.Intersect(pattern.Keys);

            //Se depreca la primer idea de usar Replace dentro del foreach, ya que es ineficiente
            foreach (var key in matchedLetters)
            {
                str = str.Replace(key, pattern[key]);
            }

            return str;
        }

        public static string HackerSpeakOptimized(string str)
        {
            var newString = new StringBuilder(str.Length);

            foreach (var letter in str)
            {
                if (pattern.TryGetValue(letter, out var hackerLetter))
                {
                    newString.Append(hackerLetter);
                }
                else
                {
                    newString.Append(letter);
                }
            }

            return newString.ToString();
        }
    }
}