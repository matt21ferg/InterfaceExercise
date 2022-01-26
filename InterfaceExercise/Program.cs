using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */
                var Fusion = new Car();
            {
                Fusion.name = "Ford Fusion";
                Fusion.GoodMPG = true;
                Fusion.HasTrunk = true;
                Fusion.NumberOfWheels = 4;
                Fusion.NumberOfWindows = 4;
                Fusion.HasSteeringWheel = true;
                Fusion.NumberOfSeats = 5;
                Fusion.CompanyName = "Ford";
                Fusion.Logo = "the word Ford";
            }
                var Tahoe = new SUV();
            {
                Tahoe.name = "Chevy Tahoe";
                Tahoe.NumberOfSeats = 8;
                Tahoe.NumberOfWheels = 4;
                Tahoe.HasSkiRack = true;
                Tahoe.HasCargoTrunk = true;
                Tahoe.NumberOfWindows = 6;
                Tahoe.CompanyName = "Chevy";
                Tahoe.Logo = "the word Chevy";
                Tahoe.HasSteeringWheel  = true;
            }
                var Raptor = new Truck();
            {
                Raptor.name = "Ford Raptor";
                Raptor.NumberOfSeats = 4;
                Raptor.NumberOfWindows = 4;
                Raptor.NumberOfWheels = 4;
                Raptor.BedSize = "big bed";
                Raptor.HasSteeringWheel = true;
                Raptor.CompanyName = "Ford";
                Raptor.HasHitch = true;
                Raptor.HasSteeringWheel = true;
            }
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var Carlot = new List<IVehicle>();
            Carlot.Add(Fusion);
            Carlot.Add(Tahoe);
            Carlot.Add(Raptor);
            foreach (var item in Carlot)
            {
                Console.WriteLine($"the Name of the vehicle: {item.name}");
                Console.WriteLine($"number of seats: {item.NumberOfSeats} ");
                Console.WriteLine($"number of windows: {item.NumberOfWindows} ");
                Console.WriteLine($"number of wheels: {item.NumberOfWheels}");
                Console.WriteLine($"does it have steering wheel: {item.HasSteeringWheel}");
                Console.WriteLine("");
                
                    
            }
        }
    }
}
