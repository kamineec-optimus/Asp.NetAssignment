
namespace MVPDesignPattern
{
    /// <summary>
    /// This is the model class for stock
    /// </summary>
    public class Stock
    {
        public static int stockValue;

        /// <summary>
        /// This method will increment the stock value by 1
        /// </summary>
        public static void IncreaseStock()
        {
            stockValue++;
        }

        /// <summary>
        /// This method will decrement the stock value by 1
        /// </summary>
        public static void DecreaseStock()
        {
            stockValue--;
        }

        /// <summary>
        /// This method get the current status of stock
        /// </summary>
        /// <returns>status of the stock</returns>
        public static int GetStatus()
        {          
            // If less than zero then -1
            // If more than 5 then 1
            // If in between 0
            if (stockValue > 5)
            {
                return 1;
            }
            else if (stockValue < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}