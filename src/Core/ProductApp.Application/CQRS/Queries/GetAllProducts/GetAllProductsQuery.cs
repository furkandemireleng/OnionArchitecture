using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.CQRS.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
{
    public class
        GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request,
            CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();

            var viewMapping = _mapper.Map<List<ProductViewDto>>(products);
            
            // var dto = products.Select(i => new ProductViewDto()
            // {
            //     Id = i.Id,
            //     Name = i.Name
            // }).ToList();

            return new ServiceResponse<List<ProductViewDto>>(viewMapping);
        }
    }
}