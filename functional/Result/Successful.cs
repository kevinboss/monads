using System;

namespace functional.Result
{
    public class Successful<TValue> : Result<TValue>
    {
        private Successful(){}

        private TValue Value { get; set; }

        public static Successful<TValue> Success(TValue value)
        {
            return new Successful<TValue>
            {
                Value = value
            };
        }

        public override void ApplySuccessful(Action<TValue> action)
        {
            action(Value);
        }

        public override Result<TNewValue> Map<TNewValue>(Func<TValue, TNewValue> func)
        {
            if (func == null)
            {
                throw new ArgumentException("Can not be null", nameof(func));
            }

            return Result<TNewValue>.Success(func.Invoke(Value));
        }

        public override Result<TNewValue> FlatMap<TNewValue>(Func<TValue, Result<TNewValue>> func)
        {
            if (func == null)
            {
                throw new ArgumentException("Can not be null", nameof(func));
            }

            return func.Invoke(Value);
        }
    }
}