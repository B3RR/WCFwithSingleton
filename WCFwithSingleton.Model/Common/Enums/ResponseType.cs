using WCFwithSingleton.Helper.Attributes;
using System.Runtime.Serialization;

namespace WCFwithSingleton.Model.Common.Enums
{
    [DataContract(Namespace = CONST.NAMESPACE)]
    public enum ResponseType
    {
        [EnumMember]
        [EnumFieldText("Успешно")]
        Success=0,
        [EnumMember]
        [EnumFieldText("Не успешно")]
        Fail=1
    }
}
