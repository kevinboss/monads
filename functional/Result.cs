namespace functional
{
    public abstract class Result<TValue>
    {
        public Result<TValue> Of(TValue value)
        {
            return  Successful<TValue>.Of(value);
        }
    }
}