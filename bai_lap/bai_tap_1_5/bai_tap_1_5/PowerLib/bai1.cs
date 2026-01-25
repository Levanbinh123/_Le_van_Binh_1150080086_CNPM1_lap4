namespace PowerLib
{
    public static class PowerUtil
    {
        public static double Power(double x, int n)
        {
            // n = 0
            if (n == 0)
                return 1;

            // n > 0
            if (n > 0)
                return x * Power(x, n - 1);

            // n < 0
            return 1 / Power(x, -n);
        }
    }
}