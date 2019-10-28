using functional;

namespace sampleInfrastructure
{
    public static class LookupB
    {
        public static Maybe<SampleDataB> LoadSomeMaybe(SampleDataA sampleDataA)
        {
            return Maybe<SampleDataB>.Of(new SampleDataB());
        }

        public static Maybe<SampleDataB> LoadNoneMaybe(SampleDataA sampleDataA)
        {
            return Maybe<SampleDataB>.Absent();
        }

        public static SampleDataB LoadSome(SampleDataA sampleDataA)
        {
            return new SampleDataB();
        }

        public static SampleDataB LoadNone(SampleDataA sampleDataA)
        {
            return null;
        }
    }
}