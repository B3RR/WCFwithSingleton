using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFwithSingleton.Core.Common;
using WCFwithSingleton.Core.Controllers.Test;
using WCFwithSingleton.Model.Common;
using WCFwithSingleton.Model.Common.Enums;
using WCFwithSingleton.Model.Test;


namespace WCFwithSingleton.Test.Controllers
{
    [TestClass]
    public class TestControllerTest
    {
        [TestMethod]
        public void Check_Correct_Response()
        {
            var req = new TestRequest()
            {
                AuthenticationRequest = new AuthenticationRequest()
                {
                    UserId = "oleg",
                    Password = "oleg"
                },
                MessageText = "мир!"
            };

            var tc = new TestControllerWithSingleton(new InitSingleton() { Count = 1, Type = "Unit Tests" }, req);
            var res = (TestResponse)tc.GetResponse();
            Assert.AreEqual(res.ResponseInfo.ResponseType, ResponseType.Success);
            Assert.AreEqual(res.MessageText, "[1][Unit Tests] Привет мир!");
        }

        [TestMethod]
        public void Check_Authorization()
        {
            var req = new TestRequest()
            {
                AuthenticationRequest = new AuthenticationRequest()
                {
                    UserId = "oleg",
                    Password = "oleg2"
                },
                MessageText = "мир!"
            };

            var tc = new TestControllerWithSingleton(new InitSingleton() { Count = 1, Type = "Unit Tests" }, req);
            var res = tc.GetResponse();
            Assert.AreEqual(res.ResponseInfo.ResponseType, ResponseType.Fail);
        }

        [TestMethod]
        public void Check_Bad_Request()
        {
            var req = new TestRequest()
            {
                MessageText = "мир!"
            };

            var tc = new TestController(req);
            var res = tc.GetResponse();
            Assert.AreEqual(res.ResponseInfo.ResponseType, ResponseType.Fail);
        }


    }
}
