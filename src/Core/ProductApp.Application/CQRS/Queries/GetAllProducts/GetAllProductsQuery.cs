using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.Application.CQRS.Queries.GetAllProducts;

public class GetAllProductsQuery:IRequest<List<ProductViewDto>>
{
    
    public class GetAllProductsQueryHandler: IRequestHandler<GetAllProductsQuery,List<ProductViewDto>>
    {

        private readonly IProductRepository _productRepository;
        
        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }
        public Task<List<ProductViewDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();
        }
    }
}