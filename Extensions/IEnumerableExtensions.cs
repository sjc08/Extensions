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

        public static bool HasDuplicates<T>(this IEnumerable<T> source)
        {
            var set = new HashSet<T>();
            foreach (T item in source)
            {
                if (!set.Add(item))
                    return true;
            }
            return false;
        }
    }
}
