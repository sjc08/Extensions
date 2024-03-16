using System;

namespace Asjc.Extensions
{
    public static class ObjectExtensions
    {
        public static object ChangeType(this object value, Type type)
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
