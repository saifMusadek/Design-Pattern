using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade
{
    internal class Packet
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string IP {  get; set; }

        public void PacketBuild() {
            Console.WriteLine("Packet Built");
        }
    }
}
