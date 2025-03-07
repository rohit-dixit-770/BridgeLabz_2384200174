using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Helper;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecondController : ControllerBase
    {

        private readonly EmailSender _emailSender;
        public SecondController(EmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpGet("Send-Mail")]
        public async Task<IActionResult> Get()
        {
            var receiver = "rkroxx770@gmail.com";
            var subject = "Testing SMTP";
            var message = "Hello, Rohit!";

            await _emailSender.SendEmailAsync(receiver, subject, message);

            return Ok($"Second Contoller Sended Mail to {receiver}");
        }

        [HttpGet]
        [Route("second")]
        public String Get1()
        {
            return "Second Get";
        }

    }
}
