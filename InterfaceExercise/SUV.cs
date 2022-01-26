using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise 
{
    internal class SUV : IVehicle , ICompany
    {
        public bool HasCargoTrunk { get; set; }
        public bool HasSkiRack { get; set; }
        public int NumberOfWheels { get ; set; }
        public int NumberOfWindows { get ;set; }
        public bool HasSteeringWheel { get; set; }
        public int NumberOfSeats { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public string name { get; set; }
    }
}
