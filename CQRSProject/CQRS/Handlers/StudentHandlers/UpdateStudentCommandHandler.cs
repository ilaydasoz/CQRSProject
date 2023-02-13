using System;
using CQRSProject.CQRS.Commands.StudentCommands;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRS.Handlers.StudentHandlers
{
    public class UpdateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public UpdateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public void Handle(UpdateStudentCommand command)
        {
            var values = _context.Students.Find(command.StudentID);
            values.City = command.City;
            values.Name = command.Name;
            values.Surname = command.Surname;
            values.Age = command.Age;
            _context.SaveChanges();
        }
    }
}
