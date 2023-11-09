using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.ChainOfResponsibility
{
    public interface IChain
    {
        void SendRequest(NetworkModel request);
        //pointing to next action 
        void SetNext(IChain nextChian);
    }
}
