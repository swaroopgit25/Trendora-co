using System;

namespace Trendora.PublicApi.CatalogItemEndpoints;

public class GetByIdCatalogItemResponse : BaseResponse
{
    public GetByIdCatalogItemResponse(Guid correlationId) : base(correlationId)
    {
    }

    public GetByIdCatalogItemResponse()
    {
    }

    public CatalogItemDto CatalogItem { get; set; }
}

