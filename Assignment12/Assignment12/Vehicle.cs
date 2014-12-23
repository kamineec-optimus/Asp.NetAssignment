using System;
using System.Collections.Generic;


namespace Assignment12
{
    class Vehicle : IComparable<Vehicle>
    {
        /// <summary>
        /// Public Propertise of vehicle class 
        /// </summary>
        public string Make { get; set; } 
        public int Speed { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Vehicle()
        {

        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        public Vehicle(string make, int speed, string model, string status)
        {
            Make = make;
            Speed = speed;
            Model = model;
            Status = status;
        }
         
        /// <summary>
        /// Method to sort Vehicle object according to thier Name
        /// </summary>
        /// <param name="other">Second Object of Vehicle class</param>
        /// <returns>Returns sorted arraylist</returns>
        
        public int CompareTo(Vehicle otherVehicle)
        {
            return this.Make.CompareTo(otherVehicle.Make);
	
         }

        public override string ToString()
        {
            // String representation.
            return this.Make.ToString() + "," + this.Status;
        }

        /// <summary>
        /// method to maintain a list of vehicles
        /// </summary>
        /// <returns>list of vehicles</returns>
        public List<Vehicle> GetVehicle()
        {
            List<Vehicle> list = new List<Vehicle>();
            list.Add(new Vehicle() { Make = "HeroHonda", Speed = 200, Model = "AAA", Status = "Moving" });
            list.Add(new Vehicle() { Make = "Hundai", Speed = 100, Model = "BBB", Status = "Moving" });
            list.Add(new Vehicle() { Make = "Mahindra", Speed = 200, Model = "CCC", Status = "Stoped" });
            list.Add(new Vehicle() { Make = "Mahindra", Speed = 400, Model = "YYY", Status = "Moving" });
            return list;
        }
        public bool Equals(Vehicle objectVehicle)
        {
            // If parameter is null return false:
            if (objectVehicle == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (Make == objectVehicle.Make) && (Speed == objectVehicle.Speed) && (Model == objectVehicle.Model) && (Status == objectVehicle.Status);
        }        

    }
}
