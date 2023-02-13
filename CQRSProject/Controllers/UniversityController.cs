using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSProject.CQRS.Queries.UniversityQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IMediator _mediator;

        public UniversityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> GetAllUniversities()
        {
            var values = await _mediator.Send(new GetAllUniversityQuery());
            return View(values);
        }
    }
}
