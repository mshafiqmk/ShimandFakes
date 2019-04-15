namespace ShimandFackes
    {
    public class StockAnalyzer
        {
        private IStockFeed stockFeed;
        public StockAnalyzer (IStockFeed feed)
            {
            stockFeed = feed;
            }
        public int GetContosoPrice ()
            {
            return stockFeed.GetSharePrice ("COOO");
            }
        }
    }
