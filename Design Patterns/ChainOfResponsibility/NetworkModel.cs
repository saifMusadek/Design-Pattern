using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.ChainOfResponsibility
{

    //this network model is what is going to be passed in the chains
    public class NetworkModel
    {
        public string IP { get; set; }

        // this success identifier is for the if statement
        public bool Success { get; set; }


        // need a way to show success
        public NetworkModel(String IP, bool success) {
            this.IP = IP;
            this.Success = success;
        
        }
    }
}
