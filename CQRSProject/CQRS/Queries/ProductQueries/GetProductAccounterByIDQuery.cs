using System;
namespace CQRSProject.CQRS.Queries.ProductQueries
{
    public class GetProductAccounterByIDQuery
    {
        public int id { get; set; }

        public GetProductAccounterByIDQuery(int id)
        {
            this.id = id;
        }
    }
}
