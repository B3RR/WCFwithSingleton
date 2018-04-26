using System;
using System.Runtime.Serialization;

namespace WCFwithSingleton.Model.Common
{
    [DataContract(Namespace = CONST.NAMESPACE)]
    public class AuthenticationRequest
    {
        [DataMember(IsRequired = true, Order = 0)]
        public string UserId { get; set; }
        [DataMember(IsRequired = true, Order = 1)]
        public string Password { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string SessionId { get; set; }

    }
}
