using System;

namespace Asjc.Extensions
{
    public static class ObjectExtensions
    {
#if NET8_0
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
