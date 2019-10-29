using System;

namespace sampleInfrastructure
{
    public static class Logger
    {
        public static void Log(string text)
        {
            Console.WriteLine(text);
        }

        public static void Log(Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }
    }
}