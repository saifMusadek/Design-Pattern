using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    internal interface IObserver
    {

        //Will be called whenever its state is being changed
        void Update(ISubject subject);

    }
}
