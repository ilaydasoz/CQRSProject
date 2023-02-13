using System;
using System.Collections.Generic;
using System.Linq;
using CQRSProject.CQRS.Results.StudentResults;
using CQRSProject.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.CQRS.Handlers.StudentHandlers
{
    public class GetAllStudentQueryHandler
    {
        private readonly ProductContext _context;

        public GetAllStudentQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public List<GetAllStudentQueryResult> Handle()
        {
            var values = _context.Students.Select(x =>
            new GetAllStudentQueryResult
            {
                City = x.City,
                Department = x.Department,
                Name = x.Name,
                StudentID = x.StudentID,
                Surname = x.Surname
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
