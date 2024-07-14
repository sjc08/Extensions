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
        public static bool ConvertTo(this object? value, Type conversionType, IFormatProvider? provider, out object? result)
#else
        public static bool ConvertTo(this object value, Type conversionType, IFormatProvider provider, out object result)
#endif
            => Try(() => Convert.ChangeType(value, conversionType, provider), out result);

#if NETCOREAPP3_0_OR_GREATER
        public static bool ConvertTo(this object? value, TypeCode typeCode, IFormatProvider? provider, out object? result)
#else
        public static bool ConvertTo(this object value, TypeCode typeCode, IFormatProvider provider, out object result)
#endif
            => Try(() => Convert.ChangeType(value, typeCode, provider), out result);

#if NETCOREAPP3_0_OR_GREATER
        public static object? ConvertTo(this object? value, Type conversionType)
#else
        public static object ConvertTo(this object value, Type conversionType)
#endif
            => Try(() => Convert.ChangeType(value, conversionType));

#if NETCOREAPP3_0_OR_GREATER
        public static object? ConvertTo(this object? value, TypeCode typeCode)
#else
        public static object ConvertTo(this object value, TypeCode typeCode)
#endif
            => Try(() => Convert.ChangeType(value, typeCode));

#if NETCOREAPP3_0_OR_GREATER
        public static object? ConvertTo(this object? value, Type conversionType, IFormatProvider? provider)
#else
        public static object ConvertTo(this object value, Type conversionType, IFormatProvider provider)
#endif
            => Try(() => Convert.ChangeType(value, conversionType, provider));

#if NETCOREAPP3_0_OR_GREATER
        public static object? ConvertTo(this object? value, TypeCode typeCode, IFormatProvider? provider)
#else
        public static object ConvertTo(this object value, TypeCode typeCode, IFormatProvider provider)
#endif
            => Try(() => Convert.ChangeType(value, typeCode, provider));
    }
}
