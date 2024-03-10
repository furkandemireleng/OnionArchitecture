using AutoMapper;

namespace ProductApp.Application.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<Domain.Entities.Product, Dto.ProductViewDto>().ReverseMap();
    }
}