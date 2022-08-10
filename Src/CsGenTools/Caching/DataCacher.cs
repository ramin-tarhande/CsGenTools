namespace CsGenTools.Caching
{
    /// <summary>
    /// check note about the method
    /// </summary>
    public interface DataCacher
    {
        /// <summary>
        /// it shall not have any side effects if an exception is thrown in the middle of the call 
        /// you can for example postpone setting/changing of the fields until there's no risk of an exception being thrown
        /// </summary>
        void InvalidateCache();
    }
}
