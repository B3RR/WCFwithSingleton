using WCFwithSingleton.WS.WCFHelpers;
using WCFwithSingleton.Core.Controllers.Test;
using WCFwithSingleton.Model.Test;
using System.ServiceModel;
using WCFwithSingleton.Model.Common;

namespace WCFwithSingleton.WS
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WCFwithSingletonWS : IWCFwithSingletonWS
    {
        InitSingleton initService { get; }
        public WCFwithSingletonWS()
        {
            initService = new InitSingleton() { Type = "WCF" };
        }

        public WCFwithSingletonWS(InitSingleton initService)
        {
            this.initService = initService;
        }

        public TestResponse GetTest(TestRequest testRequest)
        {
            var res = new ControllerResponse<TestController, TestResponse>(testRequest);
            return res.Response;
        }

        public TestResponse GetTestWithSingleton(TestRequest testRequest)
        {
            var res = new ControllerResponse<TestControllerWithSingleton, TestResponse>(testRequest, initService);
            return res.Response;
        }
    }

}
