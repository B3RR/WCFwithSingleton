using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFwithSingleton.Helper.Helpers
{
    public class ConfigHelper
    {
        private static bool GetBooleanFromString(string value)
        {
            return (value?.Trim().ToLower() == "true");
        }
        
        /// <summary>
        /// Писать успешные response и request в лог.
        /// </summary>
        public static bool LogSuccessRequestAndResponse =>  GetBooleanFromString(ConfigurationManager.AppSettings["logSuccessRequestAndResponse"]);

        /// <summary>
        /// Писать неуспешные response и request в лог.
        /// </summary>
        public static bool LogFailRequestAndResponse => GetBooleanFromString(ConfigurationManager.AppSettings["logFailRequestAndResponse"]);



    }
}
