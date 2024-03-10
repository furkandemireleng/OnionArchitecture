using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController:ControllerBase
{
    private readonly IProductRepository _productRepository; 

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;

    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var products  = await _productRepository.GetAllAsync();
        var result = products.Select(i => new ProductViewDto()
        {
            Id = i.Id,
            Name = i.Name
        }).ToList();
        
        return Ok(result);
    }
    
}