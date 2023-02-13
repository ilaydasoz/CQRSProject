using System;
using System.Collections.Generic;
using System.Linq;
using CQRSProject.CQRS.Results.ProductResults;
using CQRSProject.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class GetProductAccounterQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccounterQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductAccounterQueryResult> Handle()
        {            
            var values = _productContext.Products.Select(x => new GetProductAccounterQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Stock = x.Stock,
                Brand = x.Brand,
                SalePrice = x.SalePrice,
                PurchasePrice = x.PurchasePrice

            }).AsNoTracking().ToList(); //AsTracking takip etmeyerek performansi arttirir. SaveChanges()'in bulundugu islemlerde takip edilir.

            return values;
        }

    }
}
