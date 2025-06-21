using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace ProductsService.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly string _externalUrl = "https://fakestoreapi.com/products";

    public ProductsController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _httpClient.GetFromJsonAsync<object>(_externalUrl);
        return Ok(products);
    }
}