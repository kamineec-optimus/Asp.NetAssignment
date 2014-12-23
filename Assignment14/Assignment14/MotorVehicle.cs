
namespace Assignment14
{
    class MotorVehicle<T> : Vehicle<T>
    {
        /// <summary>
        /// Variable of MotorVehicle class
        /// </summary>
        protected string _sizeOfEngine;
       

        /// <summary>
        /// Public Properties
        /// </summary>

       
        /// <summary>
        /// Public Property for size Of Engine
        /// </summary>
        public string SizeOfEngine
        {
            get
            {
                return _sizeOfEngine;
            }
            set
            {
                _sizeOfEngine = value;
            }
        }

        /// <summary>
        /// Methods for MotorVehicle class
        /// </summary>

        ///Method to get size of engine
        public void getSizeOfEngine()
        {
            ///code to get size of engine
        }

        ///Method to get licence plate
        public void getLicencePlate()
        {
            ///code to get licence plate
        }

    }
}
