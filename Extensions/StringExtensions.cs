using System;
using System.Text;

namespace Asjc.Extensions
{
    public static class StringExtensions
    {
#if NETCOREAPP2_1_OR_GREATER
#else
        public static bool Contains(this string str, string value, StringComparison comparisonType)
        {
            return str.IndexOf(value, comparisonType) >= 0;
        }
#endif

#if NETCOREAPP3_0_OR_GREATER
#nullable enable
        public static string Replace(this string str, string oldValue, string? newValue, bool ignoreCase)
#else
        public static string Replace(this string str, string oldValue, string newValue, bool ignoreCase)
#endif
        {
            return str.Replace(oldValue, newValue, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
        }

#if NETCOREAPP2_0_OR_GREATER
#else
        public static string Replace(this string str, string oldValue, string newValue, StringComparison comparisonType)
        {
            StringBuilder sb = new StringBuilder();

            int previousIndex = 0;
            int index = str.IndexOf(oldValue, comparisonType);
            while (index != -1)
            {
                sb.Append(str.Substring(previousIndex, index - previousIndex));
                sb.Append(newValue);
                index += oldValue.Length;

                previousIndex = index;
                index = str.IndexOf(oldValue, index, comparisonType);
            }
            sb.Append(str.Substring(previousIndex));

            return sb.ToString();
        }
#endif
    }
}
