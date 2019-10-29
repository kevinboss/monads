using System;
using System.Linq;

namespace kms
{
    public static class MaybeExtensions
    {
        public static Maybe<TNewValue> Map<TValue, TNewValue>(this Maybe<TValue> maybe,
            Func<TValue, TNewValue> func)
        {
            return !maybe.Any() ? new Maybe<TNewValue>() : new Maybe<TNewValue>(func(maybe.First()));
        }
        
        public static Maybe<TNewValue> FlatMap<TValue, TNewValue>(this Maybe<TValue> maybe,
            Func<TValue, Maybe<TNewValue>> func)
        {
            return !maybe.Any() ? new Maybe<TNewValue>() : func(maybe.First());
        }


        public static void ApplySome<TType>(this Maybe<TType> maybe, Action<TType> action)
        {
            if (maybe.Any())
            {
                action(maybe.First());
            }
        }

        public static void ApplyNone<TType>(this Maybe<TType> maybe, Action action)
        {
            if (!maybe.Any())
            {
                action();
            }
        }
    }
}