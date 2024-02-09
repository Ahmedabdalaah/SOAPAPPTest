namespace SOAPAPPTest.BusinessLogic
{
    public class SoapServiceClient : ISoapService
    {
        public string CalcTax(int price)
        {
            return $"the tax is {price * 0.15} ";
        }
    }
}
