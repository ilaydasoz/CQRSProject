using System;
namespace CQRSProject.CQRS.Results.ProductResults
{
    public class GetProductStoragerQueryResult
    {
        //depocunun gorecegi alanlar tutuluyor
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Storage { get; set; }
    }
}
