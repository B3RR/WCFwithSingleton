using WCFwithSingleton.Model.Common;
using WCFwithSingleton.Core.Common;
using WCFwithSingleton.Model.Test;
using WCFwithSingleton.Core.Interfaces;

namespace WCFwithSingleton.Core.Controllers.Test
{
    public class TestController : BaseController, IWCFController
    {
        public TestController(TestRequest req) : base(req)
        {

        }

        public Response GetResponse()
        {
            var req = (TestRequest)Request;
            var res = new TestResponse();
            var cad = new WCFAuthentication(Request.AuthenticationRequest);
            res.ResponseInfo = cad.ResponseInfo;
            if (cad.Success)
            {
                res.MessageText += $"Привет { req.MessageText}";
            }
            return res;
        }
    }
}
