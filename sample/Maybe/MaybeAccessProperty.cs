using functional.Maybe;
using NUnit.Framework;
using sampleInfrastructure;

namespace sample.Maybe
{
    public class MaybeAccessProperty
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
        public void Good()
        {
            var sampleData = LookupA.LoadSomeMaybe();
            var content = sampleData
                .Map(e => e.SomeContent);
            content.ApplyNone(() => Logger.Log("No data"));
            content.ApplySome(e => Logger.Log(!string.IsNullOrEmpty(e) ? e : "No content"));
        }

        [Test]
        public void Great()
        {
            var sampleData = LookupA.LoadSomeMaybe();
            sampleData.ApplyNone(() => Logger.Log("No data"));
            var content = sampleData.FlatMap(e => string.IsNullOrEmpty(e.SomeContent)
                ? Maybe<string>.Absent()
                : Maybe<string>.Of(e.SomeContent));
            content.ApplyNone(() => Logger.Log("No content"));
            content.ApplySome(Logger.Log);
        }
    }
}