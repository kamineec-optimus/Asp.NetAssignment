using System;
using System.Drawing;

namespace MVPDesignPattern
{
    /// <summary>
    /// UI view for the home page
    /// </summary>
    public partial class Home : System.Web.UI.Page,IStockView
    {
        /// <summary>
        /// Object of StockPresenter class
        /// </summary>
        private StockPresenter stockPresenter = new StockPresenter();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Add this View Object to the presenter (StockPresenter) class
            stockPresenter.Add(this);
        }

        public void SetStockValue(int stockValue)
        {
            txtStockValue.Text = stockValue.ToString();
        }

        public void SetColor(Color color)
        {
            txtStockValue.BackColor = color;
        }

        protected void btnIncreaseStock_Click(object sender, EventArgs e)
        {
            stockPresenter.IncreaseStock();
        }

        protected void btnDecreaseStock_Click(object sender, EventArgs e)
        {
            stockPresenter.DecreaseStock();
        }
    }
}