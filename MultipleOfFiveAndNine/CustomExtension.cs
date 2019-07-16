using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleOfFiveAndNine
{
    public static class NaturalNumberExtension
    {
        #region Private
        private static long SumMultipliers(this IEnumerable<int> numbers, int k)
        {
            long sum = 0;
            var count = numbers.Count();
            for (int i = 1; i <= count; i++)
            {
                var mul = i * k;
                if (mul <= count)
                    sum += mul;
                else
                    break;
            }
            return sum;
        }

        #endregion

        /// <summary>Sums the multipliers of five or nine less equal then numbers count. The algorithm is O(n)</summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public static long SumOfFiveORNineMultipliers(this IEnumerable<int> numbers)
        {
            long sum = 0;
            foreach (var n in numbers)
            {
                if (n % 5 == 0 || n % 9 == 0)
                    sum += n;
            }
            return sum;
        }


        public static long SumOfFiveORNineMultipliersOptimized(this IEnumerable<int> numbers)
        {
            long sum = 0;
            var count = numbers.Count();
            for (int i = 1; i <= count; i++)
            {
                var mul5 = i * 5;
                var mul9 = i * 9;
                var mul45 = i * 45;
                var check1 = false;
                var check2 = false;
                var check3 = false;

                if (mul5 <= count)
                    sum += mul5;
                else
                    check1 = true;
                if (mul9 <= count)
                    sum += mul9;
                else
                    check2 = true;
                if (mul45 <= count)
                    sum -= mul45;
                else
                    check3 = true;

                if (check1 && check2 && check3) break;
            }
            return sum;
        }
        public static long SumOfFiveORNineMultipliersSlow(this IEnumerable<int> numbers)
        {
            return numbers.SumMultipliers(5) + numbers.SumMultipliers(9) - numbers.SumMultipliers(9 * 5);
        }
    }

    public static class TimeExtension
    {
        public static string Format(this TimeSpan ts)
        {
            return String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
        }
    }
}
