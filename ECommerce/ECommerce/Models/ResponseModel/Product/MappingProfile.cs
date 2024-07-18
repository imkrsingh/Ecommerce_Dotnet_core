using AutoMapper;
using ECommerce.Entities;
using ECommerce.Models.ResponseModel.Product;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductResponseModel>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.ProductCategory.CategoryName));
    }
}
