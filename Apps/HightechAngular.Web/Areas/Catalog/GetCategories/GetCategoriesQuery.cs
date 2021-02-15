using System.Collections.Generic;
using Force.Cqrs;

namespace HightechAngular.Areas.Catalog.GetCategories
{
    public class GetCategoriesQuery: IQuery<IEnumerable<CategoryListItem>>
    {
    }
}