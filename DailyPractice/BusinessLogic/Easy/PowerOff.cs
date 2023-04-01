namespace BusinessLogic.Easy
{   /*  To the Power of
     *
     *  Create a function that takes a base number and an exponent number and returns the calculation.
     *
     *  Examples
     *      СalculateExponent(5, 5) ➞ 3125
     *      СalculateExponent(10, 10) ➞ 10000000000
     *      СalculateExponent(3, 3) ➞ 27
     *
     *  Notes
     *      All test inputs will be positive integers.
     *      Don't forget to return the result.
     *      If you get stuck on a challenge, find help in the Resources tab.
     *      If you're really stuck, unlock solutions in the Solutions tab.
     *
     */

    public static class PowerOff
    {
        public static long CalculateExponent(long number, long exponent) => Convert.ToInt64(Math.Pow(number, exponent));
    }
}