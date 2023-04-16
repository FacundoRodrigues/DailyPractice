namespace BusinessLogic.Easy
{
    /// <summary>
    /// Create a function that returns the string "Burp" with the amount of "r's" determined by the input parameters of the function.
    ///
    /// Examples
    ///     LongBurp(3) ➞ "Burrrp"
    ///     LongBurp(5) ➞ "Burrrrrp"
    ///     LongBurp(9) ➞ "Burrrrrrrrrp"
    ///
    /// Notes
    ///     Expect num to always be >= 1.
    ///     Remember to use a capital "B".
    ///     Don't forget to return the result.
    /// </summary>
    public static class Burrrrrrrp
    {
        private const string burp = "Bup";
        private const int indexToInsertRs = 2;

        public static string LongBurp(int countOfRsToAdd) => burp.Insert(indexToInsertRs, string.Concat(Enumerable.Repeat("r", countOfRsToAdd)));
    }
}