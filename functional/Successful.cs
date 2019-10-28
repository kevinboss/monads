namespace functional
{
    public class Successful<TValue> : Result<TValue>
    {
        public static Successful<TValue> Of(TValue value)
        {
            return new Successful<TValue>
            {
                Value = value
            };
        }

        private TValue Value { get; set; }
    }
}