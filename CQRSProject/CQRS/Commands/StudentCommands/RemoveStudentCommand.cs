using System;
namespace CQRSProject.CQRS.Commands.StudentCommands
{
    public class RemoveStudentCommand
    {
        public int id { get; set; }

        public RemoveStudentCommand(int id)
        {
            this.id = id;
        }
    }
}
