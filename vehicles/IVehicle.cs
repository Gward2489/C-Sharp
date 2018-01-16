using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public interface IVehicle 
    {
        int wheels {get; set;}
        int doors {get; set;}
        int PassangerCapacity {get; set;}
        string TransmissionType {get; set;}
        double EngineVolume {get; set;}
        void start();
        void stop();

    }
}