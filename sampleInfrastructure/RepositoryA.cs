using System;

namespace sampleInfrastructure
{
    public static class RepositoryA
    {
        public static void Persist(SampleDataA dataA)
        {
            Console.WriteLine($"Persisted {dataA}");
        }
    }
}