using NUnit.Framework;
using sampleInfrastructure;

namespace sample.Maybe
{
    public class MaybeLoadPersist
    {
        [Test]
        public void Worst()
        {
            var sampleData = LookupA.LoadSome();
            RepositoryA.Persist(sampleData);
        }

        [Test]
        public void Bad()
        {
            var sampleData = LookupA.LoadSome();
            if (sampleData != null)
            {
                RepositoryA.Persist(sampleData);
            }
            else
            {
                Logger.Log("No data");
            }
        }

        [Test]
        public void Good()
        {
            var sampleData = LookupA.LoadSomeMaybe();
            sampleData.ApplyNone(() => Logger.Log("No data"));
            sampleData.ApplySome(RepositoryA.Persist);
        }
    }
}