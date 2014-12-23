
namespace Assignment14
{
    class Bike<T> : MotorVehicle<T>
    {
        /// <summary>
        /// Parameterized costructor 
        /// </summary>
        public Bike(string make, int yearOfManufacture, string model, T speed, string sizeOfEngine)
        {
            Make = make;
            YearOfManufacture = yearOfManufacture;
            Model = model;
            Speed = speed;
            SizeOfEngine = sizeOfEngine;
        }

        /// <summary>
        /// Method to reverse engine manually
        /// </summary>
        public void RevEngine()
        {
            /// code to reverse engine manually
        }

        /// <summary>
        /// Method to ReserveNobe
        /// </summary>
        public void ReserveNobe()
        {
            ///Method to Reserve Nobe
        }
    }
}
