using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    internal interface ISubject
    {

        //Register themselves
        void Attach(IObserver observer);

        //Notify each observer that change has been made
        void Notify();

    }
}
