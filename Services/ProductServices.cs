
using ProductsService.Models;
using System.Net.Http.Json;

namespace ProductsService.Services;

public class ProductService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiUrl = "https://fakestoreapi.com/products";

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<Product>>(_apiUrl);
        return result ?? new List<Product>();
    }
}

