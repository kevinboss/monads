using System;
using functional.Result;

namespace sampleInfrastructure.Result
{
    public class LoginConnectionFactory
    {
        public static LoginConnection CreateSuccessful()
        {
            return new LoginConnection();
        }
        
        public static LoginConnection CreateFailure()
        {
            return null;
        }

        public static  Result<LoginConnection> CreateSuccessfulResult()
        {
            return Result<LoginConnection>.Success(new LoginConnection());
        }

        public static  Result<LoginConnection> CreateFailureResult()
        {
            return Result<LoginConnection>.Fail("Unbehandelter Fehler");
        }
    }
}