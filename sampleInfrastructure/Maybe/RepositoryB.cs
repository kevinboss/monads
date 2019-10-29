using System;

namespace sampleInfrastructure.Maybe
{
    public static class RepositoryB
    {
        public static void Persist(SampleDataB dataB)
        {
            Console.WriteLine($"Persisted {dataB}");
        }
    }
}