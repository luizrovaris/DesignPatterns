namespace Singleton
{
    public static class Helper
    {
        public static void Log(string info)
        {
            GenericLog.LogInstance.LogInfo(info);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
