using System;
using kms;
using NUnit.Framework;
using sampleInfrastructure;

namespace sample.KmsMaybe
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
            LookupA.LoadSomeKmsMaybe()
                .FlatMap(LookupB.LoadSomeKmsMaybe)
                .ApplySome(Console.WriteLine);
        }
    }
}