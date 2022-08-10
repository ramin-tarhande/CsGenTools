using System;

namespace CsGenTools.Functional
{
    /// <summary>
    /// https://blog.ploeh.dk/2018/03/26/the-maybe-functor/
    /// https://www.pluralsight.com/tech-blog/maybe/
    /// https://www.dotnetcurry.com/patterns-practices/1510/maybe-monad-csharp
    /// </summary>
    public struct Maybe<T>
    {
        public static Maybe<T> Create(T value)
        {
            return Create(value, value != null);
        }

        public static Maybe<T> Create(T value, bool hasValue)
        {
            return hasValue ? Some(value) : None();
        }

        public static Maybe<T> Some(T value)
        {
            return new Maybe<T>(value);
        }

        public static Maybe<T> None()
        {
            return new Maybe<T>();
        }

        public bool HasValue { get; private set; }
        public T Value { get; private set; }
        public Maybe(T value)
            : this()
        {
            if (value == null)
                throw new ArgumentNullException("value");

            this.HasValue = true;
            this.Value = value;
        }

        public bool IsEmpty
        {
            get
            {
                return !HasValue;
            }
        }

        public Maybe<TResult> Select<TResult>(Func<T, TResult> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");

            if (this.HasValue)
                //return new Maybe<TResult>(selector(this.Value));
                return Maybe<TResult>.Create(selector(this.Value));
            else
                return new Maybe<TResult>();
        }

        public T GetValueOrFallback(T fallbackValue)
        {
            return HasValue ? Value : fallbackValue;
        }

        public T GetValueOrFallbackTo(Func<T> func)
        {
            return HasValue ? Value : func();
        }

        public void Do(Action<T> action)
        {
            if (this.HasValue)
            {
                action(this.Value);
            }
        }

        public U Match<U>(Func<T, U> some, Func<U> none)
        {
            return this.HasValue
              ? some(this.Value)
              : none();
        }

        public void Match(Action<T> some, Action none)
        {
            if (this.HasValue)
            {
                some(this.Value);
            }
            else
            {
                none();
            }
        }

        public U Map<U>(Func<T, U> some, U fallbackValue)
        {
            return this.HasValue
              ? some(this.Value)
              : fallbackValue;
        }

        
        public override string ToString()
        {
            return HasValue?Value.ToString():"-";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Maybe<T>)
            {
                var x = (Maybe<T>) obj;
                if (x.HasValue==this.HasValue)
                {
                    return x.HasValue == false || x.Value.Equals(this.Value);    
                }
            }
            else if (obj is T)
            {
                return this.HasValue && this.Value.Equals((T) obj);
            }
            
            return false;
        }

        public static implicit operator Maybe<T>(T value)
        {
            if (value == null)
                return None();

            return Some(value);
        }


    }
}
