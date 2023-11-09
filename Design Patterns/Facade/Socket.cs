using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade
{
    internal class Socket
        
    {
        public int IP { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }
        public Socket(string protocoll) {

            this.Protocol = protocoll;
        }

        public void SocketBuild()
        {
            Console.WriteLine("Socket Built");
        }
    }
}
