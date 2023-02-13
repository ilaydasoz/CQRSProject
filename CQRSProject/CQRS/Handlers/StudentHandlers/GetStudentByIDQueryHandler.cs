using System;
using CQRSProject.CQRS.Results.StudentResults;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler
    {
        private readonly ProductContext _context;

        public GetStudentByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public GetStudentByIDQueryResult Handle(GetStudentByIDQuery query)
        {
            var values = _context.Students.Find(query.id);
            return new GetStudentByIDQueryResult
            {
                Age = values.Age,
                City = values.City,
                Name = values.Name,
                Surname = values.Surname,
                StudentID = values.StudentID
            };
        }
    }
}
