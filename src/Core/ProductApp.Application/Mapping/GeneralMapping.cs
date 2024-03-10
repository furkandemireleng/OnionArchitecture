using AutoMapper;
using ProductApp.Application.CQRS.Commands.CreateProductCommand;

namespace ProductApp.Application.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<Domain.Entities.Product, Dto.ProductViewDto>().ReverseMap();

        CreateMap<Domain.Entities.Product, CreateProductCommand>().ReverseMap();
    }
}