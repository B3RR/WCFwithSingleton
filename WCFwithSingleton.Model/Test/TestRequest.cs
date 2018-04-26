using WCFwithSingleton.Model.Common;
using System.Runtime.Serialization;

namespace WCFwithSingleton.Model.Test
{

    [DataContract(Namespace = CONST.NAMESPACE)]
    public class TestRequest: Request
    {
        [DataMember(IsRequired = true)]
        public string MessageText { get; set; }
    }
}
