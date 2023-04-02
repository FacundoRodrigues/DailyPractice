namespace BusinessLogic.Easy
{
    public static class HammingDistance
    {
        /// <summary>
        /// Hamming distance is the number of characters that differ between two strings.
        ///
        /// To illustrate:
        ///     String1: "abcbba"
        ///     String2: "abcbda"
        ///
        /// Hamming Distance: 1 - "b" vs. "d" is the only difference.
        ///
        ///
        /// Create a function that computes the hamming distance between two strings.
        ///
        /// Examples
        ///     CalculateHammingDistance("abcde", "bcdef") ➞ 5
        ///     CalculateHammingDistance("abcde", "abcde") ➞ 0
        ///     CalculateHammingDistance("strong", "strung") ➞ 1
        ///
        /// Notes
        /// Both strings will have the same length.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static int CalculateHammingDistance(string str1, string str2)
        {
            var result = str1.Zip(str2, (a, b) => GetHammingDistance(a, b));

            return result.Where(x => x == 1).Sum();
        }

        public static int GetHammingDistance(char a, char b) => a != b ? 1 : 0;
    }
}