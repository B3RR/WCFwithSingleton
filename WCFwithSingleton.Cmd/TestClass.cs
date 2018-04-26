using WCFwithSingleton.Cmd.WCFwithSingletonWS;
using System;
using System.Threading;

namespace WCFwithSingleton.Cmd
{

    public class TestClass
    {
        public string Message { get; set; }

        public TestClass()
        {
            Message = "мир!";
        }

        public TestClass(string message)
        {
            Message = message;
        }

        public void GetMessage()
        {
            using (var client = new WCFwithSingletonWSClient())
            {
                var msg = new TestRequest()
                {
                    AuthenticationRequest = new AuthenticationRequest()
                    {
                        UserId = "oleg",
                        Password = "oleg"
                    },
                    MessageText = Message

                };
                var temp = client.GetTest(msg);
                var xmlResponseString = Helper.Helpers.XMLHelper.ConvertObjectToXmlString(temp);

                Console.WriteLine($"Sync - {temp.ResponseInfo.ResponseType} {temp.MessageText}");
                Console.WriteLine(xmlResponseString);
                client.Close();
            }

        }

        public async void GetMessageAsync()
        {
            using (var client = new WCFwithSingletonWSClient())
            {
                var msg = new TestRequest()
                {
                    AuthenticationRequest = new AuthenticationRequest()
                    {
                        UserId = "oleg",
                        Password = "oleg"
                    },
                    MessageText = Message

                };

                var xmlRequestString = Helper.Helpers.XMLHelper.ConvertObjectToXmlString(msg);

                var temp = await client.GetTestAsync(msg);
                Thread.Sleep(3000);
                Console.WriteLine($"Async - {temp.ResponseInfo.ResponseType} {temp.MessageText}");
                Console.WriteLine(xmlRequestString);
                client.Close();
            }
        }

    }
}
