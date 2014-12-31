
namespace FactoryDesignPattern
{
    /// <summary>
    /// Static Factory class which will decide which class should be instantiate
    /// </summary>
    static class Factory
    {
        /// <summary>
        /// Method to create objects based on user's choice
        /// </summary>
        /// <param name="userChoice">choice of the user</param>
        /// <returns>object of corresponding class</returns>
        public static Position GetTitel(int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    return new Manager();
                    break;
                case 2:
                    return new Clerk();
                    break;
                default:
                    return new Programmer();                              
            }

        }
    }
}
