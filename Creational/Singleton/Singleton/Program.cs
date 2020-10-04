using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Log($"{DateTime.Now} - Info");
            Helper.Log($"{DateTime.Now} - HelperInfo");
        }

        public static void Log(string info)
        {
            GenericLog.LogInstance.LogInfo(info);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
