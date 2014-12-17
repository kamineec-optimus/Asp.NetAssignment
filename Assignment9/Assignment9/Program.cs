using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Program
    {
        private const string EnterMake = "Enter manufacturer company name";
        private const string EnterYear = "Enter year of manufacture of vehicle";
        private const string EnterModel = "Enter model of the vehicle";
        private const string EnterSpeed = "Enter Speed of the vehicle";
        private const string EnterChoice = "\nEnter your Choice to perform\nEnter 1 to accelerate the Vahicle\nEnter 2 to deaccelarate the Vahicle\nEnter 3 to stop the Vahicle\nEnter 4 to Know whether vehicle moving or not";

        static void Main(string[] args)
        {         

            /// <summary>
            ///  Variables to save user input
            /// </summary>   

            ///variable to save user input for manufacturer company name

             string make;

            ///variable to save user input for year of manufacture of vehicle
             int yearOfManufacture;
    
             ///variable to save user input for vehicle model
            string model;

            ///variable to save user input for vehicle speed
            float speed;
            
            /// <summary>
            ///  Take input from user
            /// </summary>

            ///Enter manufacturer company name

            Console.WriteLine(EnterMake);
            make = Console.ReadLine();

            ///Enter year of manufacture of vehicle

            Console.WriteLine(EnterYear);
            yearOfManufacture = int.Parse(Console.ReadLine());

            ///Enter model of the vehicle

            Console.WriteLine(EnterModel);
            model = Console.ReadLine();

            ///Enter speed of the vehicle

            Console.WriteLine(EnterSpeed);
            speed = float.Parse(Console.ReadLine());

            /// <summary>
            /// Object of Vehicle Class to call Parameterized costructor 
            /// </summary>
            /// 
            Vehicle objVehicle = new Vehicle(make, yearOfManufacture, model, speed);

            /// <summary>
            /// Print detail of Vehicle
            /// </summary
            
            objVehicle.PrintDetetailOfVehicle();

            /// User Enter his/her Choice for further operations 
            /// 
            Console.WriteLine(EnterChoice);

            ///User Input his/her choice
            
            int Choice = int.Parse(Console.ReadLine());

            ///Call Method of vehicle class

            objVehicle.PerformTask(Choice);

            Console.Read();

            
            
        }
    }
}
