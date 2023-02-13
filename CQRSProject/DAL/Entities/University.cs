using System;
namespace CQRSProject.DAL.Entities
{
    public class University
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public int FacultyCount { get; set; }
        public int DepartmentCount { get; set; }
        public string Country { get; set; }
    }
}
