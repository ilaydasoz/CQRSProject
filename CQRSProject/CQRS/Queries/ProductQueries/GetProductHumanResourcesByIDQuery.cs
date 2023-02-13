using System;
namespace CQRSProject.CQRS.Queries.ProductQueries
{
    public class GetProductHumanResourcesByIDQuery
    {
        public GetProductHumanResourcesByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
