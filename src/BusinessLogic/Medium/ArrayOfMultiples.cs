﻿namespace BusinessLogic.Medium
{
    /// <summary>
    /// Array of Multiples
    /// Create a function that takes two numbers as arguments(num, length) and returns an array of multiples of num until the array length reaches length.
    ///
    /// Examples
    ///     ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
    ///     ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
    ///     ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
    ///
    /// Notes
    ///     Notice that num is also included in the returned array.
    /// </summary>
    public static class ArrayOfMultiples
    {
        public static int[] GetArrayOfMultiples(int num, int length)
        {
            var index = 1;
            return Enumerable.Repeat(num, length).Select(x => x * index++).ToArray();
        }
    }
}