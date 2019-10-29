using System;
using NUnit.Framework;

namespace sample
{
    public class MonadeExample
    {
        [Test]
        public void Monade()
        {
            Monad<int> Func1(int v1) => v1.Create();
            Monad<int> Func2(int v1) => v1.Create();
            Monad<int> Func3(int v1) => v1.Create();

            const int value = 1;
            value.Create()
                .Map(Func1)
                .Map(Func2)
                .Map(Func3);
        }
    }

    public class Monad<T>
    {
        private readonly T _instance;

        public Monad(T instance)
        {
            _instance = instance;
        }

        public Monad<TO> Map<TO>(Func<T, Monad<TO>> func)
        {
            return func(_instance);
        }
    }

    public static class MonadExtensions
    {
        public static Monad<T> Create<T>(this T instance) => new Monad<T>(instance);
    }
}