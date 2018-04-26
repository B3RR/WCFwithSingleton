using WCFwithSingleton.Model.Common.Enums;
using System.Runtime.Serialization;

namespace WCFwithSingleton.Model.Common
{

    [DataContract(Namespace = CONST.NAMESPACE)]
    public class ResponseInfo
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public AuthenticationResponse AuthenticationResponse { get; set; }
        [DataMember(IsRequired = true, Order = 1)]
        public ResponseType ResponseType { get;set;}
        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string ErrorText { get; set; }
        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string StackTrace { get; set; }
    }

}
