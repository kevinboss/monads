using functional;

namespace sampleInfrastructure
{
    public static class LookupA
    {
        public static Maybe<SampleDataA> LoadSomeMaybe()
        {
            return Maybe<SampleDataA>.Of(new SampleDataA());
        }

        public static Maybe<SampleDataA> LoadNoneMaybe()
        {
            return Maybe<SampleDataA>.Absent();
        }

        public static SampleDataA LoadSome()
        {
            return new SampleDataA();
        }

        public static SampleDataA LoadNone()
        {
            return null;
        }
    }
}