using System;
using functional.Result;

namespace sampleInfrastructure
{
    public class LoginConnectionFactory
    {
        public LoginConnection CreateSuccessful()
        {
            return new LoginConnection();
        }
        
        public LoginConnection CreateFailure()
        {
            throw new Exception();
        }

        public Result<LoginConnection> LoginSuccessfulResult(string username, string password)
        {
            return Result<LoginConnection>.Success(new LoginConnection());
        }

        public Result<LoginConnection> LoginFailureResult(string username, string password)
        {
            return Result<LoginConnection>.Fail("Unbehandelter Fehler");
        }
    }
}