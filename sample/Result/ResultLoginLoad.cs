using NUnit.Framework;
using sampleInfrastructure;
using sampleInfrastructure.Result;

namespace sample.Result
{
    public class ResultLoginLoad
    {
        [Test]
        public void Worst()
        {
            var loginConnection = LoginConnectionFactory.CreateSuccessful();
            var connection = loginConnection.LoginSuccessful("username", "password");
            var data = connection.GetDataSuccessful();
            Logger.Log(data);
        }

        [Test]
        public void Bad()
        {
            var loginConnection = LoginConnectionFactory.CreateSuccessful();
            if (loginConnection != null)
            {
                var connection = loginConnection.LoginSuccessful("username", "password");
                if (connection != null)
                {
                    var data = connection.GetDataSuccessful();
                    Logger.Log(!string.IsNullOrEmpty(data) ? data : "Unbehandelter Fehler");
                }
                else
                {
                    Logger.Log("Unbehandelter Fehler");
                }
            }
            else
            {
                Logger.Log("Unbehandelter Fehler");
            }
        }

        [Test]
        public void Good()
        {
            var data = LoginConnectionFactory.CreateSuccessfulResult()
                .FlatMap(loginConnection => loginConnection.LoginSuccessfulResult("username", "password"))
                .FlatMap(dataConnection => dataConnection.GetDataSuccessfulResult());
            data.ApplySuccessful(Logger.Log);
            data.ApplyFailure(Logger.Log);
        }
    }
}