using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public interface IWaterCraft
    {
        double MaxWaterSpeed {get; set;}
        void pilot();
    }
}