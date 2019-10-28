using System;

namespace sampleInfrastructure
{
    public static class RepositoryB
    {
        public static void Persist(SampleDataB dataB)
        {
            Console.WriteLine($"Persisted {dataB}");
        }
    }
}