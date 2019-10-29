using System;

namespace functional.Maybe
{
    public abstract class Maybe<TValue>
    {
        public static Maybe<TValue> Of(TValue value)
        {
            return Some<TValue>.Of(value);
        }

        public static Maybe<TValue> Absent()
        {
            return None<TValue>.Absent();
        }

        public virtual void ApplySome(Action<TValue> action)
        {
        }

        public virtual void ApplyNone(Action action)
        {
        }

        public abstract Maybe<TNewValue> Map<TNewValue>(Func<TValue, TNewValue> func);

        public abstract Maybe<TNewValue> FlatMap<TNewValue>(Func<TValue, Maybe<TNewValue>> func);
    }
}