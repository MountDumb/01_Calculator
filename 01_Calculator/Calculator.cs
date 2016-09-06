namespace _01_Calculator
{
    internal static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Sum(int[] a)
        {
            int itt = 0;

            foreach (var s in a)
            {
                itt += s;
            }
            return itt;
        }
    }
}