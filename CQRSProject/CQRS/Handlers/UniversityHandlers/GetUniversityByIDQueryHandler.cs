using System;
using System.Threading;
using System.Threading.Tasks;
using CQRSProject.CQRS.Queries.UniversityQueries;
using CQRSProject.CQRS.Results.UniversityResults;
using CQRSProject.DAL.Context;
using MediatR;

namespace CQRSProject.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversityByIDQueryHandler : IRequestHandler<GetUniversityByIDQuery, GetUniversityByIDQueryResult>
    {
        private readonly ProductContext _productContext;

        public GetUniversityByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public Task<GetUniversityByIDQueryResult> Handle(GetUniversityByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _productContext.Universities.FindAsync(request.id);
            return new GetUniversityByIDQueryResult
            {
                UniversityID = values.UniversityID,
                City = values.City,
                Name = values.Name,
                Population = values.Population
            };

        }
    }
}
