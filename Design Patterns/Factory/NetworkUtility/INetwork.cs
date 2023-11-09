using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory.NetworkUtility
{
    public interface INetwork
    {
        public void SendRequest(String ip, int timeSent);
    }
}
