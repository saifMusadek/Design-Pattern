using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade
{
    internal class Transmission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Transmission(string protocalname) {

            this.Name = protocalname;
        }

        public void SendTransmission() {
            Console.WriteLine("Sent Transmission");
        }
    }
}
