namespace BusinessLogic.Easy.Recursividad
{
    /* Create a function that takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.
     *
     * Ejemplos:
     * Factorial(3) ➞ 6
     * Factorial(5) ➞ 120
     * Factorial(12) ➞ 479001600
     *
     * Notes
     * Assume all inputs are greater than or equal to 0.
     */

    public static class ReturnTheFactorial
    {
        public static int Factorial(int num)
        {
            if (num == 1)
                return 1;
            else
            {
                var result = num * Factorial(num - 1);
                return result;
            }
        }
    }
}