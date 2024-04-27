using System;

namespace Asjc.Extensions
{
    public static class StringExtensions
    {
#if NETCOREAPP2_0_OR_GREATER
        public static string Replace(this string str, string oldValue, string newValue, bool ignoreCase)
        {
            return str.Replace(oldValue, newValue, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
        }
#endif
    }
}
