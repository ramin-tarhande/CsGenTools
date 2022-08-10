using System;

namespace CsGenTools.Functional
{
    public static class IfExtensions
    {
        // https://www.extensionmethod.net/csharp/object/ifis-t
        // 
        public static void IfIs<T>(this object target, Action<T> method)
        {
            if (target is T)
            {
                method((T)target);
            }
        }

        public static TResult IfIs<T, TResult>(this object target, Func<T, TResult> method)
        {
            if (target is T)
            {
                return method((T)target);
            }
            else
            {
                return default(TResult);
            }
        }

        /// <summary>
        /// if x is null convert it to something else using func
        /// </summary>
        public static T IfNull<T>(this T x, Func<T> func)
        {
            return x == null ? func() : x;
        }
        
        // https://www.extensionmethod.net/csharp/object/ifnotnull
        //
        public static TInner IfNotNull<T, TInner>(this T source, Func<T, TInner> selector)
        {
            return source != null ? selector(source) : default(TInner);
        }
    }
}
