using System;

namespace CsGenTools.Functional
{
    //
    // https://mikhail.io/2016/01/validation-with-either-data-type-in-csharp/
    //
    public class Either<TData, TError>
    {
        public TData Data { get; private set; }
        public TError Error { get; private set; }

        private readonly bool isData;

        public Either(TData data)
        {
            this.Data = data;
            this.isData = true;
        }

        public Either(TError error)
        {
            this.Error = error;
            this.isData = false;
        }

        public bool IsData()
        {
            return isData;
        }

        public bool IsError()
        {
            return !isData;
        }

        public T Match<T>(Func<TData, T> dataFunc, Func<TError, T> errorFunc)
        {
            return this.isData ? dataFunc(this.Data) : errorFunc(this.Error);
        }

        public static implicit operator Either<TData, TError>(TData data)
        {
            return new Either<TData, TError>(data);
        }

        public static implicit operator Either<TData, TError>(TError error)
        {
            return new Either<TData, TError>(error);
        }
    }
}
