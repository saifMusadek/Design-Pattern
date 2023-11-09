using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public class Singleton
    {

        //self referencing is used in singleton
        static Singleton instance; // self refrencing property 
        public string Setting { get; set; } = "color blue";
        protected Singleton() { }

        public static Singleton Instance()
        {

            if (instance == null)
            {
                instance = new Singleton(); //new instance will not be crated here because there exists a spefific method for it

                Console.WriteLine("New instance is created");
            }
            else
            {
                Console.WriteLine("nothing happened");
            }

            return instance;
        }

    }
}
