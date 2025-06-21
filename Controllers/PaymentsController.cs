using Microsoft.AspNetCore.Mvc;
using PaymentsService.Models;

namespace PaymentsService.Controllers;

[ApiController]
[Route("api/payments")]
public class PaymentsController : ControllerBase
{
    [HttpPost]
    public IActionResult Pay([FromBody] PaymentRequest request)
    {
        if (request.Amount <= 0)
            return BadRequest("Invalid amount.");
        if (string.IsNullOrEmpty(request.PaymentMethod))
            return BadRequest("Payment method is required.");
        // Simulación de pago exitoso:
        return Ok(new { status = "success", message = $"Payment for Order {request.OrderId} processed successfully." });
    }
}