using System;

using System.Threading;


namespace WCFwithSingleton.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 1000; i++)
            {
                var t = new TestClass("Олег!");
                t.GetMessageAsync();
                t.GetMessage();
                Thread.Sleep(random.Next(i));
            }
        }


    }
}
