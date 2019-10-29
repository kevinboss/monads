using System;

namespace functional.Result
{
    public class Failure<TValue> : Result<TValue>
    {
        private Failure()
        {
        }

        private string ErrorMessage { get; set; }

        public static Result<TValue> Fail(string errorMessage)
        {
            return new Failure<TValue>
            {
                ErrorMessage = errorMessage
            };
        }

        public override void ApplyFailure(Action<string> action)
        {
            action(ErrorMessage);
        }

        public override Result<TNewValue> Map<TNewValue>(Func<TValue, TNewValue> func)
        {
            if (func == null)
            {
                throw new ArgumentException("Can not be null", nameof(func));
            }

            return Result<TNewValue>.Fail(ErrorMessage);
        }


        public override Result<TNewValue> FlatMap<TNewValue>(Func<TValue, Result<TNewValue>> func)
        {
            if (func == null)
            {
                throw new ArgumentException("Can not be null", nameof(func));
            }

            return Result<TNewValue>.Fail(ErrorMessage);
        }
    }
}