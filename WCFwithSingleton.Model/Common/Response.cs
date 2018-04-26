using WCFwithSingleton.Model.Common.Interfaces;
using System.Runtime.Serialization;


namespace WCFwithSingleton.Model.Common
{

    [DataContract(Namespace = CONST.NAMESPACE)]
    public abstract class Response : IResponse
    {
        [DataMember(IsRequired = true, Order = 0)]
        public ResponseInfo ResponseInfo
        {
            get;
            set;
        }
    }
}
