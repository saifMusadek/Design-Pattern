using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Design_Patterns.ChainOfResponsibility
{
    internal class SendPing : IChain
    {
        IChain next;
        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send ping failed. Sending ARP");
                next.SendRequest(request);
            }
            else
            {

                Console.WriteLine("Send Ping Success");

            }
        }

        public void SetNext(IChain nextChian)
        {
            this.next = nextChian;
        }
    }
}
