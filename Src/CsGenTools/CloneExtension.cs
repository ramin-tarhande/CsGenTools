using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CsGenTools
{
    //
    // https://www.extensionmethod.net/csharp/object/clone-t
    //
    public static class CloneExtension
    {
        public static T Clone<T>(this object item)
        {
            if (item != null)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream stream = new MemoryStream();

                formatter.Serialize(stream, item);
                stream.Seek(0, SeekOrigin.Begin);

                T result = (T)formatter.Deserialize(stream);

                stream.Close();

                return result;
            }
            else
                return default(T);
        }
    }
}
