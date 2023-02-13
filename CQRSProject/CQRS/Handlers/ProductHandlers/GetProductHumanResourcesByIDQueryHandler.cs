using System;
using CQRSProject.CQRS.Queries.ProductQueries;
using CQRSProject.CQRS.Results.ProductResults;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class GetProductHumanResourcesByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductHumanResourcesByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public GetProductHumanResourcesByIDQueryResult Handle(GetProductHumanResourcesByIDQuery query)
        {
            var values = _productContext.Products.Find(query.id);
            return new GetProductHumanResourcesByIDQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Name = values.Name,
                SalePrice = values.SalePrice
            };
        }
    }
}
