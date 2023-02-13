using System;
using CQRSProject.CQRS.Commands.ProductCommands;
using CQRSProject.DAL.Context;
using CQRSProject.DAL.Entities;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public void Handle(CreateProductCommand command)
        {
            _productContext.Products.Add(new Product
            {
                Brand = command.Brand,
                Cost = command.Cost,
                Stock = command.Stock,
                Tax = command.Tax,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                Name = command.Name,
                Size = command.Size,
                ProduceOfDate = command.ProduceOfDate,
                EndOfDate = command.EndOfDate,
                Status = true
            });

            _productContext.SaveChanges();

        }
    }
}
