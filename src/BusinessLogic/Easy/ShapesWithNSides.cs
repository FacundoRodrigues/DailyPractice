namespace BusinessLogic.Easy
{
    /// <summary>
    /// Create a function that takes a whole number as input and returns the shape with that number's amount of sides. Here are the expected outputs to get from these inputs.
    ///
    ///     Inputs Outputs
    ///     1	"circle"
    ///     2	"semi-circle"
    ///     3	"triangle"
    ///     4	"square"
    ///     5	"pentagon"
    ///     6	"hexagon"
    ///     7	"heptagon"
    ///     8	"octagon"
    ///     9	"nonagon"
    ///     10	"decagon"
    ///
    /// Examples
    ///     NSidedShape(3) ➞ "triangle"
    ///     NSidedShape(1) ➞ "circle"
    ///     NSidedShape(9) ➞ "nonagon"
    ///
    /// Notes
    ///     There won't be any tests with a number below 1 or greater than 10.
    ///     Return the output in lowercase.
    ///     The challenge is intended to be completed without conditionals(it would take too long)!
    ///
    /// </summary>
    public static class ShapesWithNSides
    {
        private static IDictionary<int, string> shapes = new Dictionary<int, string>
        {
            { 1 , "circle" },
            { 2 , "semi-circle" },
            { 3 , "triangle" },
            { 4 , "square" },
            { 5 , "pentagon" },
            { 6 , "hexagon" },
            { 7 , "heptagon" },
            { 8 , "octagon" },
            { 9 , "nonagon" },
            { 10 , "decagon" }
        };

        public static string NSidedShape(int n)
        {
            string result = string.Empty;
            switch (n)
            {
                case 1:
                    result = shapes[n];
                    break;

                case 2:
                    result = shapes[n];
                    break;

                case 3:
                    result = shapes[n];
                    break;

                case 4:
                    result = shapes[n];
                    break;

                case 5:
                    result = shapes[n];
                    break;

                case 6:
                    result = shapes[n];
                    break;

                case 7:
                    result = shapes[n];
                    break;

                case 8:
                    result = shapes[n];
                    break;

                case 9:
                    result = shapes[n];
                    break;

                case 10:
                    result = shapes[n];
                    break;
            }

            return result;
        }

        public static string NSidedShapeV2(int n)
        {
            return shapes.TryGetValue(n, out string value) ? value : string.Empty;
        }
    }
}