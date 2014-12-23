using System;
using System.Collections.Generic;

namespace Assignment14
{
    class MainClass
    {
        /// <summary>
        /// string to rpint the vehicle detail
        /// </summary>
        private const string VehicleDetail = "{0} {1} {2}";
        private const string PrintEquality = "Both Objects are same";
        static void Main(string[] args)
        {
            /// list to conatin vehicles
            Vehicle<int> objVehicle = new Vehicle<int>();
            List<Vehicle<int>> list = objVehicle.GetVehicle();

            ///sorted list by speed asc
            list.Sort();           

            ///print objects sorted by speed
            foreach (var item in list)
            {
                Console.WriteLine(VehicleDetail, item.Make, item.Model, item.Speed);
            }

            ///object to be compare for equality by IEquatable interface

            Car<int> fisrtObject = new Car<int>("Honda", 2014, "AP90", 200, 4, "1800cc");
            Car<int> secondObject = new Car<int>("Honda", 2014, "AP90", 200, 4, "1800cc");
            
            if (fisrtObject.Equals(secondObject)== true )
           
            {
                Console.WriteLine(PrintEquality);
            }
            Console.ReadLine();

        }
    }
}
