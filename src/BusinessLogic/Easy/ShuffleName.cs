namespace BusinessLogic.Easy
{
    public static class ShuffleName
    {
        /// <summary>
        /// Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
        ///
        /// Examples
        ///     NameShuffle("Donald Trump") ➞ "Trump Donald"
        ///     NameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"
        ///     NameShuffle("Seymour Butts") ➞ "Butts Seymour"
        ///
        /// Notes
        ///     There will be exactly one space between the first and last name.
        ///     If you get stuck on a challenge, find help in the Resources tab.
        ///     If you're really stuck, unlock solutions in the Solutions tab.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string NameShuffle(string str)
        {
            var stringArray = str.Split(' ');
            Array.Reverse(stringArray, 0, 2);
            var nameShuffled = string.Join(" ", stringArray);
            return nameShuffled;
        }
    }
}