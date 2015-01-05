using System.Drawing;

namespace MVPDesignPattern
{
    /// <summary>
    /// Interface provide communication between StockPresenter class and Home UI
    /// </summary>
    public interface IStockView
    {
        /// <summary>
        /// This method set the value of Stock
        /// </summary>
        /// <param name="stockValue">Stock Value</param>
        void SetStockValue(int stockValue);

        /// <summary>
        /// This method will set the color for the textbox according to the stock value 
        /// </summary>
        /// <param name="color">Color to be set according to the stock value</param>
        void SetColor(Color color);
    }
}
