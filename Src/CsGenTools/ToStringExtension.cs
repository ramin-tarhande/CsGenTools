namespace CsGenTools
{
    //
    // https://www.extensionmethod.net/csharp/object/tostring-nulloptions
    //
    public static class ToStringExtension
    {
        public static string SafeToString(this object obj)
        {
            if (IsEmpty(obj))
            {
                return "-";
            }
            else
            {
                return obj.ToString();
            }
        }

        static bool IsEmpty(object obj)
        {
            return obj == null;
            //return obj == null || obj is DBNull;
        }
    }
}
