using System;

namespace functional
{
    public class None<TValue> : Maybe<TValue>
    {
        public new static Maybe<TValue> Absent()
        {
            return new None<TValue>();
        }

        public override void ApplyNone(Action action)
        {
            if (action == null)
            {
                throw new ArgumentException("Can not be null", nameof(action));
            }

            action.Invoke();
        }

        public override Maybe<TNewValue> Map<TNewValue>(Func<TValue, TNewValue> func)
        {
            if (func == null)
            {
                throw new ArgumentException("Can not be null", nameof(func));
            }

            return Maybe<TNewValue>.Absent();
        }

        public override Maybe<TNewValue> FlatMap<TNewValue>(Func<TValue, Maybe<TNewValue>> func)
        {
            if (func == null)
            {
                throw new ArgumentException("Can not be null", nameof(func));
            }

            return Maybe<TNewValue>.Absent();
        }
    }
}