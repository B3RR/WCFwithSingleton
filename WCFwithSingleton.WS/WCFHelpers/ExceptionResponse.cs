using WCFwithSingleton.Core.Common;
using WCFwithSingleton.Model.Common;
using System;
using System.ServiceModel.Web;

namespace WCFwithSingleton.WS.WCFHelpers
{

    /// <summary>
    /// Возвращает ошибочный Response (http error code - 500)
    /// </summary>
    /// <typeparam name="T">Тип возвращаемого ответа</typeparam>
    public class ExceptionResponse<T> where T: Response
    {
        public Response Response { get; }
        public ExceptionResponse(Exception ex)
        {
            var errorRes = (T)Activator.CreateInstance(typeof(T));
            errorRes.ResponseInfo = new WCFException(ex).GetResponseInfoWithException();
            Response = errorRes;
            var context = WebOperationContext.Current;
            if (context != null)
            {
                context.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.InternalServerError;
            }
        }


    }
}