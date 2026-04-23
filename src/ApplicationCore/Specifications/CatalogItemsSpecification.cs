using System.Linq;
using Ardalis.Specification;
using Trendora.ApplicationCore.Entities;

namespace Trendora.ApplicationCore.Specifications;

public class CatalogItemsSpecification : Specification<CatalogItem>
{
    public CatalogItemsSpecification(params int[] ids)
    {
        Query.Where(c => ids.Contains(c.Id));
    }
}

