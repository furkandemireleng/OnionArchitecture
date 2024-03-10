using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.CQRS.Queries.GetAllProducts;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController:ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;

    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var query = new GetAllProductsQuery();
        return Ok(await _mediator.Send(query));
        
    }
    
}