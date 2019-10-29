using functional.Maybe;

namespace sampleInfrastructure.Maybe
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
        public static kms.Maybe<SampleDataA> LoadSomeKmsMaybe()
        {
            return new kms.Maybe<SampleDataA>(new SampleDataA());
        }

        public static kms.Maybe<SampleDataA> LoadNoneKmsMaybe()
        {
            return new kms.Maybe<SampleDataA>();
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