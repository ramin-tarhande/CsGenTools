using System;
using System.Diagnostics;

namespace CsGenTools
{
        public static class DebugFriendly
        {
            public static void TryExecute(Action code, Action<Exception> exceptionHandler)
            {
                if (Debugger.IsAttached)
                {
                    code();
                    return;
                }

                try
                {
                    code();
                }
                catch (Exception x)
                {
                    exceptionHandler(x);
                }
            }

            public static T TryExecute<T>(Func<T> code, Action<Exception> exceptionHandler)
            {
                if (Debugger.IsAttached)
                {
                    return code();
                }

                try
                {
                    return code();
                }
                catch (Exception x)
                {
                    exceptionHandler(x);
                    return default(T);
                }
            }

        }
}
