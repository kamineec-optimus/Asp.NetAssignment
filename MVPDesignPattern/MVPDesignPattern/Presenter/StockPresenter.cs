
using System.Drawing;
namespace MVPDesignPattern
{
    /// <summary>
    /// This is presenter class for Home UI 
    /// </summary>
    public class StockPresenter
    {
        /// <summary>
        /// Object of IStockView Interface
        /// </summary>
        IStockView iStockView;

        /// <summary>
        /// This method will set the view object
        /// </summary>
        /// <param name="iStockView">view object</param>
        public void Add(IStockView iStockView)
        {
            this.iStockView = iStockView;
        }

        /// <summary>
        /// This method will call the model class Stock's method to increase the stock and then get the updated stock value and set the color accordingly
        /// </summary>
        public void IncreaseStock()
        {
            Stock.IncreaseStock();
            iStockView.SetStockValue(Stock.stockValue);
            ChangeColor();
        }

        /// <summary>
        /// This method will call the model class Stock's method to decrease the stock value and set the updated stock value and color as well
        /// </summary>
        public void DecreaseStock()
        {
            Stock.DecreaseStock();
            iStockView.SetStockValue(Stock.stockValue);
            ChangeColor();
        }

        /// <summary>
        /// This method will set the color depending upon the status coming from Stock class
        /// </summary>
        public void ChangeColor()
        {
            switch(Stock.GetStatus())
            {
                case -1:
                        iStockView.SetColor(Color.Red);
                        break;
                case 1:
                        iStockView.SetColor(Color.Blue);
                        break;
                default:
                        iStockView.SetColor(Color.Green);
                        break;
            }

            
        }



    }
}