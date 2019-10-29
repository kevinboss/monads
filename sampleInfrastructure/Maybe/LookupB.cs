using functional.Maybe;

namespace sampleInfrastructure.Maybe
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
        public static kms.Maybe<SampleDataB> LoadSomeKmsMaybe(SampleDataA sampleDataA)
        {
            return new kms.Maybe<SampleDataB>(new SampleDataB());
        }

        public static kms.Maybe<SampleDataB> LoadNoneKmsMaybe(SampleDataA sampleDataA)
        {
            return new kms.Maybe<SampleDataB>();
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