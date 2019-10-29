using System;
using functional.Result;

namespace sampleInfrastructure.Result
{
    public class LoginConnection
    {
        public DataConnection LoginSuccessful(string username, string password)
        {
            return new DataConnection();
        }

        public DataConnection LoginFailure(string username, string password)
        {
            return null;
        }

        public Result<DataConnection> LoginSuccessfulResult(string username, string password)
        {
            return Result<DataConnection>.Success(new DataConnection());
        }

        public Result<DataConnection> LoginFailureResult(string username, string password)
        {
            return Result<DataConnection>.Fail("Unbehandelter Fehler");
        }
    }
}