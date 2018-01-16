using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public interface ILandCraft
    {
        double MaxLandSpeed {get;set;}
        void Drive();
    }
}