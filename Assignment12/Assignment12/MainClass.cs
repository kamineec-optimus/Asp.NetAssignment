using System;
using System.Collections.Generic;


namespace Assignment12
{
    
    class MainClass
    {
        private const string str = "Sorted Object of Vehicle Class with thier Status";
        private const string printObjectEquality = "Objects are same"; 
        private const string printObjectNonEquality = "Objects are different";
        private const string make1 = "Mahindra";
        private const string make2 = "Hero Honda";
        private const string model1 = "ZZQ";
        private const string model2 = "RRY";
        private const string status = "Moving";
        


        static void Main(string[] args)
        {
            ///object of vehicle class
            Vehicle obj = new Vehicle();
            ///list of object
            List<Vehicle> list = obj.GetVehicle();
            /// object of VehicleCollections
            VehicleCollections objvehicle = new VehicleCollections();
            
            ///vehicle.Sort();

            list.Sort();

            Console.WriteLine(str);
            
            ///Print sorted object according to thier Name

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            ///objects of vehicle class to be compared 
            Vehicle objectVehicle1 = new Vehicle(make1, 200, model1, status);
            Vehicle objectVehicle2 = new Vehicle(make1, 200, model1, status);
            Vehicle objectVehicle3 = new Vehicle(make2, 300, model2, status);
            ///call equal methos of vehicle call to compare these equal object object           
            if (objectVehicle1.Equals(objectVehicle2) == true)
            {
                Console.WriteLine(printObjectEquality); 
            }
            else
            {
                Console.WriteLine(printObjectNonEquality);
            }

            ///call equal methos of vehicle call to compare these equal object object           
            if (objectVehicle1.Equals(objectVehicle3) == true)
            {
                Console.WriteLine(printObjectEquality);
            }
            else
            {
                Console.WriteLine(printObjectNonEquality);
            }

            Console.ReadLine();


        }
    }
}
