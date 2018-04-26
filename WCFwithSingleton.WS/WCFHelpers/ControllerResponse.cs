using WCFwithSingleton.Core.Interfaces;
using WCFwithSingleton.Model.Common;
using WCFwithSingleton.Model.Common.Enums;
using System;


namespace WCFwithSingleton.WS.WCFHelpers
{
    /// <summary>
    /// Получение ответа от контроллера
    /// </summary>
    /// <typeparam name="C">Контроллер</typeparam>
    /// <typeparam name="R">Ответ</typeparam>
    public class ControllerResponse<C, R> where C : IWCFController where R : Response
    {
        public R Response { get; }
        public ControllerResponse(Request req, InitSingleton initService = null)
        {
            try
            {
                //итератор счетчика запросов
                if (initService != null)
                {
                    initService.Count = ++initService.Count;
                }
                if (req != null && initService != null)
                {
                    var wsController = (C)Activator.CreateInstance(typeof(C), initService, req);
                    Response = (R)wsController.GetResponse();
                }
                else if (req != null)
                {
                    var wsController = (C)Activator.CreateInstance(typeof(C), req);
                    Response = (R)wsController.GetResponse();
                }
                else
                {
                    throw new ArgumentNullException($"{nameof(req)} is null");
                }
                if ((Response?.ResponseInfo?.ResponseType ?? ResponseType.Fail) == ResponseType.Success)
                {
                    Logger.Log4net.Log.Info(LoggerHelper.GetInfoLog(req, Response, initService));
                }
                else
                {
                    Logger.Log4net.Log.Warn(LoggerHelper.GetWarnLog(req, Response, initService));
                }

            }
            catch (Exception ex)
            {
                var er = new ExceptionResponse<R>(ex);
                Response = (R)er.Response;
                Logger.Log4net.Log.Error(LoggerHelper.GetErrorLog(ex, req, Response, initService));
            }

        }





    }
}