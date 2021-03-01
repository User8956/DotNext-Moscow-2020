using System.Linq;
using Force.Cqrs;

namespace HightechAngular.Shop.Areas.Index.GetSales
{
    public class GetSalesQuery : FilterQuery<SaleListItem>
    {
        public override IOrderedQueryable<SaleListItem> Sort(IQueryable<SaleListItem> queryable)
        {
            if (Order == "dateCreated")
            {
                return Asc ? queryable.OrderByDescending(x => x.DateCreated) : queryable.OrderBy(x => x.DateCreated);
            }
            return base.Sort(queryable);
        }
    }
}