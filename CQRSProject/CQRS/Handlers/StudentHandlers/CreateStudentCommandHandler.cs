using System;
using CQRSProject.CQRS.Commands.StudentCommands;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public CreateStudentCommandHandler(ProductContext productContext)
        {
            _context = productContext;
        }

        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student
            {
                Name = command.Name,
                Surname = command.Surname,
                Age = command.Age,
                City = command.City,
                Status = false
            });

            _context.SaveChanges();

        }
    }
}
