using System;

namespace Singleton
{
    /// <summary>
    /// Singleton Instance
    /// </summary>
    public sealed class GenericLog
    {
        private static GenericLog logInstance;
        private static Guid LogInstanceId { get; set; }
        private static object padlock = new Object();

        private GenericLog(Guid logInstanceId)
        {
            LogInstanceId = logInstanceId;
        }

        public static GenericLog LogInstance 
        {
            get
            {
                lock(padlock)
                { 
                    if (logInstance == null)
                    {
                        logInstance = new GenericLog(Guid.NewGuid());
                    }
                }

                return logInstance;
            }
        }

        public void LogInfo(string info)
        {
            Console.WriteLine($"{LogInstanceId} - {info}");
        }
    }
}
