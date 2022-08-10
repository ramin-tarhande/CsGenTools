using System;
using System.Text;

namespace CsGenTools
{
    public static class ExceptionUtil
    {
        public static string FullText(this Exception root)
        {
            var sb = new StringBuilder();
            for (var x = root; x != null; x = x.InnerException)
            {
                sb.Append(x.Message);
                sb.Append("\r\n");
            }

            return sb.ToString();
        }

        public static Exception InnerMost(this Exception root)
        {
            Exception innermost = null;
            for (var x = root; x != null; x = x.InnerException)
            {
                innermost = x;
            }

            return innermost;
        }

    }
}
