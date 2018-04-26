using WCFwithSingleton.Model.Common;
using WCFwithSingleton.Model.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFwithSingleton.WS.WCFHelpers
{
    public class LoggerHelper
    {
        private const string nl = "\r\n";
        public static string GetInfoLog(Request req, Response res, InitSingleton initService)
        {
            var log = $"[{initService?.Type}] - [{ initService?.Count}] - [{req.AuthenticationRequest.UserId}] - " +
                $"{req.GetType().Name} - " +
                $"{res.ResponseInfo.ResponseType}";

            if (Helper.Helpers.ConfigHelper.LogSuccessRequestAndResponse)
            {
                log += nl + $"-----------------Request----------------------" + nl +
                $"{Helper.Helpers.XMLHelper.ConvertObjectToXmlString(req)}" + nl +
                $"-----------------Response---------------------" + nl +
                $"{Helper.Helpers.XMLHelper.ConvertObjectToXmlString(res)}";
            }
            return log.Replace("[] - [] - ", "");
        }
        public static string GetWarnLog(Request req, Response res, InitSingleton initService)
        {
            var log = $"[{initService?.Type}] - [{ initService?.Count}] - [{req?.AuthenticationRequest?.UserId}] - " +
                      $"{req?.GetType().Name} - " +
                      $"{res?.ResponseInfo?.ResponseType ?? ResponseType.Fail}{nl}" +
                      $"{res?.ResponseInfo?.ErrorText ?? "Ошибка неизвестна"}";
            if (Helper.Helpers.ConfigHelper.LogFailRequestAndResponse)
            {
                log += nl + $"-----------------Request----------------------" + nl +
                $"{Helper.Helpers.XMLHelper.ConvertObjectToXmlString(req)}" + nl +
                $"-----------------Response---------------------" + nl +
                $"{Helper.Helpers.XMLHelper.ConvertObjectToXmlString(res)}";
            }
            return log.Replace("[] - [] - ","");
        }

        public static string GetErrorLog(Exception ex, Request req, Response res, InitSingleton initService)
        {
            var log = $"[{initService?.Type}] - [{ initService?.Count}] - [{req?.AuthenticationRequest?.UserId}] - " +
                          $"{req?.GetType().Name} - " +
                          $"{res?.ResponseInfo?.ResponseType + nl} " + nl +
                          $"{ex?.Message ?? "Ошибка неизвестна" + nl + ex?.StackTrace}";

            if (Helper.Helpers.ConfigHelper.LogFailRequestAndResponse)
            {
                log += nl + $"-----------------Request----------------------" + nl +
                $"{Helper.Helpers.XMLHelper.ConvertObjectToXmlString(req)}" + nl;
                if (res != null)
                {
                    log += $"-----------------Response---------------------" + nl +
                    $"{Helper.Helpers.XMLHelper.ConvertObjectToXmlString(res)}";
                }
            }
            return log.Replace("[] - [] - ", "");
        }

    }
}