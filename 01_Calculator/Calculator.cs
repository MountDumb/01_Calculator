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

        public static int Multiply(int[] numbers)
        {
            int product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }

        public static int Power(int x, int y)
        {
            int result = 1;

            for (int i = 0; i < y; i++)
            {
                result = result * x;
                
            }

            return result;
        }

        public static int Faculty(int f)
        {
            int result = 1;
            for (int i = f; i > 0 ; i--)
            {
                result = result * i;
            }

            return result;
        }

        
    }
}