namespace BusinessLogic.Easy
{
    /*
     * Check if a String Contains only Identical Characters
     *
     * Write a function that returns true if all characters in a string are identical and false otherwise.
     *
     *  Examples
     *      isIdentical("aaaaaa") ➞ true
     *      isIdentical("aabaaa") ➞ false
     *      isIdentical("ccccca") ➞ false
     *      isIdentical("kk") ➞ true
     */

    public static class IdenticalCharacters
    {
        //HasSet option
        //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-6.0
        public static bool IsIdentical(string str)
        {
            HashSet<char> set = new HashSet<char>();

            foreach (char c in str) set.Add(c);

            return set.Count() == 1;
        }

        //Distinct option
        public static bool IsIdenticalDistinctOption(string str)
        {
            return str.Distinct().Count() == 1;
        }
    }
}