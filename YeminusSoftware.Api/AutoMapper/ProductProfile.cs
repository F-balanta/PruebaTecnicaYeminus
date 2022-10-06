using AutoMapper;
using YeminusSoftware.Application.DataObjectModel;
using YeminusSoftware.Domain;

namespace YeminusSoftware.Api.AutoMapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
            .ForMember(x => x.PriceList, y => y.MapFrom(z => z.PriceList))
            .ReverseMap();
            CreateMap<Product, ProductForCreateDto>().ReverseMap();
            CreateMap<Product, ProductForUpdateDto>().ReverseMap();
        }
    }
}
