using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter.DataProcessor
{
    internal interface IDataProcessor
    {
        bool DataProcess();
        void SendNetworkRequest(string ip, string apiKey);
    }
}
