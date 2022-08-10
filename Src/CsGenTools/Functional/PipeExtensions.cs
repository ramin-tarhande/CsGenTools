using System;

namespace CsGenTools.Functional
{
    //
    // https://www.extensionmethod.net/csharp/object/pipe
    //
    public static class PipeExtensions
    {
        public static R Pipe<T, R>(this T o, Func<T, R> func)
        {
            if (func == null) throw new ArgumentNullException("func", "'func' can not be null.");
            T buffer = o;
            return func(buffer);
        }
        public static T Pipe<T>(this T o, Action<T> action)
        {
            if (action == null) throw new ArgumentNullException("action", "'action' can not be null.");
            T buffer = o;
            action(buffer);
            return buffer;
        }
    }
}
