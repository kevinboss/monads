using System.Collections;
using System.Collections.Generic;

namespace kms
{
    public class Maybe<TValue> : IEnumerable<TValue>
    {
        private List<TValue> Value { get; }

        public Maybe(TValue value)
        {
            if (value == null)
            {
                Value = new List<TValue>();
            }

            Value = new List<TValue>
            {
                value
            };
        }

        public Maybe()
        {
            Value = new List<TValue>();
        }

        public IEnumerator<TValue> GetEnumerator()
        {
            return Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}