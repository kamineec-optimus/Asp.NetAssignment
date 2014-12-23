using System;
using System.Collections.Generic;

namespace Assignment14
{      
    class Vehicle<T>:IComparable<Vehicle<T>>, IEquatable<Vehicle<T>>
    {
        /// <summary>
        /// Private Variables
        /// </summary>   

        ///manufacturer company Name
        protected string _make;

        ///Year of Manufacture of the vehicle
        protected int _yearOfManufacture;

        ///Model of the Vehicle
        protected string _model;

        ///Speed of the Vehicle
        protected T _speed;

        /// <summary>
        /// Public Properties
        /// </summary>

        /// <summary>
        /// Public Property for Make (manufacturer company Name)
        /// </summary>
        
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        /// <summary>
        /// Public Property for Year Of Manufacture of the Vehicle
        /// </summary>
        public int YearOfManufacture
        {
            get
            {
                return _yearOfManufacture;
            }
            set
            {
                _yearOfManufacture = value;
            }
        }

        /// <summary>
        /// Public Property for save Model of the Vehicle
        /// </summary>
      
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        /// <summary>
        /// Public Property for Speed of the Vehicle
        /// </summary>
       
        public T Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }


        /// <summary>
        /// Method to return a list of all vehicles
        /// </summary>
        /// <returns>list of vehicles</returns>

        public List<Vehicle<int>> GetVehicle()
        {

            Car<int> objCar = new Car<int>("Honda", 2014, "AP90", 200, 4, "1800cc");
            Bike<int> objBike = new Bike<int>("Apache", 2002, "SS40", 100, "1100cc");
            Bicycle<int> objBicycle = new Bicycle<int>("Miss India", 1998, "OOW", 10);

            List<Vehicle<int>> list = new List<Vehicle<int>>();
            list.Add(objCar);
            list.Add(objBike);
            list.Add(objBicycle);

            return list;
        }

       /// <summary>
       /// compare to method sort list by speed des
       /// </summary>
       /// <param name="otherVehicle"> object of vehicle to be compared</param>
       /// <returns>result of sort</returns>       

        public int CompareTo(Vehicle<T> otherVehicle)
        {
            if (this.Speed.Equals(otherVehicle.Speed))
            {
                return 0;
            }

            else
            {
                return 1;
            }
         }


        /// <summary>
        /// check equality of two object
        /// </summary>
        /// <param name="otherVehicle">second object</param>
        /// <returns>returns true if objects are same else returns false</returns>
        public bool Equals(Vehicle<T> otherVehicle)
        {
            if (this.Model == otherVehicle.Model && this.Speed.Equals(otherVehicle.Speed) && this.Make == otherVehicle.Make && this.YearOfManufacture == otherVehicle.YearOfManufacture)
            {
                return true;
            }
            else
            {
                return false;
            }
        }       

        }
}
