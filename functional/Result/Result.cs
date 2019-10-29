using System;

namespace functional.Result
{
    public abstract class Result<TValue>
    {
        public static Result<TValue> Success(TValue value)
        {
            return Successful<TValue>.Success(value);
        }

        public static Result<TValue> Fail(string errorMessage)
        {
            return Failure<TValue>.Fail(errorMessage);
        }

        public virtual void ApplySuccessful(Action<TValue> action)
        {
        }

        public virtual void ApplyFailure(Action<string> action)
        {
        }

        public abstract Result<TNewValue> Map<TNewValue>(Func<TValue, TNewValue> func);

        public abstract Result<TNewValue> FlatMap<TNewValue>(Func<TValue, Result<TNewValue>> func);
    }
}