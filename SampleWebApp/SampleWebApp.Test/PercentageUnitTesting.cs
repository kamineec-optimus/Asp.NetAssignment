using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleWebApp.Test
{
    /// <summary>
    /// Test class which have test cases for Marks class
    /// </summary>
    [TestClass]
    public class PercentageUnitTesting
    {      
        #region Positive Conditional Testing      

        /// <summary>
        /// TestCase to test calulated marks calculation with valid value
        /// </summary>
        [TestMethod]        
        public void PositiveConditionalTestingCalculatedMarks()
        {
            var percentage = new Marks();
            double marks = percentage.CalculateMarks(60);
            // Check if expacted marks and actual marks are same           
            Assert.AreEqual(300, marks);
        }

        /// <summary>
        /// TestCase to test boundry values of the valid marks provided by User
        /// </summary>
        [TestMethod]
        public void PositiveConditionalTestingBoundryValue()
        {
            try
            {
                var percentage = new Marks();
               // It will not throw exception because percentage value is within boundry values
                double marks = percentage.CalculateMarks(75);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
                       
        }
        
        /// <summary>
        /// TestCase to test positive values of the marks provided by User
        /// </summary>
        [TestMethod]
        public void PositiveConditionalTestingPositiveValue()
        {
            try
            {
                var percentage = new Marks();
               // it will not throw exception as marks value is posivtive and within boundry value
                double marks = percentage.CalculateMarks(5);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        #endregion

        #region Negative Conditional Testing
        /// <summary>
        /// TestCase to test calulated marks calculation with invalid value
        /// </summary>
        [TestMethod]
        public void NegativeConditionalTestingCalculatedMarks()
        {
            var percentage = new Marks();
            double marks = percentage.CalculateMarks(60);
            // Check if expacted marks and actual marks are same           
            Assert.AreEqual(200, marks);
        }

        /// <summary>
        /// TestCase to test boundry values of the invalid marks provided by User
        /// </summary>
        [TestMethod]
        public void NegativeConditionalTestingBoundryValue()
        {
            try
            {
                var percentage = new Marks();
                // It must throw exception because percentage value is out of boundry value
                double marks = percentage.CalculateMarks(145);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        /// <summary>
        /// TestCase to test negative values of the marks provided by User
        /// </summary>
        [TestMethod]
        public void NegativeConditionalTestingNegativeValue()
        {
            try
            {
                var percentage = new Marks();
                // It will throw exception as marks value is negative
                double marks = percentage.CalculateMarks(-50);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        #endregion
    }
}
