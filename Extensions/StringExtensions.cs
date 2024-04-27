using System;
using System.Text;

namespace Asjc.Extensions
{
    public static class StringExtensions
    {
#if NET8_0
#nullable enable
        public static string Replace(this string str, string oldValue, string? newValue, bool ignoreCase)
#else
        public static string Replace(this string str, string oldValue, string newValue, bool ignoreCase)
#endif
        {
            return str.Replace(oldValue, newValue, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
        }

#if NETSTANDARD2_0
        public static string Replace(this string str, string oldValue, string newValue, StringComparison comparison)
        {
            StringBuilder sb = new StringBuilder();

            int previousIndex = 0;
            int index = str.IndexOf(oldValue, comparison);
            while (index != -1)
            {
                sb.Append(str.Substring(previousIndex, index - previousIndex));
                sb.Append(newValue);
                index += oldValue.Length;

                previousIndex = index;
                index = str.IndexOf(oldValue, index, comparison);
            }
            sb.Append(str.Substring(previousIndex));

            return sb.ToString();
        }
#endif
    }
}
