using System;
using System.Collections.Generic;
using System.Linq;

namespace CsGenTools
{
    public static class TimeSpanUtil
    {
        public static TimeSpan MultiplyBy(this TimeSpan timeSpan, double factor)
        {
            return TimeSpan.FromSeconds(timeSpan.TotalSeconds * factor);
        }

        public static TimeSpan DivideBy(this TimeSpan timeSpan, double factor)
        {
            return MultiplyBy(timeSpan, 1 / factor);
        }

        public static TimeSpan Average(TimeSpan x, TimeSpan y)
        {
            return (x + y).DivideBy(2);
        }

        public static TimeSpan Average(this IEnumerable<TimeSpan> timeSpans)
        {
            return TimeSpan.FromSeconds(
                timeSpans.Average(t=>t.TotalSeconds));
        }
    }
}
