using System.Globalization;

namespace DailyPractice.Easy
{
    public static class MonthName
    {
        public static string GetMonthName(int num)
        {
            var isValidNum = num > 0 && num <= 12;
            if (!isValidNum) return "Invalid month!";

            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
        }
    }
}