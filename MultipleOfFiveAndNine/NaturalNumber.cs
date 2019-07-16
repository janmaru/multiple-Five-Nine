using System.Collections.Generic;
using System.Linq;

namespace MultipleOfFiveAndNine
{
    public class NaturalNumber
    { 
        public static IEnumerable<int> LessThen(int n)
        {
            for (int i = 1; i < n; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<int> LessEqualThen(int n)
        {
            return LessThen(n).Concat(new[] { n });
        }
    }
}
