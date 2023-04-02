namespace BusinessLogic.Easy
{
    public static class SmallerStringNumber
    {
        /// <summary>
        /// Create a function that returns the smaller number.
        ///
        /// Examples
        ///     smallerNum("21", "44") ➞ "21"
        ///     smallerNum("1500", "1") ➞ "1"
        ///     smallerNum("5", "5") ➞ "5"
        ///
        /// Notes
        ///     Numbers will be represented as strings, and your output should also be a string.
        ///     If both numbers tie, return either number.
        ///     Numbers will be positive.
        ///
        /// Bonus: See if you can do this without converting to integers.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static string SmallerNum(string n1, string n2) => int.Parse(n1) <= int.Parse(n2) ? n1 : n2;
    }
}