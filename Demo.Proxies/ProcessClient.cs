using Demo.Contracts;
using System.ServiceModel;
using System;

namespace Demo.Proxies
{
    public class ProcessClient : ClientBase<IProcess>, IProcess
    {
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
