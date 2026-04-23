using AutoMapper;
using Trendora.ApplicationCore.Entities;
using Trendora.PublicApi.CatalogBrandEndpoints;
using Trendora.PublicApi.CatalogItemEndpoints;
using Trendora.PublicApi.CatalogTypeEndpoints;

namespace Trendora.PublicApi;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CatalogItem, CatalogItemDto>()
            .ForMember(dto => dto.Options, options => options.MapFrom(src => src.Options));
        CreateMap<ProductOption, ProductOptionDto>();
        CreateMap<CatalogType, CatalogTypeDto>()
            .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Type));
        CreateMap<CatalogBrand, CatalogBrandDto>()
            .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Brand));
    }
}

