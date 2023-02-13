using System;
namespace CQRSProject.CQRS.Results.ProductResults
{
    public class GetProductHumanResourcesByIDQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal SalePrice { get; set; }
    }
}
