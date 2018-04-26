using WCFwithSingleton.Helper.Attributes;
using WCFwithSingleton.Model;
using WCFwithSingleton.Model.Test;
using System.ServiceModel;


namespace WCFwithSingleton.WS
{
 
    [ServiceContract(Namespace = CONST.NAMESPACE)]
    [RequiredParametersBehavior]
    public interface IWCFwithSingletonWS
    {
        [OperationContract]
        TestResponse GetTest(TestRequest TestRequest);

        [OperationContract]
        TestResponse GetTestWithSingleton(TestRequest TestRequest);

    }
}
