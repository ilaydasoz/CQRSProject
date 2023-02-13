using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSProject.CQRS.Commands.ProductCommands;
using CQRSProject.CQRS.Handlers.ProductHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductAccounterQueryHandler _getProductAccounterQueryHandler;
        private readonly GetProductStoragerQueryHandler _getProductStoragerQueryHandler;
        private readonly GetProductHumanResourcesByIDQueryHandler _getHumanResourcesByIDQueryHandler;
        private readonly GetProductAccounterByIDQueryHandler _getProductAccounterByIDQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;

        public ProductController(GetProductAccounterQueryHandler getProductAccounterQueryHandler, GetProductStoragerQueryHandler getProductStoragerQueryHandler, GetProductHumanResourcesByIDQueryHandler getHumanResourcesByIDQueryHandler, GetProductAccounterByIDQueryHandler getProductAccounterByIDQueryHandler)
        {
            _getProductAccounterQueryHandler = getProductAccounterQueryHandler;
            _getProductStoragerQueryHandler = getProductStoragerQueryHandler;
            _getHumanResourcesByIDQueryHandler = getHumanResourcesByIDQueryHandler;
            _getProductAccounterByIDQueryHandler = getProductAccounterByIDQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductAccounterQueryHandler.Handle();
            return View(values);
        }
        public IActionResult StoragerIndex()
        {
            var values = _getProductStoragerQueryHandler.Handle();
            return View(values);
        }

        //id'ye gore HRin verileri getirilsin
        public IActionResult GetHumanResourcesIndex(int id)
        {
            var values = _getHumanResourcesByIDQueryHandler.Handle(new CQRS.Queries.ProductQueries.GetProductHumanResourcesByIDQuery(id));//id'yi burada kullanabilmek için constructor icine yazdik
            return View(values);
        }

        //id'ye gore muhasebecinin verileri getirilsin
        public IActionResult GetAccounterIndexByID(int id)
        {
            var values = _getProductAccounterByIDQueryHandler.Handle(new CQRS.Queries.ProductQueries.GetProductAccounterByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}

