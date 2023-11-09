using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter.Network
{
    internal class NetworkClient : INetworkClient
    {
        public void SendRequest(string ipAdress) {
            Console.WriteLine("network client request sent to IP: "+ ipAdress);

        }
    }
}
