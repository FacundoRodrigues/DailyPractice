namespace DailyPractice.Easy
{
    /*
     * Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.
     *
     * Examples
     *  FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]
     *  FindMinMax([2334454, 5]) ➞ [5, 2334454]
     *  FindMinMax([1]) ➞ [1, 1]
     *
     *  Notes
     *      All test arrays will have at least one element and are valid.
     */

    public static class FindNumbers
    {
        public static double[] FindMinMax(double[] values)
        {
            var resultArray = new double[2];
            resultArray[0] = values.Min();
            resultArray[1] = values.Max();
            return resultArray;
        }
    }
}