
using System;
namespace SingletonDesignPattern
{
    /// <summary>
    /// user class to create instance of ApplicationState class
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// private strings used to print state of singleton object
        /// </summary>
        private const string userID = "UserId: {0}";
        private const string roleID = "RoleId: {0}";

        static void Main(string[] args)
        {
            //object to call GetInstancesState method
            MainClass user = new MainClass();
            //print state of second instance
            user.GetInstancesState();
        }

        /// <summary>
        /// Method to get state of two instances of ApplicationState class
        /// </summary>
        public void GetInstancesState()
        {
            //first instance
            ApplicationState objApplicationState1 = ApplicationState.GetState();            
            objApplicationState1.UserId = 1;
            objApplicationState1.RoleId = 2;
            
            //Second instance
            ApplicationState objApplicationState2 = ApplicationState.GetState();
            Console.WriteLine(userID, objApplicationState2.UserId);
            Console.WriteLine(roleID, objApplicationState2.RoleId);
            Console.ReadLine();
        }
    }
}
