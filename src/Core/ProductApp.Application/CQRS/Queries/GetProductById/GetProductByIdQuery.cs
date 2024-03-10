using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.CQRS.Queries.GetProductById;

public class GetProductByIdQuery:IRequest<ServiceResponse<ProductDetailDto>>
{
    public Guid Id { get; set; }
    
    
    
    
    public class GetProductByIQueryHandler:IRequestHandler<GetProductByIdQuery,ServiceResponse<ProductDetailDto>>
    {
        
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIQueryHandler(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;

        }
        public async Task<ServiceResponse<ProductDetailDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {

            var product = _productRepository.GetByIdAsync(request.Id);
            var mapped = _mapper.Map<ProductDetailDto>(product);

            return new ServiceResponse<ProductDetailDto>(mapped);

        }
    }
    
    
    
}