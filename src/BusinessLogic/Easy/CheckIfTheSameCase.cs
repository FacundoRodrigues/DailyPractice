namespace BusinessLogic.Easy
{
    public static class CheckIfTheSameCase
    {
        /// <summary>
        /// Create a function that returns true if an input string contains only uppercase or only lowercase letters.
        ///
        /// Examples
        ///     SameCase("hello") ➞ true
        ///     SameCase("HELLO") ➞ true
        ///     SameCase("Hello") ➞ false
        ///     SameCase("ketcHUp") ➞ false
        ///
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool SameCase(string str)
        {
            return str.All(x => char.IsLower(x)) || str.All(x => char.IsUpper(x));
        }
    }
}