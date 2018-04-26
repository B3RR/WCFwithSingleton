using WCFwithSingleton.Model.Common.Interfaces;
using System.Runtime.Serialization;


namespace WCFwithSingleton.Model.Common
{

    [DataContract(Namespace = CONST.NAMESPACE)]
    public abstract class Request : IRequest
    {
        [DataMember(IsRequired = true, Order = 0)]
        public AuthenticationRequest AuthenticationRequest { get; set; }

    }
}
