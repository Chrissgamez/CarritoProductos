using Microsoft.AspNetCore.Mvc;
using ProductsService.Services;

namespace ProductsService.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly ProductService _service;

    public ProductsController(ProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _service.GetAllAsync();
        return Ok(products);
    }
}