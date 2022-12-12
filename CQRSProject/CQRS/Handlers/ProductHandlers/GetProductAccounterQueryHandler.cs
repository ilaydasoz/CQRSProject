using System;
using System.Collections.Generic;
using System.Linq;
using CQRSProject.CQRS.Queries.ProductQueries;
using CQRSProject.CQRS.Results.ProductResults;
using CQRSProject.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class GetProductByAccounterQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductByAccounterQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductByAccounterQueryResult> Handle()
        {            
            var values = _productContext.Products.Select(x => new GetProductByAccounterQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Stock = x.Stock,
                Brand = x.Brand,
                SalePrice = x.SalePrice,
                PurchasePrice = x.PurchasePrice

            }).AsNoTracking().ToList(); //AsTracking takip etmeyerek performansi arttirir

            return values;
        }

    }
}
