using System;

namespace Asjc.Extensions
{
    public static class TryExtensions
    {
        public static bool Try(Action action)
        {
            try
            {
                action();
                return true;
            }
            catch
            {
                return false;
            }
        }

#if NETCOREAPP3_0_OR_GREATER
#nullable enable
        public static T? Try<T>(Func<T> func)
#else
        public static T Try<T>(Func<T> func)
#endif
        {
            try
            {
                return func();
            }
            catch
            {
                return default;
            }
        }

#if NETCOREAPP3_0_OR_GREATER
        public static bool Try<T>(Func<T> func, out T? result)
#else
        public static bool Try<T>(Func<T> func, out T result)
#endif
        {
            try
            {
                result = func();
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
    }
}
