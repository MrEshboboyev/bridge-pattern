using Microsoft.AspNetCore.Mvc;
using Application.Notifications;
using Infrastructure.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
    [HttpPost("order-confirmation/email")]
    public IActionResult SendOrderConfirmationEmail(string recipient)
    {
        var notification = new OrderConfirmation(new EmailSender());
        notification.Notify(recipient);
        return Ok("Order confirmation email sent.");
    }

    [HttpPost("order-confirmation/sms")]
    public IActionResult SendOrderConfirmationSms(string recipient)
    {
        var notification = new OrderConfirmation(new SmsSender());
        notification.Notify(recipient);
        return Ok("Order confirmation SMS sent.");
    }

    [HttpPost("promotion/push")]
    public IActionResult SendPromotionPush(string recipient)
    {
        var notification = new PromotionNotification(new PushSender());
        notification.Notify(recipient);
        return Ok("Promotional push notification sent.");
    }
}
