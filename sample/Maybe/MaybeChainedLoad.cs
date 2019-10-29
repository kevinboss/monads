using System;
using NUnit.Framework;
using sampleInfrastructure;

namespace sample.Maybe
{
    public class MaybeChainedLoad
    {
        [Test]
        public void Worst()
        {
            var sampleDataA = LookupA.LoadSome();
            var sampleDataB = LookupB.LoadSome(sampleDataA);
            Console.Write(sampleDataB);
        }

        [Test]
        public void Bad()
        {
            var sampleDataA = LookupA.LoadSome();
            if (sampleDataA != null)
            {
                var sampleDataB = LookupB.LoadSome(sampleDataA);
                if (sampleDataB != null)
                {
                    Console.Write(sampleDataB);
                }
            }
        }

        [Test]
        public void Good()
        {
            LookupA.LoadSomeMaybe()
                .FlatMap(LookupB.LoadSomeMaybe)
                .ApplySome(Console.WriteLine);
        }
    }
}