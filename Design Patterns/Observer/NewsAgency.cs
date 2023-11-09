using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    internal class NewsAgency : IObserver
    {
        public String AgencyName { get; set; }
        public NewsAgency(String name) { 
        AgencyName = name;
        }
        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
            {
                Console.WriteLine(String.Format("{0} reporting temperature {1} degree celcius", AgencyName, weatherStation.Temperature));
                Console.WriteLine();
            }
        }
    }
}
