using System;

namespace SampleWebApp
{
    /// <summary>
    /// Marks class 
    /// </summary>
    public class Marks
    {
        private const string boundryValueException = "Boundry value exception";
        private const string negativeException = "Negative value exception";
        /// <summary>
        /// Method to calculate marks based on the percentage provided by user
        /// </summary>
        /// <param name="percentage">Percentage of the User</param>
        /// <returns>Marks based on the percentage</returns>
        public double CalculateMarks(double percentage)
        {
            if (percentage < 0)
            {
                throw new ArgumentException(negativeException);
            }   
            if (percentage > 100)
            {
                throw new ArgumentOutOfRangeException(boundryValueException);
            }                     

            // Calculate Marks based on percentage provided by user
           double _marks = (percentage * 500) / 100;
           return _marks;         
               
        }
    }
}