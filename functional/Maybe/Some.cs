using System;

namespace functional.Maybe
{
    public class Some<TValue> : Maybe<TValue>
    {
        public new static Maybe<TValue> Of(TValue value)
        {
            return new Some<TValue>
            {
                Value = value
            };
        }
        private TValue Value { get; set; }

        public override void ApplySome(Action<TValue> action)
        {
            if (action == null)
            {
                throw new ArgumentException("Can not be null", nameof(action));
            }

            action.Invoke(Value);
        }

        public override Maybe<TNewValue> Map<TNewValue>(Func<TValue, TNewValue> func)
        {
            if (func == null)
            {
                throw new ArgumentException("Can not be null", nameof(func));
            }

            return Maybe<TNewValue>.Of(func.Invoke(Value));
        }

        public override Maybe<TNewValue> FlatMap<TNewValue>(Func<TValue, Maybe<TNewValue>> func)
        {
            if (func == null)
            {
                throw new ArgumentException("Can not be null", nameof(func));
            }

            return func.Invoke(Value);
        }
    }
}