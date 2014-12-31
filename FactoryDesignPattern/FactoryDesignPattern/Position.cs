
namespace FactoryDesignPattern
{
    /// <summary>
    /// Abstract class which will have the abstract menthods/properties to be overridden in child classes
    /// </summary>
    abstract class Position
    {
        /// <summary>
        /// Abstract property to be overriden in child classes
        /// </summary>
        public abstract string Title { get; }
    }
}
