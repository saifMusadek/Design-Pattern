using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter.Network
{
    internal interface INetworkClient
    {
        void SendRequest(string ipAdress);
    }
}
