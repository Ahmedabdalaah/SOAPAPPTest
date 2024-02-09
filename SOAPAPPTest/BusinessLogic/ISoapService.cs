using System.ServiceModel;

namespace SOAPAPPTest.BusinessLogic
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string CalcTax(int price);
    }
}
