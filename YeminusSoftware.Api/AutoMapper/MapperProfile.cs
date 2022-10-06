using AutoMapper;
using YeminusSoftware.Application.DataObjectModel;
using YeminusSoftware.Application.DataObjectModel.Base;
using YeminusSoftware.Domain;

namespace YeminusSoftware.Api.AutoMapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductForCreateDto>().ReverseMap();
            CreateMap<Product, ProductForUpdateDto>().ReverseMap();
            
            CreateMap<Encrypt, EncryptDto>().ReverseMap();
            CreateMap<Encrypt, EncryptForUpdateDto>().ReverseMap();
            CreateMap<Encrypt, EncryptForCreateDto>().ReverseMap();
        }
    }
}
