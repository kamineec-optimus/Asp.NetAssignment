
namespace FactoryDesignPattern
{
    /// <summary>
    /// Manager class inherites abstract position class
    /// </summary>
    
    class Manager:Position
    {
        private const string manager = "Manager";
        /// <summary>
        /// Overriden property of Position base class to return the title of child class Manager
        /// </summary>
        public override string Title { get { return manager; } }
    }
}
