using System;
using System.Collections.Generic;
using System.Linq;
using CQRSProject.CQRS.Results.ProductResults;
using CQRSProject.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class GetProductStoragerQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductStoragerQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public List<GetProductStoragerQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new
            GetProductStoragerQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Storage = x.Storage

            }).AsNoTracking().ToList();

            return values;
        }
    }
}
