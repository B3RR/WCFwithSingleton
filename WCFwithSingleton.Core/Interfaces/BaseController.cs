using WCFwithSingleton.Model.Common;
using WCFwithSingleton.Model.Test;
using System;

namespace WCFwithSingleton.Core.Interfaces
{
    /// <summary>
    /// Базовый класс
    /// </summary>
    public abstract class BaseController
    {
        public InitSingleton InitSingleton { get; }
        public Request Request { get; }
        

        public BaseController(Request req)
        {
            if (req != null)
            {
                Request = req;
            }
            else
            {
                throw new ArgumentNullException($"{ nameof(req) } - is null");
            }
        }


        public BaseController(InitSingleton initSingleton, Request req)
        {
            if (req != null && initSingleton != null)
            {
                Request = req;
                InitSingleton = initSingleton;
            }
            else
            {
                throw new ArgumentNullException($"{ nameof(initSingleton)} or { nameof(req) } - is null");
            }
        }

    }
}
