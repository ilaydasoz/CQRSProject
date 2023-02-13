using System;
namespace CQRSProject.CQRS.Queries.StudentQueries
{
    public class GetStudentByIDQuery
    {
        public int id { get; set; }

        public GetStudentByIDQuery(int id)
        {
            this.id = id;
        }

    }
}
