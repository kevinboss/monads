using System.Linq;
using kms;
using NUnit.Framework;
using sampleInfrastructure;
using sampleInfrastructure.Maybe;

namespace sample.KmsMaybe
{
    public class KmsMaybe
    {
        [Test]
        public void Worst()
        {
            var sampleData = LookupA.LoadSome();
            Logger.Log(sampleData.SomeContent);
        }

        [Test]
        public void Bad()
        {
            var sampleData = LookupA.LoadSome();
            if (sampleData == null)
            {
                Logger.Log("No data");
            }
            else
            {
                Logger.Log(string.IsNullOrEmpty(sampleData.SomeContent) ? "No content" : sampleData.SomeContent);
            }
        }

        [Test]
        public void Meh()
        {
            var maybeSampleData = LookupA.LoadSomeKmsMaybe();
            if (!maybeSampleData.Any())
            {
                Logger.Log("No data");
            }
            else
            {
                Logger.Log(string.IsNullOrEmpty(maybeSampleData.First().SomeContent)
                    ? "No content"
                    : maybeSampleData.First().SomeContent);
            }
        }

        [Test]
        public void Meh2()
        {
            var maybeSampleData = LookupA.LoadSomeKmsMaybe();
            foreach (var sampleData in maybeSampleData)
            {
                Logger.Log(string.IsNullOrEmpty(sampleData.SomeContent) ? "No content" : sampleData.SomeContent);
            }
            //Empty-case?
        }

        [Test]
        public void Good()
        {
            var sampleData = LookupA.LoadSomeKmsMaybe();
            var content = sampleData
                .Map(e => e.SomeContent);
            content.ApplyNone(() => Logger.Log("No data"));
            content.ApplySome(e => Logger.Log(!string.IsNullOrEmpty(e) ? e : "No content"));
        }

        [Test]
        public void Great()
        {
            var sampleData = LookupA.LoadSomeKmsMaybe();
            sampleData.ApplyNone(() => Logger.Log("No data"));
            var content = sampleData.FlatMap(e => string.IsNullOrEmpty(e.SomeContent)
                ? new Maybe<string>()
                : new Maybe<string>(e.SomeContent));
            content.ApplyNone(() => Logger.Log("No content"));
            content.ApplySome(Logger.Log);
        }
    }
}