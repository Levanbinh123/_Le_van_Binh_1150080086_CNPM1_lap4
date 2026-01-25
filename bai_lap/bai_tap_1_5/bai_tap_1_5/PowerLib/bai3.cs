using System;
using System.Collections.Generic;

namespace RadixLib
{
    public class Radix
    {
        private int number;

        public Radix(int number)
        {
            if (number < 0)
                throw new ArgumentException("Incorrect Value");

            this.number = number;
        }

        public string ConvertDecimalToAnother(int radix = 2)
        {
            if (radix < 2 || radix > 16)
                throw new ArgumentException("Invalid Radix");

            if (number == 0)
                return "0";

            int n = number;
            List<string> result = new List<string>();

            while (n > 0)
            {
                int value = n % radix;

                if (value < 10)
                    result.Add(value.ToString());
                else
                    result.Add(((char)('A' + value - 10)).ToString());

                n /= radix;
            }

            result.Reverse();
            return string.Join("", result);
        }
    }
}