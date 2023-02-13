using System;
using CQRSProject.CQRS.Queries.ProductQueries;
using CQRSProject.CQRS.Results.ProductResults;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class GetProductAccounterByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccounterByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public GetProductAccounterByIDQueryResult Handle(GetProductAccounterByIDQuery query)
        {
            var values = _productContext.Products.Find(query.id);
            return new GetProductAccounterByIDQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Description = values.Description,
                Name = values.Name,
                PurchasePrice = values.PurchasePrice,
                SalePrice = values.SalePrice,
                Stock = values.Stock,
                Tax = values.Tax
            };
        }
    }
}
