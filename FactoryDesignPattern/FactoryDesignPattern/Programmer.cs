
namespace FactoryDesignPattern
{
    /// <summary>
    /// Programmer class inherites abstract position class
    /// </summary>
    class Programmer:Position
    {
        private const string programmer = "Programmer";
        /// <summary>
        /// Overriden property of Position base class to return the title of child class Programmer
        /// </summary>
        public override string Title { get { return programmer; } }
    }
}
