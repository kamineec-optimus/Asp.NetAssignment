
namespace Assignment14
{
    class Car<T> : MotorVehicle<T>
    {
        /// <summary>
        /// Parameterized costructor 
        /// </summary>
        public Car(string make, int yearOfManufacture, string model, T speed, int noOfDoors, string sizeOfEngine)
        {
            Make = make;
            YearOfManufacture = yearOfManufacture;
            Model = model;
            Speed = speed;
            NoOfDoors = noOfDoors;
            SizeOfEngine = sizeOfEngine;
        }
        /// <summary>
        /// int of Car class
        /// </summary>
        private int _noOfDoors;

        /// <summary>
        /// property for no of Doors
        /// </summary>
        public int NoOfDoors { get
        { 
            return  _noOfDoors;
        } 
            set {_noOfDoors = value; }}

        /// <summary>
        /// Method to switch on air conditioner of Car
        /// </summary>
        public void SwitchOnAirCon()
        {
            /// code to switch on air conditioner 
        }

        /// <summary>
        /// Method to get no of doors of Car
        /// </summary>
        public void GetNoOfDoors()
        {
            /// code to get No of doors;
        }

    }
}
