using System;
using static Asjc.Extensions.TryExtensions;

namespace Asjc.Extensions
{
    public static class ObjectExtensions
    {
        public static bool ConvertTo(this object? value, Type conversionType, out object? result)
            => Try(() => Convert.ChangeType(value, conversionType), out result);

        public static bool ConvertTo(this object? value, TypeCode typeCode, out object? result)
            => Try(() => Convert.ChangeType(value, typeCode), out result);

        public static bool ConvertTo(this object? value, Type conversionType, IFormatProvider? provider, out object? result)
           => Try(() => Convert.ChangeType(value, conversionType, provider), out result);

        public static bool ConvertTo(this object? value, TypeCode typeCode, IFormatProvider? provider, out object? result)
            => Try(() => Convert.ChangeType(value, typeCode, provider), out result);

        public static object? ConvertTo(this object? value, Type conversionType)
            => Try(() => Convert.ChangeType(value, conversionType));

        public static object? ConvertTo(this object? value, TypeCode typeCode)
            => Try(() => Convert.ChangeType(value, typeCode));

        public static object? ConvertTo(this object? value, Type conversionType, IFormatProvider? provider)
            => Try(() => Convert.ChangeType(value, conversionType, provider));

        public static object? ConvertTo(this object? value, TypeCode typeCode, IFormatProvider? provider)
            => Try(() => Convert.ChangeType(value, typeCode, provider));
    }
}
