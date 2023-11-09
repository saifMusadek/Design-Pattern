using Design_Patterns.Adapter.DataProcessor;
using Design_Patterns.Adapter.Network;
using Design_Patterns.Factory.NetworkUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter
{
    internal class NetworkAdapter : INetworkClient
    {
       
        private readonly IDataProcessor _dataProcessor;
        public NetworkAdapter(IDataProcessor dataProcessor)
        {
            _dataProcessor = dataProcessor;
        }
        public void SendRequest(string ipAdress)
        {
            var apikey = "awfawfawfwfa";
            _dataProcessor.SendNetworkRequest(apikey, ipAdress);
        }
    }
}
