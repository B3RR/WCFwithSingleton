using WCFwithSingleton.Model.Common;
using WCFwithSingleton.Model.Common.Enums;
using System;
using System.ServiceModel.Web;

namespace WCFwithSingleton.Core.Common
{
    public class WCFAuthentication
    {
        public bool Success { get; }
        public ResponseInfo ResponseInfo { get; }

        public WCFAuthentication(AuthenticationRequest ar)
        {
            try
            {
                if (ar != null)
                {
                    var authResponse = new AuthenticationResponse()
                    {
                        UserId = ar.UserId,
                        SessionId = GetSessionId(ar.UserId, ar.Password)
                    };

                    if (!String.IsNullOrWhiteSpace(authResponse.SessionId))
                    {
                        Success = true;
                        ResponseInfo = new ResponseInfo()
                        {
                            AuthenticationResponse = authResponse,
                            ResponseType = ResponseType.Success
                        };
                    }
                    else
                        throw new Exception("Не удалось сгенерировать SessionId");
                }
                else
                    throw new Exception("Не были указаны входные параметры для авторизации");
            }
            catch (Exception ex)
            {
                Success = false;
                var wcfException = new WCFException(ex);
                ResponseInfo = wcfException.GetResponseInfoWithException();
                var context = WebOperationContext.Current;
                if (context != null)
                {
                    context.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Unauthorized;
                }

            }
        }

        private string GetSessionId(string login, string password)
        {
            if (String.IsNullOrWhiteSpace(login))
            {
                throw new Exception("Login is empty");
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Passowrd is empty");
            }

            if (login == password)
            {
                return Guid.NewGuid().ToString();
            }
            else
            {
                return String.Empty;
            }
        }



    }
}
