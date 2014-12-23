
namespace Assignment14
{
    class Truck<T> : MotorVehicle<T>
    {
        /// <summary>
        /// Parameterized costructor 
        /// </summary>
         public Truck(string make, int yearOfManufacture, string model, T speed, int noOfDoors)
        {
            Make = make;
            YearOfManufacture = yearOfManufacture;
            Model = model;
            Speed = speed;
            NoOfDoors = noOfDoors;
        }


        /// <summary>
        /// int of Truck class
        /// </summary>
        private int _noOfDoors;

        /// <summary>
        /// property for no of Doors
        /// </summary>
        public int NoOfDoors
        {
            get
            {
                return _noOfDoors;
            }
            set { _noOfDoors = value; }
        }

        /// <summary>
        /// Method to get no of doors of Truck
        /// </summary>
        public void GetNoOfDoors()
        {
            /// code to get No of doors;
        }

    }
}
