using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.ChainOfResponsibility
{
    internal class SendSSH : IChain
    {
        //Bringing in the chian 
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send SSH failed. Sending PING");
                next.SendRequest(request);
            }
            else {

                Console.WriteLine("Send SSH Success");

            }
        }

        //will hold the reference to the next object that we wnat our flow to go to
        public void SetNext(IChain nextChian)
        {
           this.next = nextChian;
        }
    }
}
