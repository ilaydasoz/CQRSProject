using System;
namespace CQRSProject.CQRS.Commands.StudentCommands
{
    public class UpdateStudentCommand
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

    }
}
