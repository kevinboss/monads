using System;

namespace sampleInfrastructure.Maybe
{
    public static class RepositoryA
    {
        public static void Persist(SampleDataA dataA)
        {
            Console.WriteLine($"Persisted {dataA}");
        }
    }
}