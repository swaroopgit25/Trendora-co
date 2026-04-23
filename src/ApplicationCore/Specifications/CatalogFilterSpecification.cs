using Ardalis.Specification;
using Trendora.ApplicationCore.Entities;

namespace Trendora.ApplicationCore.Specifications;

public class CatalogFilterSpecification : Specification<CatalogItem>
{
    public CatalogFilterSpecification(int? brandId, int? typeId, string? searchTerm = null)
    {
        var normalizedSearch = searchTerm?.Trim().ToLowerInvariant();

        Query.Where(i => (!brandId.HasValue || i.CatalogBrandId == brandId) &&
            (!typeId.HasValue || i.CatalogTypeId == typeId) &&
            (string.IsNullOrEmpty(normalizedSearch) ||
             i.Name.ToLower().Contains(normalizedSearch) ||
             i.Description.ToLower().Contains(normalizedSearch)));
    }
}

