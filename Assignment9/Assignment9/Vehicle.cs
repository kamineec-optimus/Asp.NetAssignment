using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{      
    class Vehicle
    {
        /// <summary>
        /// String used in program
        /// </summary>
        private const string ShowDetailOfVehicle = "Vehicle Manufacturer Company Name: {0} \nVehicle Year Of Manufacture: {1} \nVehicle Model: {2} \nVehicle Speed: {3}";
        private const string EnterSpeedToIncrese = "Please Enter Speed to increse";
        private const string IncresedSpeed = "Incresed Speed is: {0}";
        private const string EnterSpeedToDecrese = "Please Enter Speed to decrease";
        private const string DecresedSpeed = "decrease Speed is: {0}";
        private const string CurrentSpeed = "Speed is: {0}";
        private const string VehicleMoving = "Yes";
        private const string VehiclNotMoving = "No";
        /// <summary>
        /// Default costructor 
        /// </summary>

        public Vehicle() { }

        /// <summary>
        /// Parameterized costructor 
        /// </summary>
        public Vehicle(string make, int yearOfManufacture, string model, float speed)
        {
            Make = make;
            YearOfManufacture = yearOfManufacture;
            Model = model;
            Speed = speed;
        }

        /// <summary>
        /// Private Variables
        /// </summary>   

        ///manufacturer company Name
        private string _make;

        ///Year of Manufacture of the vehicle
        private int _yearOfManufacture;

        ///Model of the Vehicle
        private string _model;

        ///Speed of the Vehicle
        private float _speed;

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
       
        public float Speed
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
       /// Method to increase speed of the vehicle
       /// </summary>
       
        public void Accelerate(float speed)
        {
            Speed = Speed + speed;
        }

        /// <summary>
        /// Method to decrease speed of the vehicle
        /// </summary>
       
        public void Deaccelarate(float speed)
        {
            Speed = Speed - speed;
        }

        /// <summary>
        /// Method to stop the vehicle
        /// </summary>
        
        public void Stop()
        {
            Speed = 0;
        }

        /// <summary>
        /// Method to find out the state of vehicle 
        /// </summary>
        /// <returns>Returns true if vehicle is moving else return false</returns>
        public Boolean isMoving()
        {
            if (Speed > 0)
                return true;
            else
                return false;
        }

        public void PrintDetetailOfVehicle()
        {
            Console.WriteLine(ShowDetailOfVehicle, Make, YearOfManufacture, Model, Speed);
        }

        /// <summary>
        /// Method to perform tasks
        /// </summary>
        /// <param name="choice">User's choice</param>
        public void PerformTask(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine(EnterSpeedToIncrese);
                    int incresedSpeed = int.Parse(Console.ReadLine());
                    Accelerate(incresedSpeed);
                    Console.WriteLine(IncresedSpeed,Speed);
                    break;
                case 2:
                    Console.WriteLine(EnterSpeedToDecrese);
                    int decresedSpeed = int.Parse(Console.ReadLine());
                    Deaccelarate(decresedSpeed);
                    Console.WriteLine(DecresedSpeed,Speed);
                    break;
                case 3:
                    Stop();
                    Console.WriteLine(CurrentSpeed, Speed);
                    break;
                case 4:
                    if (isMoving() == true)
                        Console.WriteLine(VehicleMoving);
                    else
                        Console.WriteLine(VehiclNotMoving);
                    break;

            }
        }
    }
}
