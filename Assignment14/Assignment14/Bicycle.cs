
namespace Assignment14
{
    class Bicycle<T>: Vehicle<T>
    {
         /// <summary>
        /// Parameterized costructor 
        /// </summary>
        public Bicycle(string make, int yearOfManufacture, string model, T speed)
        {
            Make = make;
            YearOfManufacture = yearOfManufacture;
            Model = model;
            Speed = speed;
        }

        /// <summary>
        /// method of Bicycle 
        /// </summary>
        public void ringBell()
        {
            ///code to ring bell
        }
    }
}
