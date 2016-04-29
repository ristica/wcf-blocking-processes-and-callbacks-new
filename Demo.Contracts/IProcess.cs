using System.ServiceModel;

namespace Demo.Contracts
{
    [ServiceContract(CallbackContract = typeof(IProcessCallback))]
    public interface IProcess
    {
        [OperationContract]
        void StartProcess();

        [OperationContract]
        bool Connect();

        [OperationContract]
        void Disconnect();
    }
}
