using Microsoft.AspNetCore.Mvc;
using OrdersService.Models;

namespace OrdersService.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private static readonly List<Order> Orders = new();

    [HttpGet]
    public IActionResult GetAll() => Ok(Orders);

    [HttpPost]
    public IActionResult Create([FromBody] Order order)
    {
        if (order.Items == null || order.Items.Count == 0)
            return BadRequest("Order must have at least one item.");
        order.Id = Orders.Count + 1;
        order.OrderDate = DateTime.UtcNow;
        Orders.Add(order);
        return Ok(order);
    }
}