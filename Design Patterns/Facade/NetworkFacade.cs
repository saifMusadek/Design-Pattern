using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade
{
    internal class NetworkFacade
    {
        private Packet packet;
        private Socket socket;
        private Transmission transmission;

        public NetworkFacade(string IP, string protocol) { 
            this.packet = new Packet();
            this.socket = new Socket(protocol);
            this.transmission = new Transmission(protocol);
        
        }

        public void BuildNetworkLayer()
        {
            packet.PacketBuild();
            socket.SocketBuild();
           
        }

            public void SendPacketOverNetwork() { 
                BuildNetworkLayer();
            transmission.SendTransmission();

        }
        
        }
    }

