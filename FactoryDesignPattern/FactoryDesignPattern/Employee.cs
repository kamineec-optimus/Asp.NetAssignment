using System;

namespace FactoryDesignPattern
{
    /// <summary>
    /// Main class to handle all the functions
    /// </summary>
    class Employee
    {
        private const string printPositionDetail ="Id ={0} and Position={1}";
        static void Main(string[] args)
        {
            // Print the details of position 
            for (int i = 1; i <=3; i++)
            {
                var position = Factory.GetTitel(i);
                Console.WriteLine(printPositionDetail, i, position.Title);
            }
            Console.ReadLine();
        }
    }
}
