using System;

namespace CsGenTools
{
    public static class DisposeExtensions
    {
        public static void TryDispose(this object target)
        {
            TryDispose(target, true);
        }

        public static void TryDispose(this object target, bool throwException)
        {
            var disposable = target as IDisposable;
            if (disposable == null)
                return;

            try
            {
                disposable.Dispose();
            }
            catch (Exception)
            {
                if (throwException)
                    throw;
            }
        }
    }
}
