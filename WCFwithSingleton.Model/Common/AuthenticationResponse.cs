
using System.Runtime.Serialization;


namespace WCFwithSingleton.Model.Common
{

    [DataContract(Namespace = CONST.NAMESPACE)]
    public class AuthenticationResponse
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string UserId { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string SessionId { get; set; }

    }
}
