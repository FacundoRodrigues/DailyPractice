namespace BusinessLogic.Easy
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
        public static int vowelsCount = 0;
        public static int index = 0;

        public static int CountVowels(string word)
        {
            index++;
            if (index > word.Length) return vowelsCount;

            var letter = word[word.Length - index];
            if (IsVowel(letter)) vowelsCount++;

            return CountVowels(word);
        }

        private static bool IsVowel(char letter)
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return vowels.Any(vowel => vowel == letter);
        }
    }
}