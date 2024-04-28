using System;

namespace Asjc.Extensions
{
    public static class ObjectExtensions
    {
#if NETCOREAPP3_0_OR_GREATER
#nullable enable
        public static object? ChangeType(this object? value, Type type)
#else
        public static object ChangeType(this object value, Type type)
#endif
        {
            try
            {
                return Convert.ChangeType(value, type);
            }
            catch
            {
                return default;
            }
        }
    }
}
