using System;
using CQRSProject.CQRS.Results.UniversityResults;
using MediatR;

namespace CQRSProject.CQRS.Queries.UniversityQueries
{
    public class GetUniversityByIDQuery : IRequest<GetUniversityByIDQueryResult>
    {
        public int id { get; set; }

        public GetUniversityByIDQuery(int id)
        {
            this.id = id;
        }
    }
}
