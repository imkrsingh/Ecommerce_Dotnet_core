using AutoMapper;
using EcomProduct.Entities;
using EcomProduct.Models.ResponseModel.Product;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductResponseModel>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.ProductCategory.CategoryName));

    }
}


