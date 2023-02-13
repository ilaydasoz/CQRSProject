using System;
using CQRSProject.CQRS.Commands.StudentCommands;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRS.Handlers.StudentHandlers
{
    public class RemoveStudentCommandHandler
    {
        private readonly ProductContext _context;

        public RemoveStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public void Handle(RemoveStudentCommand command)
        {
            var values = _context.Students.Find(command.id);
            _context.Students.Remove(values);
            _context.SaveChanges();
        }
    }
}
