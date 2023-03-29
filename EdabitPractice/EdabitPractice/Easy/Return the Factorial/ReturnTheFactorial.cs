namespace EdabitPractice
{
    public static class ReturnTheFactorial
    {
        private static int result = 0;

        public static int Run(int num)
        {
            if (num <= 1) return num;

            result += num * (num - 1);
            Run(--num);

            Console.WriteLine(result);
            return result;
        }
    }
}