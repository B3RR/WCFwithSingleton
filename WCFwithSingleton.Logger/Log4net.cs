using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFwithSingleton.Logger
{
    public static class Log4net
    {
        private static ILog _log = LogManager.GetLogger("LOGGER");

        public static bool IsInit { get; set; }
        public static void Init()
        {
            XmlConfigurator.Configure();
            IsInit = true;
            Log.Info("log4net was init");
        }

        public static ILog Log
        {
            get { return _log; }
        }

    }
}
