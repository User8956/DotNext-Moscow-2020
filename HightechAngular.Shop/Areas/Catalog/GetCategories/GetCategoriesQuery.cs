using System.Collections.Generic;
using Force.Cqrs;

namespace HightechAngular.Shop.Areas.Catalog.GetCategories
{
    public class GetCategoriesQuery : IQuery<IEnumerable<CategoryListItem>>
    {
    }
}