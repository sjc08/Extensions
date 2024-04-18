using System.Collections.Generic;
using System.Linq;

namespace Asjc.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool ContentEqual<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            if (first.Count() != second.Count())
                return false;
            return first.OrderBy(x => x).SequenceEqual(second.OrderBy(x => x));
        }
    }
}
