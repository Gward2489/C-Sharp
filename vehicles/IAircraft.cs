using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public interface IAircraft 
    {
        bool winged {get; set;}
        double MaxAirSpeed {get; set;}
        void fly();

    }
}