using WCFwithSingleton.Core.Interfaces;
using WCFwithSingleton.Model.Common;
using WCFwithSingleton.Model.Common.Enums;
using System;

namespace WCFwithSingleton.Core.Common
{
    public class WCFException : IWCFExceptionResponseInfo
    {
        private ResponseInfo _responseInfo { get; }

        public WCFException(Exception ex)
        {
            _responseInfo = new ResponseInfo()
            {
                ResponseType = ResponseType.Fail,
                ErrorText = ex.Message,
                StackTrace = ex.StackTrace
            };
        }

        public ResponseInfo GetResponseInfoWithException()
        {
            return _responseInfo;
        }
    }
}
