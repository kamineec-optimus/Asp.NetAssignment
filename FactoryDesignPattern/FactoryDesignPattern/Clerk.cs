
namespace FactoryDesignPattern
{
    /// <summary>
    /// Clerk class inherites abstract position class
    /// </summary>
    class Clerk:Position
    {
        private const string clerk = "Clerk";
        /// <summary>
        /// Overriden property of Position base class to return the title of child class Clerk
        /// </summary>
        public override string Title { get { return clerk; } }
    }
}
