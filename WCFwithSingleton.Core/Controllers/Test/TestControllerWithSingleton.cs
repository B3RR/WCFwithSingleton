using WCFwithSingleton.Model.Common;
using WCFwithSingleton.Core.Common;
using WCFwithSingleton.Model.Test;
using WCFwithSingleton.Core.Interfaces;

namespace WCFwithSingleton.Core.Controllers.Test
{
    public class TestControllerWithSingleton : BaseController, IWCFController
    {

        public TestControllerWithSingleton(InitSingleton initSingleton, TestRequest req) : base(initSingleton, req)
        {

        }

        public Response GetResponse()
        {
            var req = (TestRequest)Request;
            var cad = new WCFAuthentication(Request.AuthenticationRequest);
            var res = new TestResponse();
            res.ResponseInfo = cad.ResponseInfo;
            if (cad.Success)
            {
                res.MessageText += $"[{ InitSingleton.Count}][{InitSingleton.Type}] Привет { req.MessageText}";
            }
            return res;
        }
    }
}
