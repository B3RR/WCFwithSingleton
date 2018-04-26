namespace WCFwithSingleton.Model.Common
{
    public class InitSingleton
    {
        public InitSingleton()
        {
            if (!Logger.Log4net.IsInit)
            {
                Logger.Log4net.Init();
            }
        }
        public int Count { get; set; }
        public string Type { get; set; }
    }
}