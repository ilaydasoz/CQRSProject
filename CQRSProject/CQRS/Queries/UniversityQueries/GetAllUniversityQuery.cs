using System;
using System.Collections.Generic;
using CQRSProject.CQRS.Results.UniversityResults;
using MediatR;

namespace CQRSProject.CQRS.Queries.UniversityQueries
{
    public class GetAllUniversityQuery : IRequest<List<GetAllUniversityQueryResult>>
    {
        
    }
}
