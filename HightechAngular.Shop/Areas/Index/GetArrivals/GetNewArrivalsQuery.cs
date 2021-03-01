using System.Linq;
using Force.Cqrs;

namespace HightechAngular.Shop.Areas.Index.GetArrivals
{
    public class GetNewArrivalsQuery : FilterQuery<NewArrivalsListItem>
    {
        public override IOrderedQueryable<NewArrivalsListItem> Sort(IQueryable<NewArrivalsListItem> queryable)
        {
            if (Order == "dateCreated")
            {
                return Asc ? queryable.OrderByDescending(x => x.DateCreated) : queryable.OrderBy(x => x.DateCreated);
            }
            return base.Sort(queryable);
        }
    }
}