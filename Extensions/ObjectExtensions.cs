using System;
using static Asjc.Extensions.TryExtensions;

namespace Asjc.Extensions
{
    public static class ObjectExtensions
    {
#if NETCOREAPP3_0_OR_GREATER
#nullable enable
        public static bool ConvertTo(this object? value, Type conversionType, out object? result)
#else
        public static bool ConvertTo(this object value, Type conversionType, out object result)
#endif
            => Try(() => Convert.ChangeType(value, conversionType), out result);

#if NETCOREAPP3_0_OR_GREATER
        public static bool ConvertTo(this object? value, TypeCode typeCode, out object? result)
#else
        public static bool ConvertTo(this object value, TypeCode typeCode, out object result)
#endif
            => Try(() => Convert.ChangeType(value, typeCode), out result);

#if NETCOREAPP3_0_OR_GREATER
        public static bool ConvertTo(this object? value, Type conversionType, IFormatProvider provider, out object? result)
#else
        public static bool ConvertTo(this object value, Type conversionType, IFormatProvider provider, out object result)
#endif
            => Try(() => Convert.ChangeType(value, conversionType, provider), out result);

#if NETCOREAPP3_0_OR_GREATER
        public static bool ConvertTo(this object? value, TypeCode typeCode, IFormatProvider provider, out object? result)
#else
        public static bool ConvertTo(this object value, TypeCode typeCode, IFormatProvider provider, out object result)
#endif
            => Try(() => Convert.ChangeType(value, typeCode, provider), out result);
    }
}
