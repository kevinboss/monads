using System;
using functional.Result;

namespace sampleInfrastructure
{
    public class DataConnection
    {
        public string GetDataSuccessful()
        {
            return "Hello World";
        }

        public string GetDataFailure()
        {
            throw new Exception();
        }

        public Result<string> LoginSuccessfulResult()
        {
            return Result<string>.Success("Hello World");
        }

        public Result<string> LoginFailureResult()
        {
            return Result<string>.Fail("Unbehandelter Fehler");
        }
    }
}