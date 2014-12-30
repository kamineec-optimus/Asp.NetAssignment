
namespace SingletonDesignPattern
{
    /// <summary>
    /// Class to demostrate singleton design pattern
    /// </summary>
    class ApplicationState
    {
        /// <summary>
        /// instance of ApplicationState class
        /// </summary>
        private static ApplicationState instanceOfApplicationState = null;
        /// <summary>
        /// Properties having State information of object
        /// </summary>
        public int UserId { get; set; }
        public int RoleId { get; set; }

        /// <summary>
        /// private constructor of ApplicationState class to prevent other classes to initiate other instances of this class
        /// </summary>
        private ApplicationState()
        {
        }
        /// <summary>
        /// return the instance of the ApplicationState class
        /// </summary>
        /// <returns>instance of ApplicationState</returns>
        public static ApplicationState GetState()
        {
            /// check if the instance is null
            if (ApplicationState.instanceOfApplicationState == null)
            {
                //initialize the intance of ApplicationState
                instanceOfApplicationState = new ApplicationState();
            }
            //return the instance of ApplicationState
            return instanceOfApplicationState;
        }
       

    }
}
