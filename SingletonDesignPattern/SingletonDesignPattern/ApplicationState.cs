namespace SingletonDesignPattern
{
    /// <summary>
    /// Class to demostrate singleton design pattern
    /// </summary>
    class ApplicationState
    {
        /// <summary>
        /// Instance of ApplicationState class
        /// </summary>
        private static ApplicationState instanceOfApplicationState = null;
        /// <summary>
        /// Properties having State information of object
        /// </summary>
        public int UserId { get; set; }
        public int RoleId { get; set; }

        /// <summary>
        /// Private constructor of ApplicationState class to prevent other classes to initiate other instances of ApplicationState class
        /// </summary>
        private ApplicationState()
        {
        }
        /// <summary>
        /// Return the instance of the ApplicationState class
        /// </summary>
        /// <returns>instance of ApplicationState</returns>
        public static ApplicationState GetState()
        {
            /// Check if the instance is null
            if (ApplicationState.instanceOfApplicationState == null)
            {
                //initialize the intance of ApplicationState
                instanceOfApplicationState = new ApplicationState();
            }
            // Return the instance of ApplicationState
            return instanceOfApplicationState;
        }
       

    }
}
