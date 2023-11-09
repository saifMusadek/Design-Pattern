using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter.DataProcessor
{
    internal class DataProcessor : IDataProcessor
    {
        public bool DataProcess() {
            Console.WriteLine("Processed Data");
            return true; 
        }
        public void SendNetworkRequest(string ip, string apiKey) {

            Console.WriteLine("Send network with ip address that requires APIKEY: " + ip);

        }
    }
}
