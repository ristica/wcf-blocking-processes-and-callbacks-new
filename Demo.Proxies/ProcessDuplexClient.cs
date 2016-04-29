using Demo.Contracts;
using System.ServiceModel;
using System;

namespace Demo.Proxies
{
    public class ProcessDuplexClient : DuplexClientBase<IProcess>, IProcess
    {
        public ProcessDuplexClient(InstanceContext callback)
            : base(callback)
        { }

        public bool Connect()
        {
            return Channel.Connect();
        }

        public void Disconnect()
        {
            Channel.Disconnect();
        }

        public void StartProcess()
        {
            Channel.StartProcess();
        }
    }
}
