using WCFwithSingleton.Model.Common;
using System.Runtime.Serialization;


namespace WCFwithSingleton.Model.Test
{

    [DataContract(Namespace = CONST.NAMESPACE)]
    public class TestResponse : Response
    {
        [DataMember(EmitDefaultValue = false)]
        public string MessageText { get; set; }
    }
}
