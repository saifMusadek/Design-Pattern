using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Design_Patterns.ChainOfResponsibility
{

    internal class SendARP : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send SSH failed. Sending PING");
                if (next != null)
                {
                    next.SendRequest(request);
                }
                else {
                    Console.WriteLine("Network transmission failed!!! Shutting down");
                }
            }
            else
            {

                Console.WriteLine("Send SSH Success");

            }
        }

        public void SetNext(IChain nextChian)
        {
            this.next = nextChian;
        }
    }
}
