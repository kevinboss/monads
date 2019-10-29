using System;
using functional.Result;

namespace sampleInfrastructure.Result
{
    public class DataConnection
    {
        public string GetDataSuccessful()
        {
            return "Hello World";
        }

        public string GetDataFailure()
        {
            return null;
        }

        public Result<string> GetDataSuccessfulResult()
        {
            return Result<string>.Success("Hello World");
        }

        public Result<string> GetDataFailureResult()
        {
            return Result<string>.Fail("Unbehandelter Fehler");
        }
    }
}