namespace DailyPractice.Easy.HowManyVowels
{
    /*Create a function that takes a string and returns the number (count) of vowels contained within it.
     *
     * Examples
     * CountVowels("Celebration") ➞ 5
     * CountVowels("Palm") ➞ 1
     * CountVowels("Prediction") ➞ 4
     *
     * Notes
     * a, e, i, o, u are considered vowels (not y).
     * All test cases are one word and only contain letters.
     */

    public static class HowManyVowels
    {
        public static int GetVowels(string word)
        {
            if (word.Length == 0) return 1;

            var a = word[word.Length - 1];

            GetVowels(word[word.Length - 1].ToString());
            Console.WriteLine();
            return 0;
        }

        private static bool IsVowel()
        {
            throw new NotImplementedException();
        }
    }
}