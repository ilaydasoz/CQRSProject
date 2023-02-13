using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRSProject.CQRS.Queries.UniversityQueries;
using CQRSProject.CQRS.Results.UniversityResults;
using CQRSProject.DAL.Context;
using MediatR;

namespace CQRSProject.CQRS.Handlers.UniversityHandlers
{
    public class GetAllUniversityQueryHandler : IRequestHandler<GetAllUniversityQuery, List<GetAllUniversityQueryResult>>
    {
        private readonly ProductContext _productContext;

        public GetAllUniversityQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public async Task<List<GetAllUniversityQueryResult>> Handle(GetAllUniversityQuery request, CancellationToken cancellationToken)
        {
            return await _productContext.Universities.Select(x =>
            new GetAllUniversityQueryResult
            {
                UniversityID = x.UniversityID,
                Town = x.City,
                Name = x.Name

            }).AsNoTracking().ToListAsync();
        }
    }
}
