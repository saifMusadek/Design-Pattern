using Design_Patterns;
using Design_Patterns.Adapter;
using Design_Patterns.Adapter.DataProcessor;
using Design_Patterns.Adapter.Network;
using Design_Patterns.ChainOfResponsibility;
using Design_Patterns.Facade;
using Design_Patterns.Factory.NetworkFactory;
using Design_Patterns.Factory.NetworkUtility;
using Design_Patterns.Observer;
using Design_Patterns.Proxy;
using Design_Patterns.Singleton;
using System.Data.Common;
using System.Net.NetworkInformation;
using Ping = Design_Patterns.Factory.NetworkUtility.Ping;


/*

NetworkFacade networkFacade = new NetworkFacade("8.8.8.8.8","UDP");

networkFacade.BuildNetworkLayer();
networkFacade.SendPacketOverNetwork();
*/

/*

INetworkClient network = new NetworkClient();
network.SendRequest("2.4.2.3");

IDataProcessor dataProcessor = new DataProcessor ();
dataProcessor.SendNetworkRequest("2.4.2.4","fakeKey");

NetworkAdapter adapter = new NetworkAdapter(dataProcessor);
adapter.SendRequest("3.3.3.3.3");

*/
/*
//proxy Pattern


ISuperSecretDatabase db = new SuperSecretDatabaseProxy("testdb", "password");
*/


//----------------------------------------------------------------------------------

//SingleTon
//Singleton object1 = Singleton.Instance();

//Singleton object2 = Singleton.Instance();

//if (object1 == object2) {
//    Console.WriteLine("These objects are the same");
//}



//----------------------------------------------------------------------------------

//Factory Pattern
//NetworkFactory factory = new NetworkFactory();
//var ping = factory.GetNetworkInstance("ping");
//var dns = factory.GetNetworkInstance("dns");
//var arp = factory.GetNetworkInstance("arp");

//ping.SendRequest("2342.424.242", 2);
//dns.SendRequest("2342.424.242", 2);

//arp.SendRequest("2342.424.242", 2);


//----------------------------------------------------------------------------------

//ChainOfResponsibility
//IChain obj1 = new SendSSH();
//IChain obj2 = new SendPing();
//IChain obj3 = new SendARP();

//obj1.SetNext(obj2);
//obj2.SetNext(obj3);

//NetworkModel request = new NetworkModel("8.8.8.8)", false); ;
//obj1.SendRequest(request);


//----------------------------------------------------------------------------------


//Observer (Weather station brodcasting to its connected observers news agencies
WeatherStation weatherStation = new WeatherStation();
NewsAgency agency1 = new NewsAgency("Alpha News Agency");
weatherStation.Attach(agency1);

NewsAgency agency2 = new NewsAgency("Beta News Agency");
weatherStation.Attach(agency2);

NewsAgency agency3 = new NewsAgency("Gama News Agency");
weatherStation.Attach(agency3);

weatherStation.Temperature = 31.2f;
weatherStation.Temperature = 20.2f;
weatherStation.Temperature = 22.2f;



//