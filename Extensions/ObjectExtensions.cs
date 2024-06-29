using System;

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
        {
            try
            {
                result = Convert.ChangeType(value, conversionType);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

#if NETCOREAPP3_0_OR_GREATER
        public static bool ConvertTo(this object? value, TypeCode typeCode, out object? result)
#else
        public static bool ConvertTo(this object value, TypeCode typeCode, out object result)
#endif
        {
            try
            {
                result = Convert.ChangeType(value, typeCode);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

#if NETCOREAPP3_0_OR_GREATER
        public static bool ConvertTo(this object? value, Type conversionType, IFormatProvider provider, out object? result)
#else
        public static bool ConvertTo(this object value, Type conversionType, IFormatProvider provider, out object result)
#endif
        {
            try
            {
                result = Convert.ChangeType(value, conversionType, provider);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

#if NETCOREAPP3_0_OR_GREATER
        public static bool ConvertTo(this object? value, TypeCode typeCode, IFormatProvider provider, out object? result)
#else
        public static bool ConvertTo(this object value, TypeCode typeCode, IFormatProvider provider, out object result)
#endif
        {
            try
            {
                result = Convert.ChangeType(value, typeCode, provider);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }
    }
}
