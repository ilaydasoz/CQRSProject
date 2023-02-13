using System;
namespace CQRSProject.CQRS.Results.UniversityResults
{
    public class GetAllUniversityQueryResult
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
    }
}
